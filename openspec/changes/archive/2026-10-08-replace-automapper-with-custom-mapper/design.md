# Design

## Context

`EventsHub.Application.Core.MappingProfiles` currently declares the only mapping, `Event` to `Event`, and `EditEvent.Handler` applies it to an entity loaded from `AppDbContext`. `EventsHub.Api/Program.cs` scans the Application assembly to register AutoMapper. See proposal.md for motivation and `specs/object-mapping/spec.md` for the behavior contract.

## Goals / Non-Goals

**Goals:**

- Provide an explicit, strongly typed custom profile API for mapping rules.
- Keep mapper resolution independent of individual profiles so future mappings can be added by registering another profile.
- Preserve mapping onto the tracked `Event` instance in the edit flow.
- Remove AutoMapper from application code and package references.

**Non-Goals:**

- Recreate all AutoMapper features, conventions, or configuration syntax.
- Add automatic assembly scanning or runtime profile discovery.
- Change event HTTP contracts, persistence behavior, or introduce DTOs as part of this change.

## Decisions

### Profiles contain typed mapping delegates

Define a project-owned profile abstraction that records typed source/destination pairs and their mapping action. A profile declares how its source values are applied to a destination instance. The current Event profile explicitly maps the writable Event properties, replacing AutoMapper's convention-based `CreateMap<Event, Event>()` behavior.

This favors compile-time checking and visible mapping behavior over reflection-based property copying. Preserving an AutoMapper-compatible `Profile` and `CreateMap` API was considered, but the requested custom profile API permits a smaller project-owned contract without carrying over a third-party abstraction.

### The mapper is profile-agnostic

Expose a mapper service that accepts a source and an existing destination. At construction, it gathers the mappings from the profiles supplied by dependency injection into a lookup keyed by source and destination types. A request resolves that pair and executes its delegate. If no pair is configured, throw an `InvalidOperationException` naming both types rather than silently copying or returning an unchanged object.

Mapping into an existing destination is the required first operation because event editing uses an entity already tracked by Entity Framework. Creating destination instances and nested or collection mapping are outside this change.

### Profiles are registered explicitly at the composition root

Register the current Event profile and the mapper in `Program.cs` through a project-owned service registration API. Future profiles are added by adding a profile and including it in that registration. Do not scan assemblies: explicit registration makes the configured mapping set visible and avoids accidental activation of incomplete profiles.

### Replace AutoMapper end to end

Update `EditEvent.Handler` to depend on the custom mapper abstraction, replace the AutoMapper-based Event profile, remove `AddAutoMapper`, and remove the AutoMapper package reference. Keep the edit handler's load-map-save order intact.

## Risks / Trade-offs

- **[Risk]** Explicit member assignments can omit a property as the Event model evolves. Mitigation: Add a mapping test that checks all current Event properties and requires intentional updates when the model changes.
- **[Risk]** Duplicate profile registrations can make a type pair ambiguous. Mitigation: Detect duplicate source/destination pairs while building the mapper and fail startup with the conflicting pair identified.
- **[Trade-off]** The custom mapper intentionally supports less than AutoMapper. Mitigation: Keep the initial contract limited to typed profiles and existing-destination mapping; add future behavior through explicit requirements and tests.

## Migration Plan

1. Add the custom profile abstraction, Event mapping profile, mapper service, and registration API.
2. Switch the edit handler and API composition root to the custom mapper and verify existing edit behavior.
3. Remove the AutoMapper package and imports once no production references remain.
4. Run the .NET test suite, including custom profile registration and missing-map cases.

Rollback is a source change rollback: restore the AutoMapper package, profile, and service registration together. No persisted data migration is involved.

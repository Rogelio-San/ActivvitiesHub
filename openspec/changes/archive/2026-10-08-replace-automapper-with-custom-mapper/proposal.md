# Proposal

## Why

EventsHub currently depends on AutoMapper for a single `Event` to `Event` mapping used by event edits. A small custom mapper can remove that dependency while providing a project-owned profile API that can grow with future mapping needs.

## What Changes

- Introduce a custom mapper that applies mappings declared in custom mapping profiles.
- Replace the current AutoMapper `MappingProfiles` configuration and `IMapper` usage in event editing.
- Register mapping profiles explicitly with the application at startup so future profiles can be added through the same extension point.
- Remove the AutoMapper package dependency.

## Capabilities

### New Capabilities

- `object-mapping`: Profile-driven mapping from source objects to destination objects, including updating an existing destination instance.

### Modified Capabilities

None.

## Impact

- `EventsHub.Application`: custom mapper and profile abstractions; event edit handler integration; removal of AutoMapper dependency.
- `EventsHub.Api/Program.cs`: explicit registration of mapping profiles and mapper services.
- `EventsHub.UnitTests`: coverage for profile registration, current Event mapping behavior, and adding additional custom profiles.
- No HTTP route or request/response contract changes are intended.

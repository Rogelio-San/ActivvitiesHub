# object-mapping Specification

## Purpose

Provides profile-driven object mapping inside EventsHub so application code can update destination objects consistently and add mappings as new needs arise.

## Requirements

### Requirement: Mapping profiles define supported type pairs
The application SHALL allow custom mapping profiles to declare how a source object maps to a destination object, and SHALL make explicitly registered profiles available to the mapper.

#### Scenario: A registered profile provides a mapping
- **WHEN** application code requests a mapping for a source and destination type pair declared by a registered profile
- **THEN** the mapper applies the mapping defined by that profile

#### Scenario: A future profile is registered
- **WHEN** a new custom profile declares a mapping and is explicitly registered with the application
- **THEN** the mapper can use that mapping without changing the mapper's core implementation

### Requirement: Mapping updates an existing destination
The application SHALL support applying a configured mapping to an existing destination object while preserving the destination instance used by the caller.

#### Scenario: Edit an existing event
- **WHEN** an event edit maps the submitted `Event` onto the event loaded from persistence
- **THEN** mapped event values are applied to the loaded event instance and that instance remains tracked for saving

### Requirement: Unconfigured mappings fail clearly
The mapper SHALL report a clear configuration error when application code requests a source and destination type pair that no registered profile declares.

#### Scenario: Request an undeclared type pair
- **WHEN** application code requests a mapping for a type pair absent from all registered profiles
- **THEN** the mapper reports which source and destination types have no configured mapping

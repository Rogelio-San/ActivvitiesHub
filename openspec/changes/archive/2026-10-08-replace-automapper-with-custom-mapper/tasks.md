# Tasks

## 1. Custom mapper foundation

- [x] 1.1 Define the typed custom profile and mapping registration abstractions in `EventsHub.Application.Core`; verify the API can register a test mapping without AutoMapper types.
- [x] 1.2 Implement mapper lookup and execution for registered source/destination pairs, including clear errors for missing and duplicate pairs; verify both error paths with unit tests.

## 2. Preserve Event mapping behavior

- [x] 2.1 Replace the AutoMapper Event profile with a custom profile that maps the current Event properties onto an existing destination; verify a mapping test checks each Event property and preserves destination identity.
- [x] 2.2 Add unit coverage proving another custom profile can be registered and used without changes to mapper internals; verify the profile registration test passes.

## 3. Integrate the custom mapper

- [x] 3.1 Update `EditEvent.Handler` and API startup to use explicit custom profile registration and the custom mapper; verify an edit updates the loaded tracked Event and persists the changes.
- [x] 3.2 Remove AutoMapper package references, imports, and registration; verify `rg -n "AutoMapper|IMapper|AddAutoMapper" src tests` returns no production references.
- [x] 3.3 Run `dotnet test EventsHub.slnx` and verify the solution test suite passes with the custom mapper integration.

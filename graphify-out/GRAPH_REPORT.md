# Graph Report - EventsHub  (2026-10-08)

## Corpus Check
- 86 files · ~67,425 words
- Verdict: corpus is large enough that graph structure adds value.
- Unclassified: 11 file(s) not represented in the graph (top: (none) 8, .css 2, .nswag 1)

## Summary
- 529 nodes · 751 edges · 42 communities (28 shown, 14 thin omitted)
- Extraction: 97% EXTRACTED · 3% INFERRED · 0% AMBIGUOUS · INFERRED: 19 edges (avg confidence: 0.88)
- Token cost: 0 input · 0 output

## Graph Freshness
- Built from commit: `0601eb8d`
- Run `git rev-parse HEAD` and compare to check if the graph is stale.
- Run `graphify update .` after code changes (no API cost).

## Community Hubs (Navigation)
- EventsRpcClient
- Event
- EventsHub.Domain.csproj
- IRequest
- EventsHubBaseController
- EventsControllerTests.cs
- .GetEventsAsync
- compilerOptions
- devDependencies
- Event
- compilerOptions
- EventsHub/package.json
- https
- main.tsx
- EventsHub.OpenApi
- dependencies
- WeatherForecast
- AppDbContext
- eslint.config.js
- vite.config.ts
- scripts
- React + TypeScript + Vite
- web/package.json
- tsconfig.json
- CLAUDE.md
- .claude/CLAUDE.md
- README.md
- index.d.ts
- Handler
- CustomMapperTests
- ADDED Requirements
- Requirements
- Command
- Handler
- Proposal
- AppDbContextModelSnapshot
- Handler

## God Nodes (most connected - your core abstractions)
1. `Event` - 24 edges
2. `EventsRpcClient` - 20 edges
3. `WeatherForecastRpcClient` - 19 edges
4. `compilerOptions` - 18 edges
5. `ApiException` - 16 edges
6. `compilerOptions` - 15 edges
7. `CustomMapperTests` - 14 edges
8. `AppDbContext` - 14 edges
9. `Event` - 13 edges
10. `Handler` - 10 edges

## Surprising Connections (you probably didn't know these)
- `Step 3: Create `nswag/EventsHub.nswag` (checked-in codegen config)` --references--> `ApiException`  [INFERRED]
  docs/OpenApi 1.md → src/src/EventsHub.OpenApi/Generated/EventsHubRpcClient.generated.cs
- `Context` --references--> `AppDbContext`  [INFERRED]
  openspec/changes/archive/2026-10-08-replace-automapper-with-custom-mapper/design.md → src/EventsHub.Persistence/AppDbContext.cs
- `Replace AutoMapper end to end` --references--> `Handler`  [INFERRED]
  openspec/changes/archive/2026-10-08-replace-automapper-with-custom-mapper/design.md → src/EventsHub.Application/Events/Commands/EditEvent.cs
- `3. Integrate the custom mapper` --references--> `Handler`  [INFERRED]
  openspec/changes/archive/2026-10-08-replace-automapper-with-custom-mapper/tasks.md → src/EventsHub.Application/Events/Commands/EditEvent.cs
- `Context` --references--> `Handler`  [INFERRED]
  openspec/changes/archive/2026-10-08-replace-automapper-with-custom-mapper/design.md → src/EventsHub.Application/Events/Commands/EditEvent.cs

## Import Cycles
- None detected.

## Communities (42 total, 14 thin omitted)

### Community 0 - "EventsRpcClient"
Cohesion: 0.08
Nodes (20): EventsHub.OpenApi.Client, ApiException, Headers, Response, Result, StatusCode, DateFormatConverter, EventsRpcClient (+12 more)

### Community 1 - "Event"
Cohesion: 0.17
Nodes (11): Event, Category, City, Date, Description, Id, isCancelled, Latitude (+3 more)

### Community 2 - "EventsHub.Domain.csproj"
Cohesion: 0.07
Nodes (26): EventsHub.UnitTests.Core, net10.0, coverlet.collector (6.0.4), MediatR (14.2.0), Microsoft.AspNetCore.Mvc.NewtonsoftJson (10.0.11), Microsoft.AspNetCore.OpenApi (10.0.11), Microsoft.EntityFrameworkCore.Design (10.0.11), Microsoft.EntityFrameworkCore.Sqlite (10.0.11) (+18 more)

### Community 3 - "IRequest"
Cohesion: 0.20
Nodes (9): Command, Event, CreateEvent, Command, Id, DeleteEvent, GetEventDetails, Query (+1 more)

### Community 4 - "EventsHubBaseController"
Cohesion: 0.11
Nodes (12): Current state on this branch, Manual setup — OpenAPI doc generation + typed client for the EventsHub API, Part 1 — Manually scaffold the pieces, Part 2 — Populate the generated content, Step 1: Create `src/EventsHub.OpenApi/` (the standalone doc-generation host), Step 2: Create `openapi/` (generated output folder), Step 3: Create `nswag/EventsHub.nswag` (checked-in codegen config), Step 4: Register the NSwag CLI as a local tool (+4 more)

### Community 5 - "EventsControllerTests.cs"
Cohesion: 0.06
Nodes (11): EventsHub.Domain, EventsHub.Persistence.Migrations, EventsHub.UnitTests.Events.Commands, EventsHub.Application.Events.Queries, EventsHub.Api.Controllers, EventsHub.Application.Events.Commands, EventsHub.UnitTests, EventsHub.Persistence (+3 more)

### Community 7 - "compilerOptions"
Cohesion: 0.10
Nodes (19): compilerOptions, allowArbitraryExtensions, allowImportingTsExtensions, erasableSyntaxOnly, jsx, lib, module, moduleDetection (+11 more)

### Community 8 - "devDependencies"
Cohesion: 0.11
Nodes (18): devDependencies, @babel/core, babel-plugin-react-compiler, eslint, @eslint/js, eslint-plugin-react-hooks, eslint-plugin-react-refresh, globals (+10 more)

### Community 9 - "Event"
Cohesion: 0.12
Nodes (16): Event, Category, City, Date, Description, Id, IsCancelled, Latitude (+8 more)

### Community 10 - "compilerOptions"
Cohesion: 0.12
Nodes (16): compilerOptions, allowImportingTsExtensions, erasableSyntaxOnly, lib, module, moduleDetection, noEmit, noFallthroughCasesInSwitch (+8 more)

### Community 11 - "EventsHub/package.json"
Cohesion: 0.12
Nodes (15): @babel/core, babel-plugin-react-compiler, @emotion/react, @emotion/styled, @mui/icons-material, @types/babel__core, @types/node, @types/react (+7 more)

### Community 12 - "https"
Cohesion: 0.20
Nodes (9): ASPNETCORE_ENVIRONMENT, applicationUrl, commandName, dotnetRunMessages, environmentVariables, launchBrowser, profiles, https (+1 more)

### Community 13 - "main.tsx"
Cohesion: 0.28
Nodes (6): axios, @fontsource/roboto, @mui/material, react, react-dom, App()

### Community 14 - "EventsHub.OpenApi"
Cohesion: 0.22
Nodes (8): ASPNETCORE_ENVIRONMENT, applicationUrl, commandName, environmentVariables, launchBrowser, profiles, EventsHub.OpenApi, $schema

### Community 15 - "dependencies"
Cohesion: 0.22
Nodes (9): dependencies, axios, @emotion/react, @emotion/styled, @fontsource/roboto, @mui/icons-material, @mui/material, react (+1 more)

### Community 16 - "WeatherForecast"
Cohesion: 0.25
Nodes (6): EventsHub.Api, WeatherForecast, Date, Summary, TemperatureC, TemperatureF

### Community 17 - "AppDbContext"
Cohesion: 0.16
Nodes (5): AppDbContext, Events, DbInitializer, GlobalTestSetup, AppDbContext

### Community 18 - "eslint.config.js"
Cohesion: 0.29
Nodes (6): eslint, @eslint/js, eslint-plugin-react-hooks, eslint-plugin-react-refresh, globals, typescript-eslint

### Community 19 - "vite.config.ts"
Cohesion: 0.40
Nodes (3): @rolldown/plugin-babel, vite, @vitejs/plugin-react

### Community 20 - "scripts"
Cohesion: 0.40
Nodes (5): scripts, build, dev, lint, preview

### Community 21 - "React + TypeScript + Vite"
Cohesion: 0.50
Nodes (3): Expanding the ESLint configuration, React Compiler, React + TypeScript + Vite

### Community 22 - "web/package.json"
Cohesion: 0.50
Nodes (3): devDependencies, vite-plugin-mkcert, vite-plugin-mkcert

### Community 28 - "Handler"
Cohesion: 0.07
Nodes (19): Context, Decisions, Design, Goals / Non-Goals, Migration Plan, Profiles are registered explicitly at the composition root, Profiles contain typed mapping delegates, Replace AutoMapper end to end (+11 more)

### Community 29 - "CustomMapperTests"
Cohesion: 0.15
Nodes (13): EventMappingProfile, CustomMapperTests, DuplicateTestMappingProfile, FutureDestination, Label, FutureMappingProfile, FutureSource, Name (+5 more)

### Community 30 - "ADDED Requirements"
Cohesion: 0.18
Nodes (10): ADDED Requirements, Purpose, Requirement: Mapping profiles define supported type pairs, Requirement: Mapping updates an existing destination, Requirement: Unconfigured mappings fail clearly, Scenario: A future profile is registered, Scenario: A registered profile provides a mapping, Scenario: Edit an existing event (+2 more)

### Community 31 - "Requirements"
Cohesion: 0.18
Nodes (10): object-mapping Specification, Purpose, Requirement: Mapping profiles define supported type pairs, Requirement: Mapping updates an existing destination, Requirement: Unconfigured mappings fail clearly, Requirements, Scenario: A future profile is registered, Scenario: A registered profile provides a mapping (+2 more)

### Community 33 - "Handler"
Cohesion: 0.32
Nodes (3): GetEventList, Handler, Query

### Community 34 - "Proposal"
Cohesion: 0.25
Nodes (7): Capabilities, Impact, Modified Capabilities, New Capabilities, Proposal, What Changes, Why

## Knowledge Gaps
- **206 isolated node(s):** `Goals / Non-Goals`, `Profiles contain typed mapping delegates`, `The mapper is profile-agnostic`, `Profiles are registered explicitly at the composition root`, `Risks / Trade-offs` (+201 more)
  These have ≤1 connection - possible missing edges or undocumented components. (Counts symbols only; 285 node(s) total have ≤1 connection when file, concept and rationale nodes are included.)
- **14 thin communities (<3 nodes) omitted from report** — run `graphify query` to explore isolated nodes.

## Suggested Questions
_Questions this graph is uniquely positioned to answer:_

- **Why does `ApiException` connect `EventsRpcClient` to `EventsHubBaseController`, `.GetEventsAsync`?**
  _High betweenness centrality (0.154) - this node is a cross-community bridge._
- **What connects `Goals / Non-Goals`, `Profiles contain typed mapping delegates`, `The mapper is profile-agnostic` to the rest of the system?**
  _206 weakly-connected nodes found - possible documentation gaps or missing edges._
- **Should `EventsRpcClient` be split into smaller, more focused modules?**
  _Cohesion score 0.07562136435748282 - nodes in this community are weakly interconnected._
- **Why does `Event` connect `Event` to `Handler`, `IRequest`, `Handler`, `EventsControllerTests.cs`, `.GetEventsAsync`, `AppDbContext`?**
  _High betweenness centrality (0.108) - this node is a cross-community bridge._
- **Should `EventsHub.Domain.csproj` be split into smaller, more focused modules?**
  _Cohesion score 0.07130124777183601 - nodes in this community are weakly interconnected._
- **Why does `EventsControllerTests` connect `.GetEventsAsync` to `EventsControllerTests.cs`?**
  _High betweenness centrality (0.093) - this node is a cross-community bridge._
- **Should `EventsHubBaseController` be split into smaller, more focused modules?**
  _Cohesion score 0.10526315789473684 - nodes in this community are weakly interconnected._
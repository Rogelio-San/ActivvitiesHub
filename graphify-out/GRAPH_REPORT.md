# Graph Report - EventsHub  (2026-11-25)

## Corpus Check
- 105 files · ~100,855 words
- Verdict: corpus is large enough that graph structure adds value.
- Unclassified: 14 file(s) not represented in the graph (top: (none) 10, .css 3, .nswag 1)

## Summary
- 667 nodes · 966 edges · 58 communities (31 shown, 27 thin omitted)
- Extraction: 97% EXTRACTED · 3% INFERRED · 0% AMBIGUOUS · INFERRED: 33 edges (avg confidence: 0.88)
- Token cost: 0 input · 0 output

## Graph Freshness
- Built from commit: `33d8c05b`
- Run `git rev-parse HEAD` and compare to check if the graph is stale.
- Run `graphify update .` after code changes (no API cost).

## Community Hubs (Navigation)
- EventsRpcClient
- Event
- EventsHub.UniTests.csproj
- compilerOptions
- EventsHubBaseController
- EventsHub.Domain
- EventsController
- compilerOptions
- dependencies
- Event
- .agents/skills/openspec-explore/SKILL.md
- web/package.json
- https
- @mui/material
- EventsHub.OpenApi
- .claude/skills/openspec-explore/SKILL.md
- WeatherForecast
- AppDbContext
- opsx-explore.md
- explore.md
- EventsHub web client
- Tasks
- devDependencies
- package.json
- CLAUDE.md
- .claude/CLAUDE.md
- task-runner.json
- tsconfig.json
- Design
- CustomMapperTests
- ADDED Requirements
- Requirements
- Command
- Proposal
- index.d.ts
- Handler

## God Nodes (most connected - your core abstractions)
1. `Event` - 27 edges
2. `EventsRpcClient` - 20 edges
3. `WeatherForecastRpcClient` - 19 edges
4. `compilerOptions` - 18 edges
5. `AppDbContext` - 17 edges
6. `ApiException` - 16 edges
7. `@mui/material` - 15 edges
8. `compilerOptions` - 15 edges
9. `CustomMapperTests` - 14 edges
10. `Event` - 13 edges

## Surprising Connections (you probably didn't know these)
- `Replace AutoMapper end to end` --references--> `Handler`  [INFERRED]
  openspec/changes/archive/2026-10-08-replace-automapper-with-custom-mapper/design.md → src/EventsHub.Application/Events/Commands/EditEvent.cs
- `3. Integrate the custom mapper` --references--> `Handler`  [INFERRED]
  openspec/changes/archive/2026-10-08-replace-automapper-with-custom-mapper/tasks.md → src/EventsHub.Application/Events/Commands/EditEvent.cs
- `Step 3: Create `nswag/EventsHub.nswag` (checked-in codegen config)` --references--> `ApiException`  [INFERRED]
  docs/OpenApi 1.md → src/src/EventsHub.OpenApi/Generated/EventsHubRpcClient.generated.cs
- `Context` --references--> `AppDbContext`  [INFERRED]
  openspec/changes/archive/2026-10-08-replace-automapper-with-custom-mapper/design.md → src/EventsHub.Persistence/AppDbContext.cs
- `How the components connect` --references--> `AppDbContext`  [INFERRED]
  README.md → src/EventsHub.Persistence/AppDbContext.cs

## Import Cycles
- None detected.

## Communities (58 total, 27 thin omitted)

### Community 0 - "EventsRpcClient"
Cohesion: 0.07
Nodes (20): EventsHub.OpenApi.Client, ApiException, Headers, Response, Result, StatusCode, DateFormatConverter, EventsRpcClient (+12 more)

### Community 1 - "Event"
Cohesion: 0.08
Nodes (23): Command, Event, Command, Event, EditEvent, GetEventDetails, Handler, Query (+15 more)

### Community 2 - "EventsHub.UniTests.csproj"
Cohesion: 0.08
Nodes (25): coverlet.collector (6.0.4), MediatR (14.2.0), Microsoft.AspNetCore.Mvc.NewtonsoftJson (10.0.11), Microsoft.AspNetCore.OpenApi (10.0.11), Microsoft.EntityFrameworkCore.Design (10.0.11), Microsoft.EntityFrameworkCore.Sqlite (10.0.11), Microsoft.NET.Test.Sdk (17.14.0), Moq (4.20.72) (+17 more)

### Community 3 - "compilerOptions"
Cohesion: 0.10
Nodes (19): compilerOptions, allowArbitraryExtensions, allowImportingTsExtensions, erasableSyntaxOnly, jsx, lib, module, moduleDetection (+11 more)

### Community 4 - "EventsHubBaseController"
Cohesion: 0.11
Nodes (12): Current state on this branch, Manual setup — OpenAPI doc generation + typed client for the EventsHub API, Part 1 — Manually scaffold the pieces, Part 2 — Populate the generated content, Step 1: Create `src/EventsHub.OpenApi/` (the standalone doc-generation host), Step 2: Create `openapi/` (generated output folder), Step 3: Create `nswag/EventsHub.nswag` (checked-in codegen config), Step 4: Register the NSwag CLI as a local tool (+4 more)

### Community 5 - "EventsHub.Domain"
Cohesion: 0.06
Nodes (13): EventsHub.Domain, EventsHub.UnitTests.Core, EventsHub.Persistence.Migrations, EventsHub.UnitTests.Events.Commands, EventsHub.Application.Events.Queries, EventsHub.Api.Controllers, EventsHub.Application.Events.Commands, EventsHub.UnitTests (+5 more)

### Community 6 - "EventsController"
Cohesion: 0.09
Nodes (8): EventsHub, How the components connect, Repository layout, Requirements, Run locally, Useful commands, EventsController, EventsControllerTests

### Community 7 - "compilerOptions"
Cohesion: 0.12
Nodes (16): compilerOptions, allowImportingTsExtensions, erasableSyntaxOnly, lib, module, moduleDetection, noEmit, noFallthroughCasesInSwitch (+8 more)

### Community 8 - "dependencies"
Cohesion: 0.15
Nodes (13): dependencies, axios, @emotion/react, @emotion/styled, @fontsource/roboto, @mui/icons-material, @mui/material, react (+5 more)

### Community 9 - "Event"
Cohesion: 0.12
Nodes (16): Event, Category, City, Date, Description, Id, IsCancelled, Latitude (+8 more)

### Community 10 - ".agents/skills/openspec-explore/SKILL.md"
Cohesion: 0.17
Nodes (11): Check for context, Ending Discovery, Guardrails, Handling Different Entry Points, OpenSpec Awareness, Planning a Change, The Stance, What You Don't Have To Do (+3 more)

### Community 11 - "web/package.json"
Cohesion: 0.07
Nodes (35): @babel/core, babel-plugin-react-compiler, @emotion/react, @emotion/styled, eslint, eslint-config-prettier, @eslint/js, eslint-plugin-react-hooks (+27 more)

### Community 12 - "https"
Cohesion: 0.20
Nodes (9): ASPNETCORE_ENVIRONMENT, applicationUrl, commandName, dotnetRunMessages, environmentVariables, launchBrowser, profiles, https (+1 more)

### Community 13 - "@mui/material"
Cohesion: 0.09
Nodes (30): axios, @fontsource/roboto, @mui/icons-material, @mui/material, react, react-dom, react-router, @tanstack/react-query (+22 more)

### Community 14 - "EventsHub.OpenApi"
Cohesion: 0.22
Nodes (8): ASPNETCORE_ENVIRONMENT, applicationUrl, commandName, environmentVariables, launchBrowser, profiles, EventsHub.OpenApi, $schema

### Community 15 - ".claude/skills/openspec-explore/SKILL.md"
Cohesion: 0.17
Nodes (11): Check for context, Ending Discovery, Guardrails, Handling Different Entry Points, OpenSpec Awareness, Planning a Change, The Stance, What You Don't Have To Do (+3 more)

### Community 16 - "WeatherForecast"
Cohesion: 0.25
Nodes (6): EventsHub.Api, WeatherForecast, Date, Summary, TemperatureC, TemperatureF

### Community 17 - "AppDbContext"
Cohesion: 0.16
Nodes (5): AppDbContext, Events, DbInitializer, GlobalTestSetup, AppDbContext

### Community 18 - "opsx-explore.md"
Cohesion: 0.18
Nodes (10): Check for context, Ending Discovery, Guardrails, OpenSpec Awareness, Planning a Change, The Stance, What You Don't Have To Do, What You Might Do (+2 more)

### Community 19 - "explore.md"
Cohesion: 0.18
Nodes (10): Check for context, Ending Discovery, Guardrails, OpenSpec Awareness, Planning a Change, The Stance, What You Don't Have To Do, What You Might Do (+2 more)

### Community 20 - "EventsHub web client"
Cohesion: 0.33
Nodes (5): API connection, EventsHub web client, Install and run, Requirements, Scripts

### Community 21 - "Tasks"
Cohesion: 0.40
Nodes (4): 1. Custom mapper foundation, 2. Preserve Event mapping behavior, 3. Integrate the custom mapper, Tasks

### Community 22 - "devDependencies"
Cohesion: 0.10
Nodes (21): devDependencies, @babel/core, babel-plugin-react-compiler, eslint, eslint-config-prettier, @eslint/js, eslint-plugin-react-hooks, eslint-plugin-react-refresh (+13 more)

### Community 23 - "package.json"
Cohesion: 0.50
Nodes (3): dependencies, react-calendar, react-calendar

### Community 28 - "Design"
Cohesion: 0.20
Nodes (9): Decisions, Design, Goals / Non-Goals, Migration Plan, Profiles are registered explicitly at the composition root, Profiles contain typed mapping delegates, Replace AutoMapper end to end, Risks / Trade-offs (+1 more)

### Community 29 - "CustomMapperTests"
Cohesion: 0.09
Nodes (19): CustomMapper, EventMappingProfile, MappingDefinition, MappingKey, MappingProfile, Mappings, CustomMapperTests, DuplicateTestMappingProfile (+11 more)

### Community 30 - "ADDED Requirements"
Cohesion: 0.18
Nodes (10): ADDED Requirements, Purpose, Requirement: Mapping profiles define supported type pairs, Requirement: Mapping updates an existing destination, Requirement: Unconfigured mappings fail clearly, Scenario: A future profile is registered, Scenario: A registered profile provides a mapping, Scenario: Edit an existing event (+2 more)

### Community 31 - "Requirements"
Cohesion: 0.18
Nodes (10): object-mapping Specification, Purpose, Requirement: Mapping profiles define supported type pairs, Requirement: Mapping updates an existing destination, Requirement: Unconfigured mappings fail clearly, Requirements, Scenario: A future profile is registered, Scenario: A registered profile provides a mapping (+2 more)

### Community 32 - "Command"
Cohesion: 0.18
Nodes (6): CreateEvent, Handler, Command, Id, DeleteEvent, Handler

### Community 34 - "Proposal"
Cohesion: 0.25
Nodes (7): Capabilities, Impact, Modified Capabilities, New Capabilities, Proposal, What Changes, Why

### Community 40 - "Handler"
Cohesion: 0.29
Nodes (3): Context, IObjectMapper, Handler

## Knowledge Gaps
- **265 isolated node(s):** `$schema`, `tasks`, `react-calendar`, `react-calendar`, `Mediator` (+260 more)
  These have ≤1 connection - possible missing edges or undocumented components. (Counts symbols only; 364 node(s) total have ≤1 connection when file, concept and rationale nodes are included.)
- **27 thin communities (<3 nodes) omitted from report** — run `graphify query` to explore isolated nodes.

## Suggested Questions
_Questions this graph is uniquely positioned to answer:_

- **Why does `WeatherForecastController` connect `EventsHubBaseController` to `EventsHub.Domain`?**
  _High betweenness centrality (0.100) - this node is a cross-community bridge._
- **What connects `$schema`, `tasks`, `react-calendar` to the rest of the system?**
  _265 weakly-connected nodes found - possible documentation gaps or missing edges._
- **Should `EventsRpcClient` be split into smaller, more focused modules?**
  _Cohesion score 0.07373271889400922 - nodes in this community are weakly interconnected._
- **Should `Event` be split into smaller, more focused modules?**
  _Cohesion score 0.08021390374331551 - nodes in this community are weakly interconnected._
- **Should `EventsHub.UniTests.csproj` be split into smaller, more focused modules?**
  _Cohesion score 0.07661290322580645 - nodes in this community are weakly interconnected._
- **Should `compilerOptions` be split into smaller, more focused modules?**
  _Cohesion score 0.1 - nodes in this community are weakly interconnected._
- **Should `EventsHubBaseController` be split into smaller, more focused modules?**
  _Cohesion score 0.10526315789473684 - nodes in this community are weakly interconnected._
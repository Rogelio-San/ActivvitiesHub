# Graph Report - EventsHub  (2026-10-08)

## Corpus Check
- 52 files · ~9,407 words
- Verdict: corpus is large enough that graph structure adds value.
- Unclassified: 7 file(s) not represented in the graph (top: (none) 4, .css 2, .nswag 1)

## Summary
- 436 nodes · 636 edges · 28 communities (21 shown, 7 thin omitted)
- Extraction: 98% EXTRACTED · 2% INFERRED · 0% AMBIGUOUS · INFERRED: 10 edges (avg confidence: 0.87)
- Token cost: 0 input · 0 output

## Graph Freshness
- Built from commit: `f8d54d33`
- Run `git rev-parse HEAD` and compare to check if the graph is stale.
- Run `graphify update .` after code changes (no API cost).

## Community Hubs (Navigation)
- EventsRpcClient
- Event
- EventsHub.UniTests.csproj
- EventsHub.Persistence
- EventsHubBaseController
- 20260901012910_InitialCreate.Designer.cs
- EventsController
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
- GlobalTestSetup
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

## God Nodes (most connected - your core abstractions)
1. `Event` - 25 edges
2. `EventsRpcClient` - 20 edges
3. `WeatherForecastRpcClient` - 19 edges
4. `compilerOptions` - 18 edges
5. `ApiException` - 16 edges
6. `compilerOptions` - 15 edges
7. `AppDbContext` - 14 edges
8. `Event` - 13 edges
9. `EventsHub.Persistence` - 11 edges
10. `EventsController` - 9 edges

## Surprising Connections (you probably didn't know these)
- `Step 3: Create `nswag/EventsHub.nswag` (checked-in codegen config)` --references--> `ApiException`  [INFERRED]
  docs/OpenApi 1.md → src/src/EventsHub.OpenApi/Generated/EventsHubRpcClient.generated.cs
- `Step 1: Create `src/EventsHub.OpenApi/` (the standalone doc-generation host)` --references--> `WeatherForecastController`  [INFERRED]
  docs/OpenApi 1.md → src/EventsHub.Api/Controllers/WeatherForecastController.cs
- `GlobalTestSetup` --references--> `AppDbContext`  [EXTRACTED]
  tests/EventsHub.UnitTests/GlobalTestSetup.cs → src/EventsHub.Persistence/AppDbContext.cs
- `EventsControllerTests` --references--> `EventsController`  [EXTRACTED]
  tests/EventsHub.UnitTests/Controllers/EventsControllerTests.cs → src/EventsHub.Api/Controllers/EventsController.cs
- `EventsController` --inherits--> `EventsHubBaseController`  [EXTRACTED]
  src/EventsHub.Api/Controllers/EventsController.cs → src/EventsHub.Api/Controllers/EventsHubBaseController.cs

## Import Cycles
- None detected.

## Communities (28 total, 7 thin omitted)

### Community 0 - "EventsRpcClient"
Cohesion: 0.07
Nodes (20): EventsHub.OpenApi.Client, ApiException, Headers, Response, Result, StatusCode, DateFormatConverter, EventsRpcClient (+12 more)

### Community 1 - "Event"
Cohesion: 0.06
Nodes (26): Command, Event, CreateEvent, Handler, Handler, Command, Event, EditEvent (+18 more)

### Community 2 - "EventsHub.UniTests.csproj"
Cohesion: 0.07
Nodes (26): AutoMapper (13.0.1), coverlet.collector (6.0.4), MediatR (14.2.0), Microsoft.AspNetCore.Mvc.NewtonsoftJson (10.0.11), Microsoft.AspNetCore.OpenApi (10.0.11), Microsoft.EntityFrameworkCore.Design (10.0.11), Microsoft.EntityFrameworkCore.Sqlite (10.0.11), Microsoft.NET.Test.Sdk (17.14.0) (+18 more)

### Community 3 - "EventsHub.Persistence"
Cohesion: 0.11
Nodes (13): EventsHub.Domain, EventsHub.Application.Events.Queries, EventsHub.Application.Events.Commands, EventsHub.Persistence, EventsHub.Application.Core, MappingProfiles, Command, Id (+5 more)

### Community 4 - "EventsHubBaseController"
Cohesion: 0.08
Nodes (14): EventsHub.Api.Controllers, EventsHub.UnitTests.Controllers, Current state on this branch, Manual setup — OpenAPI doc generation + typed client for the EventsHub API, Part 1 — Manually scaffold the pieces, Part 2 — Populate the generated content, Step 1: Create `src/EventsHub.OpenApi/` (the standalone doc-generation host), Step 2: Create `openapi/` (generated output folder) (+6 more)

### Community 5 - "20260901012910_InitialCreate.Designer.cs"
Cohesion: 0.10
Nodes (4): EventsHub.Persistence.Migrations, EventsHub.UnitTests, InitialCreate, AppDbContextModelSnapshot

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

## Knowledge Gaps
- **179 isolated node(s):** `Mediator`, `net10.0`, `Microsoft.AspNetCore.OpenApi (10.0.11)`, `Microsoft.EntityFrameworkCore.Design (10.0.11)`, `Microsoft.NET.Sdk.Web` (+174 more)
  These have ≤1 connection - possible missing edges or undocumented components. (Counts symbols only; 237 node(s) total have ≤1 connection when file, concept and rationale nodes are included.)
- **7 thin communities (<3 nodes) omitted from report** — run `graphify query` to explore isolated nodes.

## Suggested Questions
_Questions this graph is uniquely positioned to answer:_

- **What connects `Mediator`, `net10.0`, `Microsoft.AspNetCore.OpenApi (10.0.11)` to the rest of the system?**
  _179 weakly-connected nodes found - possible documentation gaps or missing edges._
- **Should `EventsRpcClient` be split into smaller, more focused modules?**
  _Cohesion score 0.07373271889400922 - nodes in this community are weakly interconnected._
- **Should `Event` be split into smaller, more focused modules?**
  _Cohesion score 0.05580693815987934 - nodes in this community are weakly interconnected._
- **Should `EventsHub.UniTests.csproj` be split into smaller, more focused modules?**
  _Cohesion score 0.07386363636363637 - nodes in this community are weakly interconnected._
- **Should `EventsHub.Persistence` be split into smaller, more focused modules?**
  _Cohesion score 0.10752688172043011 - nodes in this community are weakly interconnected._
- **Should `EventsHubBaseController` be split into smaller, more focused modules?**
  _Cohesion score 0.07635467980295567 - nodes in this community are weakly interconnected._
- **Should `20260901012910_InitialCreate.Designer.cs` be split into smaller, more focused modules?**
  _Cohesion score 0.09788359788359788 - nodes in this community are weakly interconnected._
# EventsHub

EventsHub is an event management application with a React and TypeScript web client and an ASP.NET Core API. The API stores event data in SQLite.

## Repository layout

- `src/EventsHub.Api` exposes the HTTP API and wires up the application and database services.
- `src/EventsHub.Application` contains event commands and queries, handled through MediatR, plus mapping profiles.
- `src/EventsHub.Domain` contains the event domain model.
- `src/EventsHub.Persistence` provides the Entity Framework Core SQLite context, migrations, and seed data.
- `src/EventsHub.OpenApi` contains OpenAPI client and generation support.
- `web/EventsHub` contains the React, TypeScript, and Vite web client. See its [README](web/EventsHub/README.md) for frontend commands.
- `tests/EventsHub.UnitTests` contains the .NET unit test project.

### How the components connect

The web client makes HTTP requests to the API. The API's `EventsController` sends event commands and queries to MediatR handlers in the Application project. Those handlers use the Domain event model and the Persistence project's `AppDbContext` to read and write SQLite data. The API configures the database, registers handlers and mappings, applies migrations, and seeds initial data at startup.

## Requirements

- .NET 10 SDK
- Node.js and npm

## Run locally

Start the API from the repository root:

```bash
dotnet run --project src/EventsHub.Api/EventsHub.Api.csproj
```

The configured HTTPS API address is `https://localhost:5001`. Event endpoints are under `/api/v1/Events`:

- `GET /api/v1/Events` lists events.
- `GET /api/v1/Events/{id}` gets an event.
- `POST /api/v1/Events` creates an event.
- `PUT /api/v1/Events` edits an event.
- `DELETE /api/v1/Events/{id}` deletes an event.

The API creates or updates `eventshub.db` in its working directory and seeds data when it starts.

In a second terminal, start the web client:

```bash
cd web/EventsHub
npm ci
npm run dev
```

Vite serves the client at `http://localhost:3000`. The API allows requests from the HTTP and HTTPS localhost client origins on port 3000.

## Useful commands

Run the .NET tests:

```bash
dotnet test EventsHub.slnx
```

Run frontend linting and build:

```bash
cd web/EventsHub
npm run lint
npm run build
```

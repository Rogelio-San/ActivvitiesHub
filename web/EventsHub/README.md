# EventsHub web client

The web client is a React 19 and TypeScript single-page application built with Vite. It uses Material UI for components and Axios for HTTP requests to the EventsHub API.

## Requirements

- Node.js with npm
- The EventsHub API running locally (see the [repository README](../../README.md))

## Install and run

From this directory:

```bash
npm ci
npm run dev
```

Vite serves the client at `http://localhost:3000`. The API must allow that origin; the current API configuration permits HTTP and HTTPS on localhost port 3000.

## Scripts

- `npm run dev` starts the Vite development server.
- `npm run build` type-checks the project and creates a production build in `dist/`.
- `npm run preview` serves the production build locally.
- `npm run lint` runs ESLint.

## API connection

The client calls the ASP.NET Core API over HTTP. Event routes use the `/api/v1/Events` base path; see the repository README for the available operations and the API's local address.

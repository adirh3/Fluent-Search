# Result selector trigger

**Type:** `Result selector`

The Result selector trigger lets you attach custom operations to existing Fluent Search results (for example add an “Open in VS Code” action to File/Folder results).

## Common settings

- **name**: Filter by displayed name (often `Contains`).
- **type**: Filter by result type (commonly `File`, `Folder`, `App`).
- **searchApp**: Filter by the originating search app.
- **context**: Filter by context (often a path for File/Folder results). Supports `Wildcard` patterns like `*.exe`.

## Outputs

The selected result object is typically mapped to a variable like `searchResult`.

Common properties used by community Tasks:

- `result.Context` (file path / folder path / context string)
- `result.ApplicationInfo?.LinkPath` (when present)

## Practical tips

- Use **context wildcards** (`*.exe`, `*.bat`, `*.cmd`) to keep operations visible only where they make sense.
- Prefer `Exact` on **type** and `Wildcard` on **context** for a good signal-to-noise ratio.

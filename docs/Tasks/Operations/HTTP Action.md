# HTTP Action

**Type:** `HTTP Action`

Performs an HTTP request (commonly `GET`) and returns the response.

## Common settings

- **method**: `Get`, etc.
- **uRI**: URL (often templated).
- **headers**: key/value headers (API keys, etc.).

## Tips

- Prefer APIs that don’t require secrets.
- If you must use an API key, store it in Task project settings and reference it as a variable.
- Validate/parsing via a [Condition](Condition.md) or [C# Script](C%23%20Script.md) before showing the result.

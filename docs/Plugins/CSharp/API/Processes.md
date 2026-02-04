# Processes

Plugins frequently launch URLs or apps.

**Typical namespaces:** `Blast.API.Core.Processes`, `Blast.API.Processes`

Common pattern:

- `IProcessManager manager = ProcessUtils.GetManagerInstance();`
- `manager.StartNewProcess("https://...");`

## Example: open a URL

```csharp
using Blast.API.Core.Processes;
using Blast.API.Processes;

IProcessManager manager = ProcessUtils.GetManagerInstance();
manager.StartNewProcess("https://fluentsearch.net/");
```

## Tips

- Validate/sanitize user input before building URLs.
- Keep operations fast; start the process and return.

If you build URLs from search text, prefer `Uri.EscapeDataString(...)` for query parameters.

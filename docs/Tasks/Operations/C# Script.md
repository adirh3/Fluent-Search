# C# Script

**Type:** `C# Script` | **Category:** Scripting | **Icon:** 🔧

Runs a C# 10.0 code snippet within the Task flow. Variables from previous operations are directly accessible by name. The script's return value becomes the operation output.

---

## Settings

| Setting | Type | Default | Description |
|---|---|---|---|
| **Enable Variable Inline** | bool | false | Allow `{variableName}` syntax to inline variable values into the code before compilation |
| **Content** | string (C# editor) | `return "my script result";` | The C# script code |

---

## Outputs

| Output Type | Description |
|---|---|
| Object | Whatever the script returns |

### Default variable mappings

| Variable Name | Expression | Description |
|---|---|---|
| `csharpScriptResult` | `result` | The script's return value |

---

## Variable access

All current Task variables are available as local variables in the script:

```csharp
// If previous operations defined searchText and httpResponseContent:
var query = searchText;
var response = httpResponseContent;
return response.Contains(query) ? "found" : "not found";
```

When **Enable Variable Inline** is on, `{variableName}` in the code is replaced with the variable's value before compilation — useful for building strings but can break code if values contain special characters.

---

## Tips

- Scripts are **compiled once at save time** and cached for performance.
- Use C# scripts for fast text transformations, regex parsing, and data extraction.
- For external effects (file I/O, network), prefer dedicated operations (HTTP Action, PS Script, Open).
- Keep scripts small and deterministic — avoid interactive prompts or long-running operations.
- Supports `using` statements for additional namespaces.

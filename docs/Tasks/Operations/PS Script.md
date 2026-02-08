# PS Script

**Type:** `PS Script` | **Category:** Scripting | **Icon:** 💻

Runs a PowerShell script. The last line of standard output becomes the operation result.

---

## Settings

| Setting | Type | Default | Description |
|---|---|---|---|
| **PowerShell Exe** | string | `"powershell.exe"` | Path to PowerShell executable (e.g., `pwsh.exe` for PowerShell 7) |
| **Stop On Error** | bool | true | Stop the Task chain if the script exits with a non-zero code |
| **Run As Admin** | bool | false | Run with elevated privileges (output capture is disabled when running as admin) |
| **Show Window** | bool | false | Show the PowerShell console window |
| **Content** | string (PowerShell editor) | `return "my script result"` | PowerShell script content |

---

## Outputs

| Output Type | Description |
|---|---|
| String | The last line of stdout |

### Default variable mappings

| Variable Name | Expression | Description |
|---|---|---|
| `powershellScriptResult` | `result` | The script output |

---

## Variable injection

All current Task variables are injected as `$variableName = "value"` at the top of the script. The script is then base64-encoded and passed via `-EncodedCommand`.

```powershell
# $searchText is automatically available if defined in a previous operation
Write-Output "You searched for: $searchText"
```

---

## Tips

- Default to **Show Window: false** for a smoother user experience.
- Avoid interactive prompts — Tasks should be non-interactive.
- If a script changes system settings (registry, theme, etc.), keep the trigger strict (Exact match).
- Use `pwsh.exe` for PowerShell 7+ if you need cross-platform compatibility or newer cmdlets.
- When **Run As Admin** is enabled, you cannot capture the script's output.

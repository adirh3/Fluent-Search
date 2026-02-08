# Switch Process

**Type:** `Switch Process` | **Category:** Processes | **Icon:** 🔀

Brings a process/window to the foreground based on matching rules (process name, window title).

---

## Settings

| Setting | Type | Default | Description |
|---|---|---|---|
| **Process Name** | TextMatchSetting | Exact, `""` | Match by process name (e.g., `msedge`, `code`, `chrome`) |
| **Process Title Contains** | TextMatchSetting | Contains, `""` | Match by window title |
| **Go To Previous** | bool | false | If the currently focused process already matches, switch to the previous window of that process |

---

## Outputs

| Output Type | Description |
|---|---|
| Object | A `ProcessInfo` object |

### Output properties

| Property | Type | Description |
|---|---|---|
| `FileName` | string | Executable file path |
| `ProcessName` | string | Process name |
| `ProcessId` | int | Process ID |
| `ProcessTitle` | string | Window title |
| `IsFocused` | bool | Whether the process is focused |

### Default variable mappings

| Variable Name | Expression | Description |
|---|---|---|
| `process` | `result` | The process info object |

---

## Tips

- Add a short [Delay](Delay.md) (50–200ms) after switching so the window has time to become active before sending keystrokes.
- Use **Go To Previous** for toggle-style behavior — press a hotkey to switch to an app, press again to go back.

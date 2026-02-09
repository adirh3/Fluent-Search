# Process switched trigger

**Type:** `Process switched` | **Category:** Trigger | **Icon:** 🔀

The Process switched trigger fires when the user switches between applications — when the active/focused window changes. This enables **context-aware automation** that reacts to which application you're using.

Leave all filters empty to trigger on any process switch.

---

## Settings

| Setting | Type | Default | Description |
|---|---|---|---|
| **New Process** | TextMatchSetting | Contains, `""` | Match by the name of the newly focused process |
| **New Process Title** | TextMatchSetting | Contains, `""` | Match by the window title of the newly focused window |
| **New Match Only Dialogs** | bool | false | Only trigger if the new window is a file dialog |
| **Old Process** | TextMatchSetting | Contains, `""` | Match by the name of the previously focused process |
| **Old Process Title** | TextMatchSetting | Contains, `""` | Match by the window title of the previously focused window |
| **Old Match Only Dialogs** | bool | false | Only trigger if the old window was a file dialog |

All text match settings support `Exact`, `Contains`, `Wildcard`, and `Regex` modes.

---

## Outputs

The trigger outputs a `ProcessSwitchEventArgs` object.

### Default variable mappings

| Variable Name | Expression | Description |
|---|---|---|
| `processSwitchEvent` | `result` | The full process switch event |

---

## Examples

### Auto-hide Fluent Search when switching to a game

- **New Process:** Exact, `game.exe`
- Connect to [Hide search window](../Operations/Hide%20search%20window.md)

### Trigger when switching away from a specific app

- **Old Process:** Contains, `outlook`
- Connect to any operations (e.g., show a notification, run a script)

### Detect file dialogs

- **New Match Only Dialogs:** true
- Connect to operations that interact with the file dialog (e.g., navigate to a specific folder)

---

## Tips

- Use **specific process names** (Exact match) to avoid triggering on unrelated application switches.
- This trigger fires frequently — keep connected operations lightweight.
- Combine with a [Condition](Condition.md) node to add additional filtering logic.
- The dialog detection features (`NewMatchOnlyDialogs`, `OldMatchOnlyDialogs`) are powerful for automating file open/save workflows.

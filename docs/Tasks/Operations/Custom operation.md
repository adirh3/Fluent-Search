# Custom operation

**Type:** `Custom operation` | **Category:** Search | **Icon:** ⚡

Creates an operation button (action) that appears in the Fluent Search results panel. When connected after a [Custom result](Custom%20result.md) or [Result selector](../Triggers/Result%20selector.md), it attaches to that result as an action the user can invoke.

Custom operation is both an **operation** and a **trigger** — when the user clicks/invokes it, its child operations execute.

---

## Settings

| Setting | Type | Default | Description |
|---|---|---|---|
| **Name** | string | `"My search operation"` | Operation label displayed in the UI |
| **Icon** | PreviewImageProviderSetting | `\uE113` | Operation icon (glyph or image) |
| **Key Gesture** | Key combination | none | Keyboard shortcut to invoke this operation in the search window (e.g., `Ctrl + 1`) |
| **Selected** | bool | false | Whether this is the auto-selected (default) operation |
| **Position** | int (1–50) | 1 | Position in the operations list |

---

## Outputs

| Output Type | Description |
|---|---|
| Object | The created `ISearchOperation` |

### Default variable mappings

| Variable Name | Expression | Description |
|---|---|---|
| `selectedSearchOperation` | `result` | The operation object |

---

## How it works

1. The Custom operation node adds itself to the preceding result as an action button.
2. When the user selects the result and invokes this operation (click or keyboard shortcut), **child nodes connected to this Custom operation execute**.
3. This makes Custom operation a "deferred trigger" — heavy work (HTTP calls, scripts, process switching) only runs when the user actively chooses the action.

---

## Examples

### "Open in VS Code" for file results

1. Result selector (Files) → 2. **Custom operation** (Name: "Open in VS Code", Key: `Ctrl + 5`) → 3. [Open](Open.md) (FileName: `"code"`, Arguments: `"{searchResult.Context}"`)

### Light/Dark theme switch

1. Search trigger (prefix: `wt`) → 2. Custom result (Name: "Change Windows Theme") → 3. **Custom operation** (Name: "Light Theme") → PS Script (switch to light) 
                                                                                        → 4. **Custom operation** (Name: "Dark Theme") → PS Script (switch to dark)

---

## Tips

- Use **separate Custom operations** for variants (Light/Dark, Copy/Paste, etc.) rather than complex conditional logic.
- Set `Selected = true` on the most common action so the user can just press `Enter`.
- Assign **Key Gesture** shortcuts for power-user access.

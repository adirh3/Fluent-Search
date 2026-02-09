# Get context

**Type:** `Get context` | **Category:** Processes | **Icon:** 📍

Gets the context of the currently focused process — typically a **folder path** (for file managers) or a **URL** (for browsers).

---

## Settings

None.

---

## Outputs

| Output Type | Description |
|---|---|
| String | The context string (folder path or URL) |

### Default variable mappings

| Variable Name | Expression | Description |
|---|---|---|
| `context` | `result` | The current context |

---

## Tips

- Useful for building workflows that act on "the current directory" or "the current webpage."
- Combine with a Hotkey trigger for quick actions like "open current folder in terminal."

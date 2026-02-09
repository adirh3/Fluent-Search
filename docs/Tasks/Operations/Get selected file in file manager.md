# Get selected file in file manager

**Type:** `Get selected file in file manager` | **Category:** File | **Icon:** 📄

Gets the path of the currently selected file in the focused File Explorer or third-party file manager window.

---

## Settings

None — this operation reads the file selection from the currently focused file manager window.

---

## Outputs

| Output Type | Description |
|---|---|
| String | The full path of the selected file |

### Default variable mappings

| Variable Name | Expression | Description |
|---|---|---|
| `selectedFile` | `result` | The selected file's path |

---

## Tips

- Combine with a [Hotkey trigger](../Triggers/Hotkey.md) to create shortcuts like "Open selected file in VS Code" from File Explorer.
- Works with the focused file manager window — make sure the correct window is in focus.

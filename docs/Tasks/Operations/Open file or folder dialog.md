# Open file or folder dialog

**Type:** `Open file or folder dialog` | **Category:** File | **Icon:** 📂

Shows a system dialog that lets the user select a file or folder. The selected path becomes the operation output.

---

## Settings

| Setting | Type | Default | Description |
|---|---|---|---|
| **Mode** | `File` / `Folder` | File | Whether to select a file or a folder |
| **Filter File Extensions** | string | `""` | Comma-separated file extensions to filter (e.g., `txt,json,xml`). Only applies in File mode |

---

## Outputs

| Output Type | Description |
|---|---|
| String | The selected file or folder path |

### Default variable mappings

| Variable Name | Expression | Description |
|---|---|---|
| `selectedFileResult` | `result` | The selected path |

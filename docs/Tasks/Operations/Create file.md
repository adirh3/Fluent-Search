# Create file

**Type:** `Create file` | **Category:** File | **Icon:** 📝

Creates a text file with specified content at a given path.

---

## Settings

| Setting | Type | Default | Description |
|---|---|---|---|
| **File Path** | string | `""` | Output file path. Supports variable substitution |
| **Overwrite** | bool | true | Whether to overwrite the file if it already exists |
| **Content** | string (text editor) | — | File text content. Supports variable substitution |

---

## Outputs

| Output Type | Description |
|---|---|
| Bool | Whether the file was created successfully |

### Default variable mappings

| Variable Name | Expression | Description |
|---|---|---|
| `fileCreated` | `result` | Success flag |

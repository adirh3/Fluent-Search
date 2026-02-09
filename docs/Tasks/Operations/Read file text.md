# Read file text

**Type:** `Read file text` | **Category:** File | **Icon:** 📄

Reads all text content from a file into a variable.

---

## Settings

| Setting | Type | Default | Description |
|---|---|---|---|
| **File Path** | string | `""` | Path to the file to read. Supports variable substitution |

---

## Outputs

| Output Type | Description |
|---|---|
| String | The entire file contents as text |

### Default variable mappings

| Variable Name | Expression | Description |
|---|---|---|
| `fileContent` | `result` | The file text |

# Copy text

**Type:** `Copy text` | **Category:** Misc | **Icon:** 📋

Copies a templated string to the clipboard.

---

## Settings

| Setting | Type | Default | Description |
|---|---|---|---|
| **Text** | string | `""` | Text to copy. Supports variable substitution |

---

## Outputs

| Output Type | Description |
|---|---|
| String | The copied text |

### Default variable mappings

| Variable Name | Expression | Description |
|---|---|---|
| `copiedText` | `result` | The text that was copied |

---

## Tips

- Place this right after you compute a value (HTTP Action / C# Script) so it's obvious what's being copied.
- Combine with a [Custom operation](Custom%20operation.md) named "Copy" to let users copy computed values on demand.

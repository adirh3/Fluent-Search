# Type text

**Type:** `Type text` | **Category:** Inputs | **Icon:** 📝

Types literal text into the active window. Internally, this works by saving the current clipboard, setting the text, pressing `Ctrl+V`, then restoring the original clipboard.

---

## Settings

| Setting | Type | Default | Description |
|---|---|---|---|
| **Text** | string | — | Text to type. Supports variable substitution (e.g., `{searchText}`) |

---

## Outputs

None.

---

## Tips

- Prefer templated values like `{searchText}` so the same Task works for multiple inputs.
- Use [Hide search window](Hide%20search%20window.md) before typing so input goes to the target app.
- There are brief delays (~50ms) between clipboard operations to ensure reliability.

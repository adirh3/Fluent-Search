# Show and search

**Type:** `Show and search` | **Category:** Search | **Icon:** 🔍

Shows the Fluent Search window and immediately runs a search with predefined text and/or search tags.

---

## Settings

| Setting | Type | Default | Description |
|---|---|---|---|
| **Search Text** | string | `""` | Search text to apply. Supports variable substitution |
| **Search Tags** | SearchTagsSelectorSetting | — | Tags to apply (comma-separated valid tag names) |

---

## Outputs

None.

---

## Tips

- This is a clean way to implement shortcuts like a hotkey that opens Fluent Search pre-filtered with a specific tag.
- Combine with a Hotkey trigger: Hotkey → Show and search (with `Files` tag and a specific folder path).

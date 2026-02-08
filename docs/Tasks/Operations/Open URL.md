# Open URL

**Type:** `Open URL` | **Category:** Web | **Icon:** 🔗

Opens a URL in the default browser.

---

## Settings

| Setting | Type | Default | Description |
|---|---|---|---|
| **URL** | string | `"https://fluentsearch.net"` | URL to open. Supports variable substitution |

---

## Outputs

None.

---

## Tips

- Encode or sanitize user input if building URLs from free-text: `https://example.com/search?q={searchText}` — special characters in `searchText` could break the URL.
- For more control over the request (headers, POST body), use [HTTP Action](HTTP%20Action.md) instead.

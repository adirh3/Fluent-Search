# Get web image

**Type:** `Get web image` | **Category:** Web | **Icon:** 🖼️

Downloads an image from a URL. If the preceding node in the chain is a search result (Custom result), the image is automatically set as that result's preview image.

---

## Settings

| Setting | Type | Default | Description |
|---|---|---|---|
| **URL** | string | `""` | Full URL to the image. Supports variable substitution |

---

## Outputs

| Output Type | Description |
|---|---|
| Object | A `BitmapImageResult` |

### Default variable mappings

| Variable Name | Expression | Description |
|---|---|---|
| `imageResult` | `result` | The downloaded image |

---

## Tips

- Place this immediately after a [Custom result](Custom%20result.md) to auto-attach the image as its preview icon/thumbnail.
- Use variables to build dynamic image URLs: `https://api.example.com/image/{itemId}.png`

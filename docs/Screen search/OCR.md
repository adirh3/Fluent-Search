## Screen Search with OCR

Fluent Search's Screen Search feature can use **Optical Character Recognition (OCR)** to detect and interact with text displayed on your screen — even text that isn't normally selectable, such as text inside images, videos, screenshots, or applications that don't expose their content through accessibility APIs.

---

### What is OCR in Screen Search?

OCR analyzes the visual content of your screen and recognizes readable text from the pixels. This means Fluent Search can:

- Find and interact with text in images, PDFs rendered as images, or screenshots
- Detect text in applications that don't use standard Windows UI controls
- Search for on-screen text across any application, regardless of how the text is rendered

OCR complements the standard Screen Search engines (Image Recognition and UI Automation) by adding text-based search capabilities.

---

### Enabling OCR

1. Open Fluent Search settings: **Settings → Screen → OCR**
2. Enable **Search using OCR**
3. Set your **default OCR language**

OCR uses the **Windows built-in OCR engine**, which supports multiple languages based on what's installed on your system.

---

### Using OCR with Screen Search

Once enabled, OCR is integrated into Screen Search automatically:

1. **Activate Screen Search** (default: `Ctrl + M`)
2. **Type text** that appears on your screen — OCR matches are included in the results alongside standard UI element detection
3. **Select a match** to click at that text's location on screen

You can also use OCR with the `Screen` search tag:
- Type `Screen` + `Tab` → type the text you want to find on screen

---

### OCR language settings

| Setting | Description | Default |
|---|---|---|
| **Default OCR language** | The primary language for text recognition | First available system language |
| **Add OCR language tags** | Creates search tags for each installed OCR language, allowing language-specific searching | Off |

#### Multi-language OCR

If you work with text in multiple languages, enable **Add OCR language tags**. This creates a search tag for each installed language (for example, `en-US`, `fr-FR`, `ja-JP`), letting you specify which language to use for a particular search:

- `ocr en-US` + `Tab` → search using English OCR
- `ocr fr-FR` + `Tab` → search using French OCR

---

### Installing additional OCR languages

OCR language support depends on what's installed in Windows:

1. Open **Windows Settings → Time & Language → Language & Region**
2. Add the language you need
3. Ensure the language's **OCR** feature is installed (under language options)

Once installed, the language becomes available in Fluent Search's OCR settings.

---

### Tips

- OCR works best with clearly rendered, reasonably sized text. Very small text, heavily stylized fonts, or low-contrast text may not be recognized reliably.
- Combine OCR with the standard Screen Search engines (Image Recognition + UI Automation) for the most complete detection — Auto mode does this automatically.
- OCR is especially useful in scenarios like: remote desktop sessions (where UI Automation may not work), custom-drawn application UIs, PDF viewers, and image annotations.
- For more information on Screen Search, see [Screen Search](Screen%20Search.md) and [Advanced usage](Advanced%20usage.md).

## Preview Feature in Fluent Search

Fluent Search includes a powerful **Preview** system that lets you inspect results without opening external applications. View documents, images, web pages, code files, audio, folder contents, and more — right inside the Fluent Search interface.

---

### How to use Preview

#### Opening Preview inline

<img alt="Fluent Search Window" src="/docs/images/PreviewMarkdownLight.webp" width="600" height="auto">

- Press **`Alt + P`** (default) to toggle the preview panel inside the Fluent Search window
- Or click the preview icon in the top-right corner

#### Opening Preview in a separate window

- Press **`Shift + Enter`** to open the current result's preview in its own floating window
- This is useful when you want to keep the preview visible while you continue searching

#### Automatic Preview

You can configure rules to automatically show previews for certain result types:
1. Go to **Settings → Preview → Interactions**
2. Add rules for which result types should automatically trigger preview (for example, always preview images or Markdown files)

Additional preview interaction settings:

| Setting | Description | Default |
|---|---|---|
| **Keep preview open** | Keep the preview window open even when Fluent Search loses focus | Off |
| **Open preview with Fluent Search** | Automatically open the preview panel when the search window opens | Off |
| **Open at screen center** | Position the preview window at the center of the screen | Off |
| **Download offline files** | Download cloud-only files (for example, OneDrive placeholders) for local preview | Off |
| **Preview in File Explorer** | Press Space to preview the selected file in File Explorer, similar to macOS Quick Look | Off |

---

### Preview Modules

<img alt="Fluent Search Window" src="/docs/images/PreviewModulesLight.webp" width="700" height="auto">

Fluent Search includes several built-in preview modules. Each can be individually enabled or disabled, and configured to auto-preview matching results.

#### Native Preview
Uses Windows' built-in preview handlers — the same technology as File Explorer's preview pane. Best for:
- Microsoft Office documents (Word, Excel, PowerPoint)
- PDF files
- Visio diagrams
- Other file types with registered Windows preview handlers

#### Web Preview
Loads web pages in a built-in Microsoft Edge WebView. Fully interactive — you can scroll, click links, and browse the page as you would in a real browser.

Configuration options:
- **Show mobile websites** — Request mobile-optimized versions of web pages (default: On)
- **Improve performance** — Use more memory for smoother web rendering
- **Open links in browser** — Clicked links open in your default browser instead of the preview
- **Zoom level** — Adjust the default zoom factor (range: 0.15× to 3×)
- **Browser extensions** — Load unpacked browser extensions into the preview for enhanced functionality (for example, ad blockers)

#### Images
Displays image files with zoom and interaction support. Supports common formats including PNG, JPG, JFIF, SVG, GIF, and more.

#### Audio
Play audio files directly within Fluent Search. Includes controls for play, pause, and seek. Optionally auto-plays audio files when previewed.

#### Text Files
Previews text-based files with **syntax highlighting** powered by TextMate grammars. Supports code files, Markdown, JSON, XML, and more.

Configuration options:
- **Theme** — Choose a syntax highlighting color theme (default: "Plus")
- **Font** — Select a preview font (default: JetBrains Mono)
- **Font size** — Adjust text size (range: 6–30, default: 12)
- **Word wrap** — Toggle line wrapping (default: On)
- **Line numbers** — Show line numbers in the margin (default: Off)

#### File Manager (Folder Explorer)
Previews folders in an explorer-style interface with two view modes:
- **Icons view** — Grid of file/folder icons
- **Details view** — Detailed list with sizes and dates

You can interact with folder contents directly from the preview.

#### Folder Details
Shows metadata and information about folders.

---

### Preview providers

Fluent Search supports two preview providers:

- **Fluent Search** (default) — Uses the built-in preview modules described above
- **QuickLook** — Integration with the [QuickLook](https://github.com/QL-Win/QuickLook) application, if installed. QuickLook provides its own preview UI and supports additional file types

To switch providers: **Settings → Preview → Modules**.

---

### Configuring Preview

1. Go to **Settings → Preview → Modules**
2. Enable or disable individual preview modules
3. Configure **auto-preview** settings for each module to control which results automatically show a preview
4. Adjust module-specific settings (font, theme, zoom, etc.)

---

By using Preview effectively, you can verify results at a glance, reduce unnecessary application switching, and keep your workflow moving without interruption.

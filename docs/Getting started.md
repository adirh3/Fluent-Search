## Getting Started with Fluent Search

<img alt="Fluent Search Window" src="/docs/images/SearchLight.webp" width="600" height="auto">

Fluent Search is a powerful search and productivity tool for Windows that helps you navigate your computer without breaking your flow. Launch apps, find files, search browser history and bookmarks, run commands, search the web, switch between windows, interact with on-screen elements, perform quick calculations, and much more — all from a single, fast keyboard-driven interface.

This guide covers the quickest way to become productive with Fluent Search, plus the core concepts that make it feel intuitive and predictable.

---

## Quick start (2 minutes)

1. Open Fluent Search with the default hotkey: **`Ctrl + Alt`**.
2. Start typing. Results update instantly as you type.
3. Use **`↑ / ↓`** to move between results.
4. Press **`Enter`** to open or activate the selected result.
5. Press **`Esc`** to close Fluent Search.

**Tip:** If you want to narrow your search (for example, "only files" or "only browser history"), use a **Search Tag** — type its name and press **`Tab`**.

For installation instructions (Stable, Nightly, Installer/APPX/Portable): see [Installation](Installation.md).

---

## Core concepts

### Search Apps

Fluent Search is powered by multiple **Search Apps**. Each one specializes in a type of content and contributes results to your searches:

| Search App | What it does |
|---|---|
| **Apps** | Find and launch installed applications |
| **Files** | Search files and folders using fast indexing |
| **Browser** | Search browser history, bookmarks, and saved search engines |
| **Commands** | Run commands via your preferred command-line interface |
| **Web** | Search the web with configurable search engines |
| **Windows** | Find open windows, switch between them, and optionally search inside app content (tabs, buttons, links) |
| **Settings** | Quickly open Windows system settings or Fluent Search settings |
| **Calculator** | Perform quick math, unit conversions, and hex/binary calculations |
| **Screen Search** | Navigate your screen with keyboard-only interaction (Vimium-style overlays) |
| **Shortcuts** | Search keyboard shortcuts for the current app or the OS |
| **To Do** | Search and manage Microsoft To Do tasks |

You can enable, disable, and configure each Search App in **Settings → Apps**. Setting a Search App to **Search Tag Only** means it will only contribute results when you explicitly use its tag — a great way to keep everyday results focused.

### Search Tags

Search Tags are filters you add to your query to narrow results to a specific type or scope. Common examples:

- `Files` — search only files and folders
- `Browser` / `History` / `Bookmark` — search browser data
- `Run` — open a path or run a command (like the Windows Run dialog)
- `.pdf`, `.docx`, `.png` — filter by file extension
- A folder path like `C:\Projects` — search inside a specific folder
- `Google`, `Bing`, `Translate` — perform a web search with a specific engine
- `todo` — search your Microsoft To Do tasks

**To insert a tag:**

1. Type the tag name (for example, `Files`)
2. Press **`Tab`** — the tag locks in and your typing now filters within that scope

You can combine multiple tags to refine further (for example, a folder path + a file extension).

To jump focus to the Search Tags area, press **`Alt + T`** (default).

### Preview

Preview lets you inspect a result without fully opening it — view documents, images, web pages, audio files, folder contents, and more right inside Fluent Search.

- Toggle inline preview: **`Alt + P`** (default)
- Open preview in a separate window: **`Shift + Enter`**

### Quick Menu

The Quick Menu provides fast access to pinned search tags and recent results through a compact popup — useful when you want to jump to frequent actions without typing.

### AI Features

Fluent Search includes optional, fully-local AI capabilities:

- **AI Search** — Semantic, meaning-based search across all your results using the `AI` tag.
- **AI Summarization** — Get quick summaries of files and web pages directly in results.
- All AI processing happens on your device. You can disable all AI features with a single toggle in Settings.

---

## Everyday workflows

### Launch an app

1. Open Fluent Search (**`Ctrl + Alt`**)
2. Type the app name (for example, `Visual Studio`)
3. Press **`Enter`**

**Tip:** You can also run as administrator with **`Ctrl + Shift + Enter`**, or open the app's folder with **`Ctrl + 2`**.

### Find a file

1. Open Fluent Search (**`Ctrl + Alt`**)
2. Type `Files` and press **`Tab`**
3. Type part of the file name
4. Press **`Enter`** to open, or **`Ctrl + 2`** to open the parent folder

**Power tip:** Fuzzy search is enabled by default — typing `mcd` can find "My Cool Document". You can also type file extensions like `.pdf` as a tag to filter by type.

### Search inside a specific folder

1. Type or paste a folder path (for example, `C:\Projects`)
2. Press **`Tab`**
3. Type your search terms

You can combine folder tags with file extension tags for precise results.

### Search browser history and bookmarks

1. Open Fluent Search (**`Ctrl + Alt`**)
2. Type `History` or `Bookmark` and press **`Tab`**
3. Type your search terms
4. Press **`Enter`** to open the page in your default browser

Fluent Search automatically detects Chromium-based browsers (Edge, Chrome, Brave, Vivaldi, Opera) and Firefox profiles.

### Run a command

1. Type `Run` and press **`Tab`**
2. Type a command (`cmd`, `powershell`, `notepad`) or any executable path
3. Press **`Enter`**

You can also use the `Powershell` or `Cmd` tags to run commands directly in those shells.

### Search the web

1. Open Fluent Search
2. Type `Google` (or any configured search engine) and press **`Tab`**
3. Type your search query
4. Press **`Enter`** — it opens in your default browser

You can set up custom search engines for internal wikis, documentation sites, or issue trackers.

### Switch to an open window

1. Open Fluent Search (**`Ctrl + Alt`**)
2. Type part of the window title or app name
3. Press **`Enter`** to switch to it

Enable **Search in app content** in the Windows Search App to also search browser tabs, buttons, and other UI elements inside open applications.

### Do a quick calculation

1. Open Fluent Search (**`Ctrl + Alt`**)
2. Type a math expression (for example, `15% of 2499` or `0xFF * 2`)
3. The result appears instantly — press **`Enter`** to copy it

### Navigate your screen without a mouse

1. Press your Screen Search hotkey (default: **`Ctrl + M`**)
2. Character labels appear over clickable elements
3. Type the label characters to click the element
4. Use number keys for different click actions: `2` = double click, `3` = select text, `4` = right click

---

## If results are missing

Use this checklist:

- **Check Settings → Apps** and confirm the relevant Search App is enabled (not disabled or set to tag-only when you need it in general search).
- **For file search:** confirm your file indexer is configured in `Settings → Apps → Files → File Indexer`. Choose between Fluent Search's built-in indexer, Windows Search, or Everything by Voidtools.
- **For browser search:** confirm your browser profiles are detected and enabled in `Settings → Apps → Browser → Profiles`.
- **For window/tab search:** enable **Search in app content** in `Settings → Apps → Windows`.
- **Fuzzy search:** if results seem too loose or too strict, toggle fuzzy search in `Settings → Search → Experience`.

---

## Keyboard reference (defaults)

| Action | Shortcut |
|---|---|
| Open Fluent Search | `Ctrl + Alt` |
| In-window search | `Ctrl + Alt + Shift` |
| Screen search | `Ctrl + M` |
| Close / Cancel | `Esc` |
| Navigate results | `↑ / ↓` |
| Open / Activate result | `Enter` |
| Insert search tag | `Tab` |
| Focus search tags area | `Alt + T` |
| Toggle preview | `Alt + P` |
| Open preview window | `Shift + Enter` |
| Pin/unpin result | `Ctrl + Alt + P` |
| Run as administrator | `Ctrl + Shift + Enter` |

All hotkeys are fully configurable in **Settings → Hotkeys**.

---

## Support and community

- **Website:** https://fluentsearch.net/
- **GitHub:** https://github.com/adirh3/Fluent-Search
- **Discord:** https://discord.com/invite/fluentsearch

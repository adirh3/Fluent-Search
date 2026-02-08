## Search Apps in Fluent Search

<img alt="Fluent Search Window" src="/docs/images/SearchAppsSettingsLight.webp" width="700" height="auto">

Fluent Search is powered by **Search Apps** — specialized modules that each focus on a specific type of content. When you type a query, the enabled Search Apps work together to find matching results across applications, files, browser data, web searches, open windows, system settings, and more.

Understanding Search Apps is key to getting the most out of Fluent Search: you can enable the ones you need, disable what you don't, and configure each one to behave exactly the way you want.

---

### Available Search Apps

| Search App | What it does |
|---|---|
| [**Apps**](Apps.md) | Find and launch installed applications, view recent files, uninstall programs |
| [**Files**](Files.md) | Search files and folders using multiple indexing engines |
| [**Browser**](Browser.md) | Search browser history, bookmarks, and saved search engines across Chromium and Firefox |
| [**Commands**](Commands.md) | Run shell commands, system operations, and access command history |
| [**Web**](Web.md) | Search the web with configurable search engines and inline preview |
| [**Windows**](Windows.md) | Find and switch between open windows, with optional in-app content search |
| [**Settings**](Settings.md) | Quickly navigate to Windows system settings or Fluent Search settings |
| [**Calculator**](Calculator.md) | Perform math calculations with hex/binary support |
| [**In-window search**](In-window%20search.md) | Search UI elements inside the currently focused application |
| **Screen Search** | Navigate clickable elements on screen using keyboard overlays (see [Screen Search](../Screen%20search/Screen%20Search.md)) |
| **Shortcuts** | Search keyboard shortcuts for the OS or the currently focused application |
| **To Do** | Search and manage Microsoft To Do tasks |
| **Bing** | Live web search results powered by the Bing API |

---

### Managing Search Apps

#### Enabling or disabling Search Apps

1. Open Fluent Search (**`Ctrl + Alt`**) and type `settings` → press **`Enter`**
2. Go to **Apps**
3. Toggle the **Search with App** switch next to any Search App

When a Search App is **disabled**, it will not contribute any results to your searches.

#### Search Tag Only mode

For Search Apps you use occasionally but don't want cluttering every search, enable **Search Tag Only**. In this mode, the app only produces results when you explicitly use one of its search tags.

**Example:** Set Calculator to "Search Tag Only" so calculations only appear when you type `Calculator` + `Tab`.

#### Configuring individual Search Apps

Click on any Search App in the list to open its dedicated settings page. Each app offers different configuration options — from file indexer selection in the Files app to custom search engine URLs in the Web app.

---

### Search App hotkeys

You can assign a **global hotkey** to open Fluent Search already scoped to a specific Search App. This is a powerful way to create "jump in" shortcuts for your most common tasks.

To set up:

1. Go to **Settings → Hotkeys**
2. Find the Search App you want
3. Assign a key combination

**Example:** Assign `Ctrl + Alt + F` to open Fluent Search directly in Files search mode.

---

### Operation hotkeys

Each Search App defines its own set of **result operations** — actions you can take on a selected result (like Open, Copy, Delete, Run as Admin). Many of these have configurable keyboard shortcuts.

To customize operation hotkeys:

1. Open the Settings page for the Search App
2. Look for the **Operation Hotkeys** section
3. Assign or change key combinations for each action

---

### Recommended setup patterns

#### Keep results focused
- Enable only the Search Apps you use daily (commonly: Apps, Files, Commands, Browser)
- Set less-used apps (Calculator, Settings, Shortcuts) to **Search Tag Only** so they don't add noise to general searches

#### Create "jump in" hotkeys
If you frequently do one specific thing (like file search or browser history search), assign a dedicated global hotkey that opens Fluent Search already scoped to that Search App.

#### Use tags for precision
Learn the search tags for your favorite Search Apps (like `History` for browser history or `.pdf` for PDF files) and use them to quickly narrow results when typing in the general search.

---

For app-specific configuration and detailed guides, see the individual Search App pages linked above.

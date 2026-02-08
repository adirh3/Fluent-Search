# Plugins in Fluent Search

Fluent Search is designed to be extensible through a robust **plugin ecosystem**. Plugins add new Search Apps, preview providers, automation tasks, and other capabilities — tailoring Fluent Search to your specific needs.

---

## Types of plugins

Fluent Search supports two types of plugins:

### 1. C# plugins (Dotnet)

Native plugins written in C#. They integrate directly with Fluent Search's core engine, offering:

- **Custom Search Apps** — new search sources (clipboard history, YouTube, Wikipedia, Firefox, etc.)
- **Custom preview providers** — rich preview panels for results
- **Custom operations** — new actions on results
- **Custom settings pages** — app-specific configuration UI built with AvaloniaUI

C# plugins are compiled DLLs that follow a naming convention (`*Fluent.Plugin.dll`) and are loaded dynamically. See [Authoring C# plugins](Authoring%20C%23%20plugins.md) for a full development guide.

### 2. Task plugins (YAML)

Low-code automation workflows created with the visual Task editor and shared as `.yaml` files. Task plugins can:

- Add new search commands (e.g., `define <word>` for dictionary lookups)
- Chain triggers, HTTP calls, scripts, and UI actions
- Extend existing results with new operations (e.g., "Open in VS Code")

See [Tasks](../Tasks/Overview.md) for full documentation.

---

## Browsing and installing plugins

### From the Plugins window

1. Open Fluent Search
2. Open the **Plugins** window (search for `plugins` or use the system tray menu)
3. Browse available plugins — each shows its name, description, publisher, and type
4. Click **Install** to download and enable a plugin

The plugin list is sourced from the [`plugins-manifest.json`](https://github.com/adirh3/Fluent-Search) file in the official GitHub repository.

### Manual installation

#### C# plugins
1. Download or compile the plugin DLL(s)
2. Copy them to your plugins directory (see [Plugin directories](#plugin-directories) below)
3. Create a `pluginsInfo.json` file in the plugin folder
4. Restart Fluent Search

#### Task plugins
1. Download the `.yaml` file
2. Open the **Tasks** window
3. Drag-and-drop the `.yaml` file into the Tasks window

---

## Plugin directories

| Installation Type | Plugin Directory |
|---|---|
| **Microsoft Store** | `%LOCALAPPDATA%\Packages\21814BlastApps.BlastSearch_pdn8zwjh47aq4\LocalCache\Roaming\Blast\FluentSearchPlugins\{PluginName}\` |
| **Sideload** | `%LOCALAPPDATA%\Packages\FluentSearch.SideLoad_4139t8dvwn2ka\LocalCache\Roaming\Blast\FluentSearchPlugins\{PluginName}\` |
| **EXE installer** | `%APPDATA%\Blast\FluentSearchPlugins\{PluginName}\` |

Each plugin must be in its own subdirectory. C# plugins require a `pluginsInfo.json` file describing the plugin.

---

## Available plugins

### C# plugins

| Plugin | Publisher | Description |
|---|---|---|
| **Clipboard** | Blast Apps | Search through your clipboard history using the `clipboard` tag |
| **Translator** | Blast Apps | Translate text using language tags (e.g., `es`, `fr`, `translator`) |
| **Number Converter** | Blast Apps | Convert numbers to hex/binary using `hex` and `binary` tags |
| **Kill Process** | Blast Apps | Kill processes by name |
| **Firefox** | Blast Apps | Search Firefox bookmarks and history |
| **Wikipedia Preview** | Makesh Vineeth | Display Wikipedia content with rich previews |
| **DuckDuckGo Preview** | Makesh Vineeth | DuckDuckGo instant answers and QR code generation |
| **Units Converter** | Zhichao Hong | Convert quantities between different units |
| **YouTube** | Arkadiusz Ś | Search for YouTube videos |

### Task plugins

| Plugin | Publisher | Description |
|---|---|---|
| **Dictionary** | Blast Apps | Type `define <word>` for instant definitions |
| **Change Windows Theme** | Blast Apps | Type `wt` to switch between light and dark themes |
| **Color Preview** | Blast Apps | Type `#FF5733` to preview a color |
| **Currency Converter** | eikaramba | Type `12 USD in EUR` for live conversion |
| **C# City** | Blast Apps | Run C# expressions inside `{}` |
| **Search Tag Switches** | Blast Apps | Common keywords trigger useful search tags |
| **Search Discord** | Blast Apps | Search in Discord channels via `Ctrl+T` |
| **Everything Random** | gsak3l | Generate random names, emails, passwords, IDs |
| **Open in VS Code** | yobyths | Open files/folders in Visual Studio Code |
| **Open in new WT tab** | rzippo | Open folders in a new Windows Terminal tab |
| **Open Apps Link Path** | Blast Apps | Open the folder containing an app's `.lnk` shortcut |
| **FS Launcher** | ironboy | Quickly launch any Fluent Search window |
| **Open as Admin** | Blast Apps | Run `.exe`/`.cmd`/`.bat` files as administrator |
| **Lorem Ipsum Generator** | mahdidev7 | Generate lorem ipsum placeholder text |

---

## Managing plugins

- **Enable/disable** plugins from the Plugins window or Settings
- **Uninstall** by removing the plugin's folder from the plugins directory
- **Update** by downloading a newer version (check the plugin's URL/repository)
- **Error logs** for C# plugins are written to the plugin's directory if loading fails

---

## Building your own

| Goal | Guide |
|---|---|
| Build a C# Search App plugin | [Authoring C# plugins](Authoring%20C%23%20plugins.md) |
| Build a Task plugin | [Tasks overview](../Tasks/Overview.md) |
| Publish your plugin to the store | [Contributing plugins](Contributing%20plugins.md) |
| C# API reference | [C# plugins API](CSharp/Overview.md) |

---

## Community and support

- **GitHub:** https://github.com/adirh3/Fluent-Search
- **Task projects repository:** https://github.com/adirh3/Fluent-Search-Tasks
- **Discord:** https://discord.gg/W2EuWvD6GD
- **Email:** support@fluentsearch.net

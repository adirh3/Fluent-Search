## Hotkeys in Fluent Search

Fluent Search offers a comprehensive hotkey system that lets you control the app, navigate results, trigger actions on results, and jump into specific Search Apps — all from the keyboard. Setting up a few "muscle memory" shortcuts is often the single biggest productivity boost you can get from Fluent Search.

---

### Types of hotkeys

Fluent Search provides two categories of keyboard shortcuts:

1. **Global Hotkeys** — Work from anywhere in Windows, regardless of which application is in focus. These are registered system-wide.
2. **Keyboard Gestures** — Work only when the Fluent Search window is active. These control navigation, preview, result actions, and other in-window behaviors.

---

### Default global hotkeys

| Action | Default Shortcut | Description |
|---|---|---|
| **Open Fluent Search** | `Ctrl + Alt` | Opens or closes the main search window |
| **In-window search** | `Ctrl + Alt + Shift` | Searches inside the currently focused application |
| **Screen search** | `Ctrl + M` | Launches screen search across the entire screen |
| **Screen search (focused window)** | *(configurable)* | Launches screen search only on the focused window |
| **Quick Menu** | *(configurable)* | Opens the Quick Menu for pinned tags and recent results |

You can also assign global hotkeys to:

- **Individual Search Apps** — Open Fluent Search pre-scoped to Files, Browser, Web, or any other Search App
- **Specific Search Tags** — Open Fluent Search with a tag already applied
- **App Hotkeys** — Launch or switch to a specific application (for example, assign `Win + G` to Google Chrome)

**Win key combinations** (such as `Win + F`, `Win + G`, `Win + Space`) are supported as hotkey assignments.

---

### Default keyboard gestures (in-window)

<img alt="Fluent Search Window" src="/docs/images/HotkeysSettingsLight.webp" width="700" height="auto">

These shortcuts work when the Fluent Search window is focused:

| Action | Default Shortcut |
|---|---|
| Navigate results | `↑ / ↓` |
| Open / activate result | `Enter` |
| Insert search tag | `Tab` |
| Close window / cancel | `Esc` |
| Focus search tags area | `Alt + T` |
| Toggle inline preview | `Alt + P` |
| Open preview in separate window | `Shift + Enter` |
| Pin / unpin result to home screen | `Ctrl + Alt + P` |
| Run as administrator | `Ctrl + Shift + Enter` |

---

### Result operation hotkeys

Each Search App defines its own set of keyboard shortcuts for acting on results. These work when a result from that app is selected. Here are the most common ones:

#### Files

| Action | Shortcut |
|---|---|
| Open file / folder | `Ctrl + 1` |
| Open parent folder | `Ctrl + 2` |
| Open in command line | `Ctrl + 3` |
| Open with... | `Ctrl + 4` |
| Copy file | `Ctrl + 5` |
| Copy file path | `Ctrl + C` |
| Search in parent folder | `Ctrl + R` |
| Share | `Ctrl + Shift + S` |
| Rename | `F2` |
| Delete (recycle bin) | `Delete` |
| Permanently delete | `Shift + Delete` |

#### Apps

| Action | Shortcut |
|---|---|
| Open app | `Ctrl + 1` |
| Open app as administrator | `Ctrl + Shift + Enter` |
| Open app folder | `Ctrl + 2` |
| Uninstall app | `Ctrl + 3` |

#### Browser

| Action | Shortcut |
|---|---|
| Open webpage | `Ctrl + 1` |
| Copy URL | `Ctrl + C` |
| Search URL | `Ctrl + E` |

#### Windows / Processes

| Action | Shortcut |
|---|---|
| Switch to window | `Ctrl + 1` |
| Open process folder | `Ctrl + 2` |
| Open new instance | `Ctrl + N` |
| Close window | `Delete` |
| Kill process | `Shift + Delete` |

#### Screen Search

| Action | Shortcut |
|---|---|
| Single click | `1` (then type label) |
| Double click | `2` (then type label) |
| Select text | `3` (then type label) |
| Right click | `4` (then type label) |
| Move mouse | `5` (then type label) |

---

### Configuring hotkeys

To view and modify hotkeys:

1. Open Fluent Search.
2. Navigate to **Settings → Hotkeys**.

From there you can:

- **Reassign any global hotkey** — click the shortcut field and press your desired key combination
- **Add Search App hotkeys** — assign a hotkey to open Fluent Search scoped to a specific Search App
- **Add Search Tag hotkeys** — assign a hotkey to open Fluent Search with a specific tag applied
- **Set App Hotkeys** — assign hotkeys to launch or focus specific applications
- **Configure operation hotkeys** — change the keyboard shortcuts for result actions within each Search App

---

### Gaming mode (hotkey suppression)

Fluent Search can suppress its hotkeys to avoid accidental popups during gaming, presentations, or remote desktop sessions:

- **Ignore hotkeys in full-screen applications** — Automatically disables all global hotkeys when a full-screen window is focused
- **Ignore hotkeys for specific processes** — Add process names (for example, `game.exe`, `obs64.exe`, `mstsc.exe`) that should suppress Fluent Search hotkeys

When hotkey suppression is active, Fluent Search completely unregisters the hotkeys (rather than just blocking them), which prevents any input lag. The system tray icon changes to indicate gaming mode is active.

These options are found in **Settings → Hotkeys**. For more details, see [Gaming mode](Gaming%20mode.md).

---

### Tips

- **Pick unique combinations** — avoid shortcuts commonly used by other apps (like `Ctrl + Shift + P` in VS Code). Good choices include `Ctrl + Alt + Space` or `Win + F`.
- **Test across contexts** — after changing a hotkey, try it on the desktop, in a browser, in your IDE, and in full-screen mode to confirm it works everywhere you need it.
- **Create "jump in" hotkeys** — if you search files frequently, assign a dedicated hotkey that opens Fluent Search already scoped to the Files Search App.
- **Use App Hotkeys for quick switching** — assign hotkeys to your most-used applications for instant launch or focus, similar to a dock.
- **If a hotkey stops working** — check whether you're in a borderless-fullscreen app (these can count as full-screen for suppression purposes), and review your gaming mode settings.

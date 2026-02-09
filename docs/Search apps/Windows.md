## Windows Search App

The **Windows** Search App helps you find open windows and running applications so you can switch context quickly. Instead of Alt-Tabbing through everything, type what you're looking for and jump directly to it.

This Search App also offers a powerful **in-app content search** feature that lets you search inside open applications — finding specific browser tabs, buttons, links, and other UI elements without manually clicking through each window.

---

### What it searches

- **Open windows** — All visible windows and their titles
- **Running processes** — Applications currently running on your system
- **In-app content** (optional) — UI elements inside open windows: tabs, buttons, links, list items, text fields, and more

---

### Common use cases

- **Switch to an open window** — Type part of the window title and press `Enter` to switch to it
- **Find a specific browser tab** — With content search enabled, type the tab title to find and switch to it
- **Close a window** — Select it and press `Delete`
- **Kill a hung process** — Press `Shift + Delete` to force-terminate
- **Open a new instance** — Press `Ctrl + N` to launch another instance of the app
- **Navigate window history** — Use configurable hotkeys to go forward/backward through your window usage history

---

### Search Tags

| Tag | Description |
|---|---|
| `Windows` | Search all open windows and processes |
| *(process name tags)* | Each running process creates its own tag (for example, `chrome`, `code`) |
| `Tab` | Search only tab elements inside applications |
| `Button` | Search only buttons |
| `ListItem` | Search only list items |
| `HyperLink` | Search only links |
| `Text` | Search only text elements |
| And more... | `Edit`, `TreeItem`, `ComboBox`, `Toolbar`, `Page` |

The UI element tags (Tab, Button, etc.) are especially useful when content search is enabled and you want to narrow down to a specific type of element.

---

### Result actions

| Action | Shortcut | Description |
|---|---|---|
| **Switch to Window** | `Ctrl + 1` | Brings the window to the foreground and focuses it |
| **Open Process Folder** | `Ctrl + 2` | Opens the folder containing the application's executable |
| **Open New Instance** | `Ctrl + N` | Launches a new instance of the application |
| **Close Window** | `Delete` | Closes the window gracefully (like Alt+F4) |
| **Kill Process** | `Shift + Delete` | Force-terminates the process (unsaved data may be lost) |

When content search is enabled and you expand a window result, you'll see **child results** for UI elements inside that window (tabs, buttons, etc.). Selecting a child result invokes/clicks that element.

---

### Search in app content

This is one of the most powerful features in Fluent Search. When enabled, it searches inside open applications using Windows UI Automation to detect interactive elements.

**What it finds:**
- Browser tabs (including the specific page title)
- Buttons and clickable elements
- Links and hyperlinks
- List items, tree items, and menus
- Text fields and edit controls
- And more

**To enable:**
1. Go to **Settings → Apps → Windows**
2. Enable **Search in window content**
3. (Optional) Configure which element types to include or exclude in **Content search type**

**How it works:** Fluent Search uses Windows UI Automation to inspect the UI tree of open applications. When you select a content result, it invokes (clicks) that UI element — so selecting a browser tab switches to it, selecting a button clicks it, and so on.

---

### Window history

Fluent Search tracks which windows you've used recently, creating a timeline you can navigate:

- **Go to previous window** — Assign a hotkey to quickly switch back to the last window you used
- **Go to next window** — Navigate forward through your window history
- **Show window history UI** — Display a visual overlay of your recent window usage (enabled by default)

These hotkeys provide a more powerful alternative to Alt+Tab, especially when you're jumping between many applications.

---

### Settings

| Setting | Description | Default |
|---|---|---|
| **Search in window content** | Search UI elements (tabs, buttons, links) inside open windows | Off |
| **Content search type** | Select which types of UI elements to search (Tab, Button, ListItem, etc.) | Most types enabled |
| **Ignored processes** | Processes to exclude from content search | Empty |
| **Show window history UI** | Display the window history overlay interface | On |
| **Go to previous window** | Hotkey for switching to the previous window in history | Unset |
| **Go to next window** | Hotkey for switching to the next window in history | Unset |
| **Prioritize current virtual desktop** | Boost results for windows on the active virtual desktop | Off |

To access: **Settings → Apps → Windows**.

---

### Tips

- **Content search can be slower** than normal window searching because Fluent Search needs to inspect each window's UI tree. For the best experience, disable content search for apps where you don't need it by adding them to the **Ignored processes** list.
- If you don't need window/process results in everyday search, set Windows to **Search Tag Only** and use the `Windows` tag when you explicitly need to switch.
- **Virtual desktop users:** Enable "Prioritize current virtual desktop" to see windows on your active desktop first.
- For a more focused in-window experience, use the dedicated [In-window search](In-window%20search.md) feature (default hotkey: `Ctrl + Alt + Shift`), which searches only inside the currently focused application.

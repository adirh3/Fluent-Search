## In-Window Search

In-window search lets you search inside the **currently focused application** using Fluent Search. Instead of hunting through a complex UI with your mouse, type what you're looking for and Fluent Search will find clickable elements like tabs, buttons, links, and menu items within that app.

---

### How to use it

1. Focus the application you want to search in
2. Press the **In-window search hotkey** (default: **`Ctrl + Alt + Shift`**)
3. Start typing what you're looking for
4. Select a result and press **`Enter`** to interact with that UI element (click a button, switch to a tab, open a link, etc.)

---

### What it finds

In-window search uses **Windows UI Automation** to discover interactive elements within the focused application:

| Element Type | Search Tag | Examples |
|---|---|---|
| **Tabs** | `Tab` | Browser tabs, editor tabs, settings tabs |
| **Buttons** | `Button` | Toolbar buttons, dialog buttons, action buttons |
| **List items** | `ListItem` | Items in lists, file lists, message lists |
| **Hyperlinks** | `HyperLink` | Clickable links in web content or UI |
| **Text fields** | `Edit` | Input fields and text boxes |
| **Text elements** | `Text` | Static text labels |
| **Tree items** | `TreeItem` | Items in tree views (file explorers, outlines) |
| **Combo boxes** | `ComboBox` | Dropdown menus |
| **Toolbars** | `Toolbar` | Toolbar areas |
| **Pages** | `Page` | Page containers |

Each element type has its own search tag, so you can narrow your search. For example, type `Tab` + `Tab` → your query to search only tab elements.

---

### How results work

- **Selecting a result** previews it — for tabs, this switches to the tab; for other elements, it may highlight or focus them
- **Pressing Enter** invokes (clicks) the selected element
- Results are ranked with tabs getting the highest priority, since tab switching is the most common use case

---

### Difference from "Search in app content" (Windows Search App)

| Feature | In-Window Search | Windows Search App (content search) |
|---|---|---|
| **Scope** | Only the currently focused window | All open windows |
| **Activation** | Dedicated hotkey (`Ctrl + Alt + Shift`) | Part of general search with `Windows` tag |
| **Best for** | Quick actions within the current app | Finding elements across all open apps |

---

### Tips

- **Browser tabs** — In-window search is one of the fastest ways to find a specific browser tab when you have dozens open
- **Complex applications** — Use it in apps with many menus, tabs, or panels (like IDEs, email clients, or design tools) to quickly navigate without your mouse
- **Combine with tags** — Use element type tags (like `Button` or `HyperLink`) to narrow results when there are many UI elements
- If in-window results feel incomplete, some applications may not fully support UI Automation. Try using the regular search with the `Windows` tag or Screen Search as alternatives
- You can also use **`Alt + T`** to jump to the search tags area and further narrow results

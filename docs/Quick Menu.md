# Quick Menu

The Quick Menu is a lightweight popup window that gives you fast access to search, recent results, pinned items, and search tags — **without opening the full search window**. It appears near your mouse pointer and is designed for rapid, context-aware interactions.

---

## Opening the Quick Menu

The Quick Menu supports three trigger methods. Configure them in **Settings → Quick menu**.

### Keyboard hotkey

Assign a global hotkey (e.g., `Ctrl+Space`) to toggle the Quick Menu. By default, it opens next to your mouse pointer. Disable **Open next to mouse pointer** to open it at a fixed position instead.

### Mouse trigger

| Option | How to trigger |
|---|---|
| **Left + Right click** | Press both mouse buttons simultaneously |
| **Double middle-click** | Double-click the middle mouse button (within 200ms) |

### Touchpad gesture

| Option | Gesture |
|---|---|
| **Three-finger tap** | Tap the touchpad with three fingers |
| **Four-finger tap** | Tap the touchpad with four fingers |

After selecting a touchpad gesture, click **Configure Windows touchpad tap gesture** to apply the required system settings. This writes to the Windows Precision Touchpad registry and restarts Explorer to take effect.

> **Note:** Touchpad gestures require a Windows Precision Touchpad. After configuration, the gesture sends a hidden hotkey that Fluent Search intercepts.

---

## Quick Menu layout

When the Quick Menu opens with an empty search box, you see the **home screen**:

1. **Recent results** — the most recent results from each enabled Search App (e.g., your last opened apps, files, browser tabs)
2. **Pinned search tags** — tags you've pinned for quick access (e.g., a specific bookmarks folder or file directory)
3. **Pinned results** — individual results you've pinned with `Ctrl+Alt+P`
4. **Suggested results** — contextual suggestions (can be hidden via settings)

As you type in the search box, these sections are replaced by **live search results**, just like the main search window.

---

## Settings

| Setting | Default | Description |
|---|---|---|
| **Hotkey** | *(none)* | Keyboard shortcut to toggle the Quick Menu |
| **Open next to mouse pointer** | On | With keyboard hotkey, opens the menu at your mouse position |
| **Mouse trigger** | Disabled | Mouse button combination to open the menu |
| **Touchpad gesture** | Disabled | Touchpad tap gesture to open the menu |
| **Search in all results** | On | Search all resources. When off, searches only in the focused app's context |
| **Hide suggestions** | Off | Hide the suggested results section on the home screen |
| **Pinned search tags** | *(none)* | Pin specific search tags to the Quick Menu home screen for one-tap access |
| **Recent results** | All enabled | Choose which Search Apps show their recent results |

---

## Keyboard shortcuts

| Key | Action |
|---|---|
| **Escape** | Close the Quick Menu |
| **Alt+Enter** | Open Fluent Search settings |
| **Up/Down arrows** | Navigate results |
| **Apps key** | Open context menu for the selected result |
| Start typing | Auto-focuses the search box |

---

## Tips

- **Pin your most-used search tags** (e.g., `bookmark`, `files`) for instant filtered access.
- **Use "Search in all results: Off"** to search only within the context of your current application — the Quick Menu watermark shows "Search in {current app name}".
- The Quick Menu **auto-hides** when you click outside it or switch to another window.
- Recent results come from Search Apps that support recent search (Apps, Files, Browser, etc.). You can disable individual apps from the settings.

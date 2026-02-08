# Process History

Process History gives you **back/forward navigation between windows** — like browser history, but for your desktop. Navigate through your last 10 focused windows using configurable hotkeys.

---

## Setup

Go to **Settings → Search apps → Windows** and look for the **Window history** section.

| Setting | Default | Description |
|---|---|---|
| **Go to previous process** | *(none)* | Hotkey to switch to the previous window in history |
| **Go to next process** | *(none)* | Hotkey to switch to the next window in history |
| **Show process history UI** | On | Display a visual overlay showing the window history |

---

## How it works

Fluent Search tracks the last **10 windowed processes** you've focused. When you press the previous/next hotkey:

1. The history index moves backward or forward.
2. The target window is brought to the foreground.
3. If **Show process history UI** is on, a horizontal strip of process icons appears briefly at the top-center of your screen, with the current window highlighted.

The overlay auto-hides after **1 second** of inactivity.

### Navigation behavior

- Navigation **wraps around** — pressing "previous" past the oldest entry loops to the newest.
- **Exited processes** are automatically removed from the history and skipped.
- Shell processes (like `ShellExperienceHost`) and non-graphical processes are excluded.
- The history respects the order in which you focused windows, not when they were launched.

---

## Tips

- **Assign intuitive hotkeys** like `Alt+[` / `Alt+]` or `Ctrl+Alt+Left` / `Ctrl+Alt+Right` for natural back/forward navigation.
- This is a lightweight alternative to Alt+Tab for users who want directional, ordered window switching.
- Combine with the **Prioritize windows on current virtual desktop** setting (also in Windows search app settings) to keep virtual desktop windows separate.

# Context Manager

The Context Manager lets you **copy and paste context between applications** using global hotkeys — without opening Fluent Search's search window.

"Context" means the most relevant piece of information from a window:

| Application type | Context |
|---|---|
| **File manager** (Explorer) | The selected file path or current directory |
| **Browser** (Chrome, Edge, Firefox) | The URL from the address bar |
| **Other apps** | A detected URL, file path, or the window title |

---

## Setup

Go to **Settings → Context** (this is an advanced setting page — enable **Show advanced settings** if you don't see it).

Assign hotkeys for:

| Action | Suggested hotkeys | Description |
|---|---|---|
| **Copy context** | `Ctrl+Shift+C`, `Ctrl+Alt+C` | Copy the focused window's context to the clipboard |
| **Paste context** | `Ctrl+Shift+V`, `Ctrl+Alt+V` | Paste the last copied context into the focused window |

---

## How it works

### Copy context

Press the **Copy context** hotkey:

- If Fluent Search itself is focused → copies the selected search result's Context property
- If another app is focused → detects and copies the window's context (URL, file path, etc.)

The context is saved to both an internal variable and the system clipboard.

### Paste context

Press the **Paste context** hotkey:

- If the target is a **file manager** → navigates to the directory
- If the target has an **address bar** (browser, file dialog) → sets the URL or path
- Uses Windows UI Automation to find and fill the appropriate input field

---

## Automatic context transfer

Two automation options are available:

| Setting | Default | Description |
|---|---|---|
| **Automatically copy context of Explorer** | On | When you switch away from Explorer, its current directory is remembered as the last context |
| **Copy context to file dialogs** | Off | When switching from Explorer to a file Open/Save dialog, the dialog automatically navigates to Explorer's current directory |

### Example: Auto-navigate file dialogs

1. Enable **Copy context to file dialogs**.
2. Browse to a folder in File Explorer.
3. In another app, click **File → Open** (or Save).
4. The file dialog automatically opens in the same folder you were browsing in Explorer.

This eliminates the common frustration of file dialogs opening in the wrong directory.

---

## Tips

- Context detection uses heuristics — it looks for strings starting with `C:\`, `http`, `www.`, or containing `.co`, `.net`.
- The **Paste context** hotkey is especially useful for navigating file dialogs to a specific folder without hunting through the folder tree.
- Combine with [Process switched](Tasks/Triggers/Process%20switched.md) Task triggers for more advanced context-aware automation.

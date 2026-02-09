## Advanced Usage of Screen Search

Fluent Search's Screen Search feature offers advanced controls for different click actions, label positioning, engine switching, and multi-monitor navigation — all from the keyboard.

---

### Click actions

Before typing a label's characters, press a number key to change the type of click that will be performed:

| Key | Action | Description |
|---|---|---|
| *(none)* | **Single Click** | Standard left click (default action) |
| `2` | **Double Click** | Double-click on the element |
| `3` | **Text Selection** | Select/highlight text at the element's location |
| `4` | **Right Click** | Right-click on the element (opens context menu) |
| `5` | **Move Mouse** | Move the cursor to the element without clicking |

**How to use:** Press the action number first, then type the label characters. For example:
- `2` → `A` `S` = double-click the element labeled "AS"
- `4` → `D` = right-click the element labeled "D"
- `5` → `J` `K` = move the mouse cursor to the element labeled "JK"

These action keys are configurable in Screen Search settings.

---

### Navigating and adjusting labels

While Screen Search is active, you can fine-tune label positions:

- **Arrow keys** (`↑`, `↓`, `←`, `→`) — Adjust the position of labels to better align with undetected or misaligned elements

This is useful when a label doesn't perfectly align with the element you want to interact with.

---

### Switching between search engines

While Screen Search is active, you can switch detection engines on the fly:

- **Press `Tab`** — Toggles between **Image Recognition** and **In-Window Content** modes

This is helpful when one engine doesn't detect certain elements. For example:
- Switch to **Image Recognition** for apps with custom-drawn UIs
- Switch to **In-Window Content** for standard Windows applications with better UI Automation support

---

### Multi-monitor navigation

For users with multiple monitors, Screen Search provides seamless cross-screen navigation:

| Key | Action |
|---|---|
| **Right Shift** | Move Screen Search focus to the monitor on the right |
| **Left Shift** | Move Screen Search focus to the monitor on the left |

When you shift to another monitor, Screen Search reanalyzes that screen and displays new labels. This lets you interact with elements on any connected display without touching the mouse.

---

### Taskbar detection

When searching the entire screen (not just the focused window), Screen Search separately detects elements in the Windows taskbar. This means you can click taskbar icons, system tray items, and notification area elements using keyboard labels.

---

### Background processing

When **Process in background** is enabled, Fluent Search continuously analyzes your screen so that labels appear almost instantly when you activate Screen Search. This uses more system resources but provides a significantly faster experience.

---

### Tips

- **Start with single click** (the default) to get comfortable with label navigation, then use number keys for advanced actions as needed
- **Use Tab** to try the other detection engine if elements aren't being found
- **Multi-monitor switching** happens instantly — just press Shift to jump between screens
- If you accidentally activate Screen Search, press **`Esc`** to cancel
- Screen Search works with the Fluent Search search bar — you can type text to filter the visible labels by content on screen

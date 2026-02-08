## Screen Search in Fluent Search

<img alt="Fluent Search Window" src="/docs/images/ScreenSearchLight.webp" width="700" height="auto">

**Screen Search** is one of Fluent Search's most unique features. It lets you navigate and interact with anything visible on your screen using only the keyboard — similar to the Vimium browser extension, but working across your entire computer.

When you activate Screen Search, character labels appear over all clickable and interactive elements on your screen. Type the label characters to click, double-click, right-click, or interact with that element — no mouse needed.

---

### Activating Screen Search

| Action | Default Shortcut |
|---|---|
| **Screen Search (entire screen)** | `Ctrl + M` |
| **Screen Search (focused window only)** | *(configurable in Settings → Screen)* |

Upon activation, Fluent Search analyzes the screen and overlays character labels on every detected interactive element.

---

### Basic usage

1. **Press the Screen Search hotkey** (default: `Ctrl + M`)
2. **Character labels appear** over clickable elements on your screen
3. **Type the label characters** to perform an action on that element
4. The action is performed and Screen Search closes

By default, typing a label performs a **single click**. You can change the click type by pressing a number key first (see [Advanced usage](Advanced%20usage.md)).

---

### Screen Search engines

Fluent Search uses two complementary detection engines to identify interactive elements on screen:

#### Image Recognition
- Captures a screenshot and analyzes it to detect interactive components (buttons, links, icons, etc.)
- Works with any application, including those that don't expose accessibility data
- Best for visual elements, custom-drawn UIs, and non-standard controls

#### In-Window Content (UI Automation)
- Uses Windows' built-in UI Automation framework to identify clickable elements
- More accurate for standard Windows applications
- Can detect tabs, buttons, list items, hyperlinks, and more

#### Auto mode (default)
Fluent Search intelligently selects the most appropriate engine based on the context. You can override this and force a specific engine if needed.

---

### Configuration

1. Open Fluent Search (**`Ctrl + Alt`**) → type `settings` → press **`Enter`**
2. Navigate to **Screen → Screen Search**

Available settings:

| Setting | Description | Default |
|---|---|---|
| **Screen search engine** | Choose between Auto, Image Recognition, or In-Window Content | Auto |
| **Search using OCR** | Enable Optical Character Recognition for text detection | Off |
| **Process in background** | Continuously analyze the screen for faster activation | Off |

For detailed configuration of label appearance, see [Customization](Customization.md).

For OCR text recognition, see [OCR](OCR.md).

---

### Tips

- Screen Search works across **all your monitors** — use Shift keys to switch between screens (see [Advanced usage](Advanced%20usage.md))
- Combine Screen Search with the `Screen` search tag in regular search to find on-screen text
- If some elements aren't detected, try switching engines with `Tab` while Screen Search is active
- For background processing mode, Screen Search pre-analyzes your screen so labels appear faster when activated

For click types, multi-monitor navigation, engine switching, and label positioning, see [Advanced usage](Advanced%20usage.md).

For a visual guide, visit the [official Fluent Search website](https://fluentsearch.net/).

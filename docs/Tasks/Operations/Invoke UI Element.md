# Invoke UI Element

**Type:** `Invoke UI Element` | **Category:** Processes | **Icon:** 🖱️

Finds and interacts with a UI element (button, tab, link, text field, etc.) inside a running application using Windows UI Automation. This extends Switch Process with the ability to find and invoke specific controls.

---

## Settings

Includes all [Switch Process](Switch%20Process.md) settings, plus:

| Setting | Type | Default | Description |
|---|---|---|---|
| **Process Name** | TextMatchSetting | — | Process name to target |
| **Process Title Contains** | TextMatchSetting | — | Window title filter |
| **Go To Previous** | bool | false | Switch to previous behavior |
| **Text Contains** | TextMatchSetting | — | Text content of the UI element to find |
| **Element Type** | `Any` / `Button` / `Text` / `ListItem` / `HyperLink` / `TreeItem` / `ComboBox` / `Edit` / `Toolbar` / `List` / `Tab` | Any | Type of control to search for |
| **Operation** | `None` / `Focus` / `Invoke` | Invoke | What to do with the found element |

---

## Outputs

| Output Type | Description |
|---|---|
| Object | A `UiElement` object |

### Output properties

| Property | Type | Description |
|---|---|---|
| `ElementName` | string | The element's name/label |
| `ElementAdditionalText` | string | Additional text content |
| `IsInvokable` | bool | Whether the element can be invoked |
| `ParentProcess` | ProcessInfo | The owning process |
| `HasKeyboardFocus` | bool | Whether the element has focus |

### Default variable mappings

| Variable Name | Expression | Description |
|---|---|---|
| `uiElement` | `result` | The found UI element |

---

## Examples

### Click a button in an application

- Process Name: Exact, `notepad`
- Element Type: Button
- Text Contains: Contains, `Save`
- Operation: Invoke

### Switch to a browser tab

- Process Name: Contains, `chrome`
- Element Type: Tab
- Text Contains: Contains, `GitHub`
- Operation: Invoke

---

## Tips

- Not all applications fully support UI Automation. Test with simpler targets first.
- Use specific **Element Type** filters to narrow down results and improve reliability.
- For applications that don't support UI Automation, consider using [Press keys combo](Press%20keys%20combo.md) as an alternative.

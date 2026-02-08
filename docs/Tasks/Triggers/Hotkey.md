# Hotkey trigger

**Type:** `Hotkey` | **Category:** Trigger | **Icon:** ⌨️

The Hotkey trigger starts a Task chain when a configured global keyboard shortcut is pressed — regardless of which application is focused.

---

## Settings

| Setting | Type | Default | Description |
|---|---|---|---|
| **Hotkey** | Key combination | none | The keyboard shortcut (e.g., `Ctrl + Shift + V`, `Win + Alt + T`) |
| **Bind From Variable** | bool | false | Bind the hotkey from a project variable instead of a fixed value |
| **Variable Name** | string | `""` | The variable name containing a Hotkey value (used with project settings to let users customize the shortcut) |

---

## Outputs

The Hotkey trigger produces **no output** (OperationResultType.None).

---

## Dynamic hotkeys via project settings

One powerful pattern is letting the user customize the hotkey through Task project settings:

1. Add a project setting with `SettingType = Hotkey` and a `VariableName` (e.g., `myHotkey`)
2. On the Hotkey trigger, enable **Bind From Variable** and set **Variable Name** to `myHotkey`
3. The hotkey is now user-configurable from Settings, without editing the Task project

---

## Examples

### Quick clipboard paste

- **Hotkey:** `Ctrl + Shift + V`
- Connect to [Get clipboard text](../Operations/Get%20clipboard%20text.md) → [C# Script](../Operations/C%23%20Script.md) (transform) → [Type text](../Operations/Type%20text.md)

### Open a specific application

- **Hotkey:** `Win + Alt + T`
- Connect to [Open](../Operations/Open.md) with `FileName = "wt.exe"` (Windows Terminal)

---

## Tips

- **Avoid conflicts** with OS shortcuts (like `Win + E`, `Ctrl + C`) and Fluent Search's own global hotkeys.
- If a hotkey doesn't fire, verify that Fluent Search has the required permissions for global hotkeys, and that gaming mode isn't suppressing hotkeys.
- Test with a simpler key combination first if you suspect conflicts.
- Use **Bind From Variable** with project settings to ship Tasks with user-customizable shortcuts — this is much more polished than hardcoded hotkeys.

# Press keys combo

**Type:** `Press keys combo` | **Category:** Inputs | **Icon:** ⌨️

Sends a keyboard shortcut (key combination) to the active window. Used for automating UI interactions that require hotkeys.

---

## Settings

| Setting | Type | Default | Description |
|---|---|---|---|
| **Hotkey** | Key combination picker | none | The key combination to press (e.g., `Ctrl + T`, `Enter`, `Alt + F4`) |

---

## Outputs

None.

---

## Tips

- Position this operation close to where you switch focus — long chains between focus switch and keystroke operations increase the chance of focus changing unexpectedly.
- Add a short [Delay](Delay.md) before sending keys if you just switched processes.
- Use [Hide search window](Hide%20search%20window.md) before sending keys so they go to the target app, not Fluent Search.

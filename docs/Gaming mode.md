## Gaming mode (full-screen / process-aware hotkey suppression)

“Gaming mode” in Fluent Search is a practical set of behaviors that helps prevent Fluent Search from popping up or stealing focus while you’re in a full-screen experience (games, presentations, remote desktop, video players) or when specific apps are running.

It’s primarily implemented through **Hotkeys settings** that tell Fluent Search to *ignore global hotkeys* under certain conditions.

---

### Why use it?

- Avoid accidental hotkey triggers while gaming or presenting.
- Reduce interruptions caused by focus changes.
- Keep Fluent Search installed/enabled without affecting full-screen workflows.

---

### How to enable

1. Open Fluent Search.
2. Go to `Settings` > `Hotkeys`.
3. Enable one (or both) of these options:
   - **Ignoring Hotkeys in Full-Screen Applications**
   - **Ignoring Hotkeys for Specific Processes**

If you use the per-process option, add the process names (for example, `game.exe`, `obs64.exe`, `mstsc.exe`) that should suppress Fluent Search hotkeys.

---

### What exactly is suppressed?

When gaming mode conditions apply, Fluent Search will **not respond to global hotkeys** that would normally open the Fluent Search window or trigger hotkey-bound actions.

This means:

- The main search hotkey will be ignored.
- Any hotkeys you assigned to Search Apps / tags may also be ignored (because they are global hotkeys too).

Non-hotkey entry points (for example clicking the tray icon or launching Fluent Search normally) are not affected by these settings.

---

### Background process notes (what “BackgroundProcess” means here)

Fluent Search supports system-wide hotkeys, which implies there is always some **background component** able to listen for those hotkeys.

Gaming mode does not need to “stop” Fluent Search entirely; instead it changes how Fluent Search behaves when a hotkey event happens:

- When a full-screen app is detected, or the focused/running process matches your ignore list, Fluent Search simply **doesn’t act** on the hotkey.

This approach avoids disruptive popups while keeping Fluent Search available outside those scenarios.

---

### Tips and troubleshooting

- **Hotkeys stop working “randomly”**: check whether you’re in a borderless-fullscreen app (some games and video players count as full-screen).
- **Only one app should suppress hotkeys**: use **Ignoring Hotkeys for Specific Processes** rather than full-screen suppression.
- **You want Fluent Search hotkeys in a specific full-screen app**: disable full-screen suppression and use the per-process list to suppress only what you need.

If you’re debugging a “hotkey not firing” report, always ask for:

- Whether full-screen hotkey suppression is enabled.
- The process name of the foreground app.
- Whether per-process suppression is configured.

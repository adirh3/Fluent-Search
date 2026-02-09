## Gaming Mode (Full-Screen / Process-Aware Hotkey Suppression)

Gaming mode in Fluent Search prevents the app from popping up or stealing focus while you're in a full-screen experience — games, presentations, remote desktop sessions, video players, or any situation where accidental hotkey triggers would be disruptive.

---

### Why use it?

- **Avoid accidental popups** while gaming, presenting, or using full-screen apps
- **Prevent focus stealing** during remote desktop or video sessions
- **Eliminate input interference** — Fluent Search completely unregisters its hotkeys when gaming mode conditions are met, so there is zero impact on input latency
- **Keep Fluent Search installed** without it interfering with your full-screen workflows

---

### How to enable

1. Open Fluent Search
2. Go to **Settings → Hotkeys**
3. Enable one or both of these options:

| Option | Description |
|---|---|
| **Ignore hotkeys in full-screen applications** | Suppresses all Fluent Search hotkeys when any full-screen window is detected (excludes Windows Explorer) |
| **Ignore hotkeys for specific processes** | Suppresses hotkeys when the focused application matches a process name on your list |

For the per-process option, add process names (for example, `game.exe`, `obs64.exe`, `mstsc.exe`) to the ignore list.

**Quick toggle:** You can also search for "Gaming mode" in Fluent Search and toggle it on or off from the results.

---

### What exactly is suppressed?

When gaming mode conditions apply, Fluent Search **completely unregisters its global hotkeys** from the operating system. This means:

- The main search hotkey will not respond
- Search App hotkeys, app hotkeys, and tag hotkeys are all unregistered
- Screen search and in-window search hotkeys are unregistered
- **No input lag** — since the hotkeys are unregistered (not just blocked), there is no overhead on keyboard input

**What is NOT affected:**
- Clicking the system tray icon still works
- Launching Fluent Search from shortcuts or other apps still works
- Fluent Search continues running in the background — only the hotkey listener is suspended

---

### System tray indicator

When gaming mode is active (either partially or fully), the Fluent Search system tray icon changes to a gaming mode icon. This gives you a quick visual indicator that hotkeys are currently suppressed.

### Background process modes

Fluent Search supports three background process modes:

| Mode | Description |
|---|---|
| **Full** | All hotkeys active (normal operation) |
| **Partial** | Hotkeys suppressed for ignored processes only |
| **Disabled** | All hotkeys suppressed (full gaming mode) |

---

### Tips and troubleshooting

- **Hotkeys stop working unexpectedly:** Check whether you're in a borderless-fullscreen app — many games and video players run in borderless fullscreen, which counts as full-screen for suppression purposes.
- **Only one app should suppress hotkeys:** Use **Ignore hotkeys for specific processes** instead of the blanket full-screen suppression. This gives you more precise control.
- **You want hotkeys in a specific full-screen app:** Disable full-screen suppression and use the per-process list to suppress only the processes you need.
- **Remote Desktop:** `mstsc.exe` (Remote Desktop Client) is in the default ignore list because hotkeys typically interfere with remote sessions.

**Debugging checklist** when hotkeys aren't firing:
1. Is full-screen hotkey suppression enabled?
2. What is the process name of the foreground app?
3. Is that process in the per-process ignore list?
4. Check the system tray icon — is it showing the gaming mode indicator?

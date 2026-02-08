# Accessibility

Fluent Search includes a comprehensive accessibility system with **screen reader support**, **text-to-speech**, **SFX audio cues**, and **high contrast mode** — enabling full use of the application without relying on visual output.

---

## Enabling accessibility features

Go to **Settings → Accessibility**, or launch Fluent Search with the `-speechMode` command-line argument to enable speech mode immediately on startup.

---

## Speech mode

When speech mode is enabled, Fluent Search speaks all UI interactions through your screen reader or the built-in Windows speech engine.

### What gets spoken

| Element | Example |
|---|---|
| **Search results** | "Switch to process App - Visual Studio Code, 3 out of 10" |
| **Selected operation** | "Open, hotkey Enter" |
| **Result type** | "App", "Process", "File" |
| **Additional info** | Information elements, context text |
| **UI controls** | "Toggle Dark mode - on", "Combo box Theme, selected value - Blue, press to expand" |
| **Text boxes** | "Search text box: hello" |
| **Empty results** | "Fluent Search did not find anything" |

### Keyboard controls for speech

| Key | Action |
|---|---|
| **Ctrl** | Stop speech immediately |
| **Ctrl+R** | Repeat the last spoken text |

---

## Supported screen readers

Fluent Search auto-detects your active screen reader and routes speech through it. Detection priority:

| Screen reader | Detection | Notes |
|---|---|---|
| **NVDA** | Auto-detected when running | Supports speech and Braille output |
| **ZDSR** (争渡读屏) | Auto-detected when running | Chinese screen reader |
| **JAWS** | Auto-detected when running | Freedom Scientific JAWS |
| **Windows SAPI** | Fallback | Always available; uses Windows built-in voices |

If **Auto detect** is enabled (default), Fluent Search checks for NVDA first, then ZDSR, then JAWS. If none are running, it falls back to **Windows SAPI** (System.Speech).

Disable **Auto detect** to force Windows SAPI and customize the voice and speech rate.

---

## SFX mode

When **Use SFX** is enabled, Fluent Search plays distinct audio cues for different result types instead of speaking the type name. This provides faster audio feedback for experienced users who recognize the sounds.

---

## High contrast mode

Enable **High contrast mode** in **Settings → Accessibility** to apply a high-contrast theme that improves visibility for users with low vision.

---

## Settings

All speech settings are in **Settings → Accessibility** under the **Speech** group.

| Setting | Default | Description |
|---|---|---|
| **Enable speech mode** | Off | Master toggle for all speech and screen reader features |
| **Auto detect screen reader** | On | Automatically detect NVDA, ZDSR, or JAWS. When off, uses Windows SAPI |
| **Voice** | *(system default)* | Choose a specific Windows SAPI voice (only when not using an external screen reader) |
| **Speech rate** | 1 | Speech speed from -10 (slow) to +10 (fast). Applies to Windows SAPI |
| **Speak selected operation** | On | Announce the selected operation when navigating results |
| **Speak operation description** | On | Speak the operation description (e.g., "Switch to process") |
| **Speak result type** | On | Speak the result type label (e.g., "App", "File") |
| **Use SFX** | Off | Play audio cues instead of speaking result types |
| **Enable high contrast mode** | Off | Apply a high-contrast visual theme |

---

## Command-line accessibility

| Argument | Effect |
|---|---|
| `-speechMode` | Force-enables speech mode on startup, regardless of saved settings |

This is useful for setting up Fluent Search on a new machine where settings haven't been configured yet — launch with `-speechMode` and you can navigate Settings entirely by ear.

---

## Tips

- **Screen reader users:** NVDA and JAWS are fully supported. Leave Auto detect on.
- **SAPI voice selection** is also available as a search operation — you can search for "voice" in Settings to quickly switch voices.
- **Ctrl is your escape key** for speech — press it anytime to stop the current announcement.
- If results navigate faster than speech can keep up, Fluent Search automatically cancels the previous announcement before starting the next one.

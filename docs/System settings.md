## System Settings in Fluent Search

<img alt="Fluent Search Window" src="/docs/images/SystemSettingsLight.webp" width="700" height="auto">

Fluent Search's system settings give you control over how the application starts, performs, syncs, updates, and integrates with your system. These settings are found under **Settings → System**.

---

### Startup

Customize how Fluent Search initializes with your system:

| Setting | Description | Default |
|---|---|---|
| **Launch at Windows Startup** | Start Fluent Search automatically when your computer boots | On |
| **Improved Startup** | Uses Windows Task Scheduler for faster startup. When enabled, Fluent Search may not appear in Task Manager's startup list | Off |
| **Start Minimized** | Start without showing a loading screen or window — Fluent Search runs silently in the background | On |
| **Window Startup Position** | Where the search window appears when opened | Active Screen Center |

Window startup position options:

- **Active Screen Center** — Centers the window on the monitor where your cursor or focused window is
- **Screen Center** — Centers the window on your primary monitor
- **Last Position** — Opens the window at the position where you last used it

Additional options:

- **Show in Taskbar** — Whether Fluent Search appears in the Windows taskbar (default: On)
- **Always On Top** — Keep the Fluent Search window above all other windows (default: On)
- **Reset Window Sizes** — Restore all Fluent Search window dimensions to their defaults

---

### Language

Fluent Search supports over 14 languages, including full right-to-left (RTL) support for Hebrew and Arabic:

English, Hebrew, French, German, Korean, Arabic, Italian, Portuguese, Japanese, Polish, Russian, Bengali, Chinese, Spanish, and more.

To change language: **Settings → System → Language**.

---

### Performance

Optimize Fluent Search's performance based on your hardware:

| Setting | Description | Default |
|---|---|---|
| **Performance Mode** | Allocates more system resources for faster results | Off |
| **Use GPU** | Enables hardware-accelerated rendering. Uses more RAM but improves visual performance. Should be disabled for remote desktop (RDP) sessions | On |
| **Reduce Memory Usage** | Aggressively clears memory when Fluent Search is idle. May slightly impact search speed when resuming | Off |
| **Zero Latency Mode** | Shows results as fast as possible with no delay. Increases CPU usage and may cause instability on lower-end systems | Off |

**Tip:** If you're using Fluent Search over Remote Desktop, disable GPU acceleration to avoid rendering issues.

---

### Accessibility

Fluent Search integrates with screen readers and offers text-to-speech features:

| Setting | Description | Default |
|---|---|---|
| **Enable Speech Mode** | Read search results and operations aloud using text-to-speech | Off |
| **Auto-detect Screen Reader** | Automatically detect and integrate with NVDA or ZDSR screen readers | On |
| **Voice** | Choose which SAPI voice to use for speech | System default |
| **Speech Rate** | Adjust how fast text is spoken (range: -10 to 10) | 1 |
| **Speak Selected Operation** | Announce the currently selected operation | On |
| **Speak Operation Text** | Read operation descriptions aloud | On |
| **Speak Result Type** | Announce each result's type (file, app, etc.) | On |
| **Sound Effects** | Play subtle sound effects for interactions | Off |

---

### Sync

Keep your Fluent Search settings consistent across multiple devices:

- **Settings Sync with OneDrive** — Synchronize your Fluent Search settings, tasks, and installed plugin list using your Microsoft OneDrive account. Changes on one device automatically reflect on others.
- **Import / Export Settings** — Manually back up your settings to a file, or restore them from a backup. Useful for migration or when setting up a new machine without OneDrive.

Sync includes your search configuration, personalization settings, hotkeys, and the names of installed plugins (plugins are re-downloaded on the new device).

---

### Crash Diagnostics

- **Send Crash Diagnostics** — When enabled, Fluent Search automatically sends anonymous crash reports to help improve stability. No personal data, search content, or file information is included. You can disable this at any time in **Settings → System → Performance**.

---

### Updates

Manage how Fluent Search updates on your system:

| Setting | Description |
|---|---|
| **Stable** | Default release channel — thoroughly tested, monthly updates. Recommended for most users |
| **Nightly** | Pre-release channel — daily updates with the latest features and fixes. May contain bugs. Not available for Microsoft Store installs |

- **Auto Update** — When enabled, Fluent Search silently installs updates in the background, keeping the app up-to-date without manual intervention.

**Important:** Downgrading from Nightly back to Stable is not supported via the release feed. To return to Stable, reinstall the Stable build from https://fluentsearch.net.

To configure: **Settings → System → Updates**.

---

By configuring these system settings, you can tailor Fluent Search to match your hardware, workflow, and preferences — from a lightweight background tool to a power-user productivity hub.

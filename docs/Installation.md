## Installation and downloads

This page explains the available Fluent Search builds and package types, and how to install or switch between them.

---

## Choose your build

### Stable (recommended)

Stable builds are the default release channel.

- Download from the official website: https://fluentsearch.net (use the **Download** button)
- Or install from the Microsoft Store: https://www.microsoft.com/en-us/p/fluent-search/9nk1hlwhnp8s

### Nightly (previously called Alpha)

Nightly builds are updated frequently and are more likely to contain bugs. Use Nightly if you want early access to new features and you’re comfortable with occasional regressions.

#### Switch an existing install to Nightly

- Go to `Settings` > `System` > `Updates` > `Release feed` and select **Nightly**.

#### Download Nightly directly (without switching from Stable)

These links are the same as in the repo README:

| Package | x64 | ARM64 |
|---|---|---|
| **Windows Installer** | https://download.fluentsearch.net/fluent-search-daily/x64/Fluent-Search.exe | https://download.fluentsearch.net/fluent-search-daily/arm64/Fluent-Search.exe |
| **Windows APPX** | https://download.fluentsearch.net/fluent-search-daily/x64/FluentSearch.appx | https://download.fluentsearch.net/fluent-search-daily/arm64/FluentSearch.appx |
| **Portable** | https://download.fluentsearch.net/fluent-search-daily/x64/fluent-search-portable.zip | https://download.fluentsearch.net/fluent-search-daily/arm64/fluent-search-portable.zip |

---

## Choose your package type

### Windows Installer (.exe)

Best for most users.

- Installs like a normal Windows app
- Typically offers the smoothest integration and updating experience

### Windows APPX

A packaged install (often used for Store-style installs). Useful if you prefer that deployment model.

### Portable (.zip)

No install; runs from a folder.

- Good for trying Fluent Search quickly
- Settings/data live next to the executable (portable-style)

---

## Updates

### Update settings

Configure updates in **Settings → System → Updates**:

| Setting | Default | Description |
|---|---|---|
| **Release feed** | Stable | Choose **Stable** (monthly) or **Nightly** (daily, may contain bugs) |
| **Auto update** | Off | Download and install updates silently on startup — no dialogs or prompts |
| **Check for updates** | — | Manually check for updates now |

### How updates work

- **Automatic check:** On startup, Fluent Search checks for updates in the background. If an update is available, you'll see an OS notification. Click the notification to open the update dialog.
- **Auto update (silent):** When enabled, updates download and install automatically with no user interaction. The installer runs with the `/VERYSILENT` flag.
- **Manual check:** The "Check for updates" button in Settings forces an immediate check and shows the result.

Updates are verified with **Ed25519 signatures** for security.

### Switching from Nightly to Stable

Downgrading from Nightly back to Stable isn't supported via the release feed toggle. To go back to Stable, reinstall a Stable build from https://fluentsearch.net.

---

## Pinned results

You can **pin** frequently used search results so they always appear at the top of the search window and Quick Menu home screen.

| Action | How |
|---|---|
| **Pin a result** | Select a result and press `Ctrl+Alt+P`, or right-click → **Pin** |
| **Unpin a result** | Press `Ctrl+Alt+P` again on a pinned result, or right-click → **Unpin** |
| **Reorder pinned results** | Drag and drop pinned results to change their order |

Pinned results sync across devices when [Settings Sync](Settings%20Sync.md) is enabled.

---

## Notes

- If you're not sure which to pick: use **Stable + Installer**.
- Both x64 and ARM64 architectures are supported across all package types.

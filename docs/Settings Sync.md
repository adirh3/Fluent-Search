# Settings Sync

Fluent Search can sync your settings, Tasks, and installed plugins list across devices using **Microsoft OneDrive**.

---

## Setup

1. Sign in with your **Microsoft account** (see [Microsoft Account](Microsoft%20Account.md)).
2. Go to **Settings → Sync**.
3. Enable **Sync settings**.

Once enabled, settings are automatically uploaded to OneDrive whenever you make a change.

---

## What gets synced

| Data | Synced |
|---|---|
| All search app settings | Yes |
| Personalization / theme settings | Yes |
| Hotkeys and keyboard shortcuts | Yes |
| Search options and system settings | Yes |
| AI settings | Yes |
| Task projects (YAML files) | Yes |
| Installed plugins list | Yes |
| Pinned results and positions | Yes |
| The sync toggle itself | No (per-device) |

Settings are stored in a `.Fluent_Search_Settings` folder in your OneDrive app directory. Each settings page is saved as a separate JSON file, and Task projects are stored in a `Tasks/` subfolder.

---

## How sync works

### Automatic sync

When sync is enabled:

- **On setting change:** The changed settings file is automatically uploaded to OneDrive.
- **On startup:** Each settings page is checked against OneDrive. If the cloud version is newer (by more than 10 seconds), it's downloaded and applied locally.

### Manual sync

Click **Manually sync settings** → choose:

| Option | Description |
|---|---|
| **Restore** | Download all settings from OneDrive and overwrite local settings |
| **Backup** | Upload all current local settings to OneDrive |

After restoring settings, Fluent Search may prompt you to restart.

---

## Import and export (local)

You can also transfer settings without OneDrive:

| Action | Description |
|---|---|
| **Import settings** | Select one or more `.json` setting files from disk to import |
| **Export settings** | Copy all setting files to a chosen folder |

This is useful for sharing a configuration with someone, or backing up to local storage.

---

## Plugin sync

The installed plugins list syncs across devices. When you restore settings from OneDrive on a new device, Fluent Search will attempt to reinstall the same plugins.

---

## Settings

| Setting | Default | Description |
|---|---|---|
| **Sync settings** | Off | Enable bidirectional sync with Microsoft OneDrive |
| **Manually sync settings** | — | Trigger a manual sync (shows last sync time) |
| **Import settings** | — | Import settings from local JSON files |
| **Export settings** | — | Export all settings to a local folder |

---

## Troubleshooting

- **Sync not working?** Ensure you're signed in to your Microsoft account — check **Settings → System** for account status.
- **Conflict resolution:** The newer version wins (based on file modification timestamps). If you need a specific version, use **Backup** to force-upload, or **Restore** to force-download.
- **Sync errors** are shown below the manual sync button.
- Each OneDrive API call has a **15-second timeout**. Slow connections may cause intermittent sync failures.

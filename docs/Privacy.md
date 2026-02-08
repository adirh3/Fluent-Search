## Fluent Search Privacy

This page explains how Fluent Search handles your data, what stays on your device, and which features may communicate externally.

---

### 1. Local-first design

Fluent Search is designed to run **locally on your device**. Your searches, file indexes, browser data, and most interactions are processed entirely on your machine. Fluent Search does not upload your local files, search queries, or the contents of what you search.

---

### 2. What may communicate externally

Depending on your configuration, Fluent Search may send or receive limited data:

| Feature | What it does | Can be disabled? |
|---|---|---|
| **Crash diagnostics** | Sends anonymous crash reports to help improve stability. No personal data, search content, or file information is included | Yes — disable in Settings → System → Performance |
| **Update checks** | Checks whether a newer version is available | Part of auto-update; can be managed in Settings → System → Updates |
| **Web search suggestions** | Sends your typed query to a search engine provider (Google, Bing, DuckDuckGo, or custom) to retrieve auto-complete suggestions | Yes — disable or change the provider in Settings → Apps → Web |
| **Web search** | When you perform a web search, it opens in your browser (Fluent Search does not proxy the search) | N/A — standard browser behavior |
| **Web preview** | When previewing a web page, the page is loaded in an embedded browser (Microsoft Edge WebView) | Yes — disable web preview module |
| **Microsoft To Do** | If enabled, syncs tasks with your Microsoft account via the Microsoft Graph API | Yes — the To Do Search App is disabled by default |
| **Settings sync (OneDrive)** | If enabled, syncs your Fluent Search settings via your OneDrive account | Yes — opt-in feature |
| **Community themes** | Downloads available themes from the Fluent Search themes server | Only when you browse community themes |
| **Plugins** | Third-party plugins may communicate with external services | Only enable plugins you trust; review their descriptions |
| **AI features** | All AI processing (semantic search, summarization) happens **locally on your device** — no data is sent to external AI services | Can be globally disabled in Settings |

---

### 3. Data storage

Most Fluent Search data is stored **locally on your machine**:

#### Settings storage

| Install Type | Location |
|---|---|
| **Installer version** | `%AppData%\Blast` |
| **Microsoft Store / APPX version** | Containerized AppData folder named `Blast` |
| **Portable version** | `Blast` folder next to the executable |

#### Index storage

| Install Type | Location |
|---|---|
| **Installer version** | `%ProgramData%\Fluent Search` (administrator access only) |
| **Microsoft Store / APPX version** | `%ProgramData%\Fluent Search` (administrator access only) |
| **Portable version** | `Cache` folder next to the executable |

The index stores file metadata for fast search. It does not store file contents (unless you explicitly enable content indexing for specific paths).

---

### 4. Browser data access

The Browser Search App reads your browser's local database files (history, bookmarks, favicons) directly from disk. This data is:
- Read-only — Fluent Search does not modify your browser data
- Local — the data stays on your device
- Private — it is not transmitted anywhere

---

### 5. User control

You have **full control** over what Fluent Search does:

- **Crash diagnostics** — disable sending crash reports anytime
- **Web suggestions** — choose your provider or disable entirely
- **AI features** — disable all AI features with a single toggle
- **Plugins** — only enable plugins you trust
- **To Do integration** — disabled by default; requires explicit login
- **Settings sync** — opt-in only; requires OneDrive account
- **Search Apps** — disable any Search App you don't want
- **Content indexing** — only indexes file contents for paths you explicitly configure

---

### 6. Data retention

Fluent Search does not maintain a remote database of your data. Local caches and indexes exist only as long as you use the app. Uninstalling Fluent Search removes the application; to fully clean up, delete the settings and index folders listed above.

---

If you have questions about a specific feature's privacy behavior, check its settings page — Fluent Search is designed so you can enable only the parts you want.

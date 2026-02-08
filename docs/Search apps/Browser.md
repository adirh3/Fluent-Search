## Browser Search App

<img alt="Fluent Search Window" src="/docs/images/BrowserHistoryLight.webp" width="600" height="auto">

The **Browser** Search App lets you search through your browser bookmarks and browsing history directly from Fluent Search. Locate a page you visited earlier, open a bookmarked internal tool, or jump to a frequently used site — all without touching your browser first.

---

### What it searches

- **Browsing history** — Pages you've visited, searchable by title and URL
- **Bookmarks** — All bookmarks across all detected browser profiles
- **Bookmark folders** — Each bookmark folder becomes a searchable tag
- **Browser search engines** — Custom search engines saved in your browser (like YouTube search or Wikipedia search) are imported as search tags you can use in Fluent Search

---

### Supported browsers

Fluent Search automatically detects installed browsers and their profiles:

| Browser | Supported |
|---|---|
| **Microsoft Edge** | ✓ (including Beta, Dev, and Canary channels) |
| **Google Chrome** | ✓ (including Beta) |
| **Brave** | ✓ |
| **Vivaldi** | ✓ |
| **Opera** | ✓ |
| **Firefox** | ✓ |

Multiple profiles per browser are supported (up to 4 per browser by default).

---

### Search Tags

| Tag | Description |
|---|---|
| `browser` | Search across all browser data (history + bookmarks) |
| `history` | Search browsing history only |
| `bookmark` | Search bookmarks only |
| *(bookmark folder names)* | A tag is created for each bookmark folder (for example, `Work`, `Recipes`) |
| *(browser search engine keywords)* | Tags from search engines saved in your browser (for example, `YouTube`, `Wikipedia`) |

**To use:** Type the tag name → press **`Tab`** → type your query.

**Example:** Type `bookmark` → `Tab` → `project wiki` to search only your bookmarks for "project wiki."

---

### Result actions

| Action | Shortcut | Description |
|---|---|---|
| **Open Webpage** | `Ctrl + 1` | Opens the URL in your default browser |
| **Copy URL** | `Ctrl + C` | Copies the URL to clipboard |
| **Search** | `Ctrl + E` | Redirects the URL into a Fluent Search query |
| **Summarize** | — | AI-powered summary of the page (when AI features are enabled) |

Results include the page title, URL, and the site's favicon (loaded from the browser's favicon cache for fast display).

---

### Profile management

Fluent Search automatically detects browser profiles on your system. You can manage which profiles are included:

1. Go to **Settings → Apps → Browser → Profiles**
2. Toggle individual profiles on or off
3. To add a profile that wasn't auto-detected, click **Add Profile** and provide:
   - **Browser Type** — The browser engine (Chrome, Edge, Brave, Firefox, etc.)
   - **Profile Name** — A label for display
   - **Profile Path** — The filesystem path to the browser profile directory

---

### Settings

| Setting | Description | Default |
|---|---|---|
| **Suggest tags from websites and bookmarks** | Automatically create search tags from your most-visited sites and bookmark folders | On |
| **Browser Apps Paths** | Override or add paths to Chromium/Firefox installations for detection | Auto-detected |

To access: **Settings → Apps → Browser**.

---

### How it works

Fluent Search reads your browser's local database files (history, bookmarks, and favicons) directly from disk. This means:

- **Fast** — No browser extension required; data is read from SQLite databases
- **Private** — All processing happens locally on your device
- **Multi-browser** — Search across all your browsers and profiles in one query

**Note about open tabs:** The Browser Search App searches your history and bookmarks. If you want to search **currently open browser tabs**, enable **Search in app content** in the [Windows Search App](Windows.md).

---

### Tips

- Results can be sorted by **last visit date**, so recent pages appear first
- Use the `history` tag when you remember visiting a page but can't recall its name — just type keywords from the page title or URL
- Bookmark folder tags are a powerful way to organize and access categorized bookmarks — for example, type `Work` + `Tab` to search only your "Work" bookmarks folder
- If your browser stores search engine shortcuts (like `y` for YouTube Search), those become Fluent Search tags too — type the keyword + `Tab` + your search query

## Understanding and Using Search Tags in Fluent Search

<img alt="Fluent Search Search Tags Settings" src="/docs/images/FileTagLight.webp" width="700" height="auto">

Search Tags are one of the most powerful features in Fluent Search. They act as filters that narrow your search to a specific type of content, a specific application, a file type, a folder, or even a web search engine. Mastering search tags is the key to fast, precise results.

---

### What are Search Tags?

When you search without any tags, Fluent Search queries all enabled Search Apps and shows a mixed list of results. Adding a search tag focuses your search on a specific scope — dramatically reducing noise and speeding up results.

**Without tags:** Searching `report` might show apps, files, browser history, web suggestions, and settings.

**With a tag:** Searching `Files` + `Tab` + `report` shows only file results matching "report."

<img alt="Fluent Search PDF Search Tag" src="/docs/images/PdfSearchTagLight.webp" width="600" height="auto">

---

### How to use Search Tags

1. **Type the tag name** (for example, `Files`, `History`, `.pdf`)
2. **Press `Tab`** — the tag locks into the search bar
3. **Type your search query** — results are filtered through the tag

You can add **multiple tags** to combine filters.

**Tip:** Press **`Alt + T`** (default) to jump focus to the Search Tags area and browse available tags.

---

### Common Search Tags

#### Search App tags

Each Search App provides its own tags:

| Tag | Source | What it does |
|---|---|---|
| `Files` | Files Search App | Search all files and folders |
| `File` | Files Search App | Files only (no folders) |
| `Folder` / `Directory` | Files Search App | Folders only (no files) |
| `content` | Files Search App | Search inside file contents |
| `Browser` | Browser Search App | All browser data |
| `History` | Browser Search App | Browser history only |
| `Bookmark` | Browser Search App | Bookmarks only |
| `Windows` | Windows Search App | Open windows and processes |
| `Apps` | Apps Search App | Installed applications |
| `command` | Commands Search App | Command line commands |
| `Run` | Commands Search App | Windows Run dialog emulation |
| `Powershell` | Commands Search App | PowerShell commands |
| `Cmd` | Commands Search App | Command Prompt commands |
| `Calculator` | Calculator Search App | Math expressions |
| `Settings` | Settings Search App | System and app settings |
| `Screen` | Screen Search App | On-screen elements |
| `Shortcut` | Shortcuts Search App | Keyboard shortcuts |
| `todo` | To Do Search App | Microsoft To Do tasks |

#### File extension tags

Type any file extension as a tag to filter by file type:

| Tag | Matches |
|---|---|
| `.pdf` | PDF documents |
| `.docx` | Word documents |
| `.png`, `.jpg`, `.gif`, `.svg` | Image files |
| `.mp4`, `.avi`, `.mkv` | Video files |
| `.mp3`, `.wav`, `.flac` | Audio files |
| Any extension | Any file matching that extension |

#### File type group tags

Pre-configured groups that cover multiple extensions at once:

| Tag | Matches |
|---|---|
| `image` | PNG, JPG, GIF, SVG, and other image formats |
| `video` | MP4, AVI, MKV, and other video formats |
| `audio` | MP3, WAV, FLAC, and other audio formats |
| `document` | PDF, DOCX, TXT, and other document formats |

You can customize these groups in **Settings → Apps → Files → File extension tags**.

#### Special directory tags

Type any of these to quickly search within common system directories:

| Tag | Directory |
|---|---|
| `desktop` | Your Desktop folder |
| `documents` | Your Documents folder |
| `downloads` | Your Downloads folder |
| `pictures` | Your Pictures folder |
| `music` | Your Music folder |
| `videos` | Your Videos folder |
| `recent` | Recently accessed files |
| `onedrive` | Your OneDrive folder |
| `temp folder` | System temp directory |
| `application data` | Roaming AppData |
| `local application data` | Local AppData |
| `program files` | Program Files directory |
| `program data` | ProgramData directory |
| `user profile` | Your user profile root |

#### Folder path tags

<img alt="Fluent Search Search Tags Settings" src="/docs/images/MultipleTagsLight.webp" width="700" height="auto">

Type any **folder path** (for example, `C:\Projects`) and press **`Tab`** — Fluent Search inserts it as a search tag, letting you search inside that specific folder. Combine this with file extension tags for precise results:

**Example:** `C:\Projects` + `Tab` + `.docx` + `Tab` → finds Word documents inside your Projects folder.

#### Web search engine tags

| Tag | What it does |
|---|---|
| `Google` | Search Google |
| `Bing` | Search Bing |
| `Translate` | Google Translate |
| `chatgpt` | Send a prompt to ChatGPT |
| *(custom engines)* | Any search engines you configure |
| *(browser keywords)* | Search engine keywords imported from your browser |

#### Browser bookmark folder tags

Each bookmark folder in your browser automatically becomes a search tag. For example, if you have a "Work" bookmarks folder, typing `Work` + `Tab` searches only within those bookmarks.

#### AI tag

| Tag | What it does |
|---|---|
| `AI` | Performs semantic, meaning-based search across all Fluent Search results using a local AI model |

---

### Combining multiple tags

<img alt="Fluent Search Search Tags Settings" src="/docs/images/MultipleTagsLight.webp" width="700" height="auto">

You can stack multiple tags to create very specific searches:

- **Folder + extension:** `C:\Work` + `.pdf` → PDF files in your Work folder
- **App + folder:** `Apps` + specific app → recent files from that app
- **Browser + bookmark folder:** `Bookmark` + `Work` → bookmarks in the Work folder

---

### Viewing available tags

<img alt="Fluent Search Search Tags Settings" src="/docs/images/SearchTagsSettingsLight.webp" width="800" height="auto">

There are multiple ways to discover what tags are available:

- **Press `Alt + T`** in the search window to open the Search Tags area with intelligent suggestions
- **Settings → Search Tags** shows all available search tags
- Each **Search App settings page** lists the tags it provides
- **Clicking a tag** in settings navigates to its configuration page

---

### Custom and ignored tags

<img alt="Fluent Search Search Tags Settings" src="/docs/images/CustomSearchTagLight.webp" width="800" height="auto">

#### Create custom tags

Define your own search tags as shortcuts for frequently used searches or specific scopes:

1. Go to **Settings → Search Tags**
2. Create a custom tag with your desired name and behavior

#### Ignore tags

If certain tags activate accidentally or are unnecessary for your workflow, you can disable them:

1. Go to **Settings → Search Tags**
2. Disable any tags you don't want to appear

---

### Customizing web search tags

<img alt="Fluent Search Search Tags Settings" src="/docs/images/WebSearchTagsLight.webp" width="800" height="auto">

Web search tags are configured in **Settings → Apps → Web → Web Searches**. You can:

- Add new search engines (use `%s` as the query placeholder)
- Edit or remove existing ones
- Set a default search engine
- Add engines for internal tools (wiki, issue tracker, docs site)

---

By mastering search tags, you can dramatically speed up your searches, reduce noise, and make Fluent Search a precision tool tailored to how you actually work.

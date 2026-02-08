## File Search in Fluent Search

<img alt="Fluent Search Search Tags Settings" src="/docs/images/FileTagLight.webp" width="600" height="auto">

The **Files** Search App provides fast, powerful file and folder search across your computer. Under the hood, it supports multiple indexing engines so you can choose the right balance of speed, disk usage, and compatibility for your setup.

---

### What it searches

- Files and folders across all configured drives and directories
- File names, paths, and optionally file contents
- Special system directories (Desktop, Documents, Downloads, etc.)
- ZIP file contents (browsable and extractable)
- Network drives (when configured)

---

### Indexing engines

Fluent Search supports three file indexing options. Choose the one that fits your needs:

#### Fluent Search Indexer (recommended)

Fluent Search includes its own file indexer service designed for speed and minimal resource usage:

- **20× faster indexing** and **5× faster search** compared to previous versions (File Index V2)
- **10× smaller index** footprint on disk
- Runs as a background Windows service

To set up:
1. Go to **Settings → Apps → Files → File Indexer**
2. Select **Fluent Search**
3. Follow the prompts to install and start the service

*Administrative privileges may be required to install the service.*

#### Windows Search

Integrates with the built-in Windows Search index — the same one used by File Explorer and the Start menu:

1. Go to **Settings → Apps → Files → File Indexer**
2. Select **Windows Search**
3. Configure indexed locations in **Control Panel → Indexing Options**

#### Everything by Voidtools

Integrates with [Everything](https://www.voidtools.com/), a popular third-party search engine known for near-instant file indexing:

1. Install Everything from https://www.voidtools.com/
2. Go to **Settings → Apps → Files → File Indexer**
3. Select **Everything**

*Note: The Everything service must be running. If Everything runs as administrator, Fluent Search must also run as administrator.*

---

### Search Tags

The Files Search App offers an extensive set of search tags to narrow results:

#### General tags
| Tag | Description |
|---|---|
| `Files` | Search all files and folders |
| `File` | Search files only (no folders) |
| `Folder` / `Directory` | Search folders only (no files) |
| `content` | Search inside file contents (in content-indexed paths) |

#### File extension tags
| Tag | Description |
|---|---|
| `.pdf`, `.docx`, `.png`, `.sln`, etc. | Filter by any file extension |
| `image` | Image files (PNG, JPG, GIF, SVG, etc.) |
| `video` | Video files (MP4, AVI, MKV, etc.) |
| `audio` | Audio files (MP3, WAV, FLAC, etc.) |
| `document` | Document files (PDF, DOCX, TXT, etc.) |

You can create your own file extension tag groups in **Settings → Apps → Files → File extension tags**.

#### Special directory tags
| Tag | Description |
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
Type any folder path (for example, `C:\Projects`) and press **`Tab`** to search inside that specific folder. You can combine folder path tags with file extension tags for precise results.

---

### Result actions

| Action | Shortcut | Description |
|---|---|---|
| **Open** | `Ctrl + 1` | Opens the file or folder with the default program |
| **Open Parent Folder** | `Ctrl + 2` | Opens the folder containing the file |
| **Open in Command Line** | `Ctrl + 3` | Opens a terminal at the file's directory |
| **Open With** | `Ctrl + 4` | Opens the "Open With" dialog to choose an application |
| **Copy File** | `Ctrl + 5` | Copies the file to clipboard |
| **Copy File Path** | `Ctrl + C` | Copies the full file path to clipboard |
| **Search in Parent Folder** | `Ctrl + R` | Adds the parent folder as a search tag |
| **Share** | `Ctrl + Shift + S` | Opens the Windows share dialog |
| **Rename** | `F2` | Renames the file or folder inline |
| **Delete** | `Delete` | Moves the file to the Recycle Bin |
| **Permanently Delete** | `Shift + Delete` | Permanently deletes the file |
| **Summarize** | — | AI-powered summary of the file (when AI features are enabled) |

**Drag and drop:** You can drag file results from Fluent Search and drop them into other applications.

**Create files and folders:** If you type a path that doesn't exist, Fluent Search will offer to create the file or folder for you.

**ZIP file browsing:** When a ZIP file result is expanded, you can browse its contents and extract individual files.

---

### Settings

| Setting | Description | Default |
|---|---|---|
| **File indexer** | Choose between Fluent Search, Windows Search, or Everything | Fluent Search |
| **Indexed paths** | Directories included in the file index | All drives |
| **Content indexed paths** | Directories where file content is also indexed | Empty |
| **Ignored paths and files** | Paths excluded from search and indexing | Windows, Windows.old, $Recycle.Bin, AppData, ProgramData |
| **Ignored file extensions** | Extensions excluded from results | Empty |
| **Prioritized file extensions** | Extensions that appear higher in results | Empty |
| **Auto-learn file extension usage** | Automatically prioritize frequently-used file types | On |
| **Auto search file paths** | Match file paths even without a backslash in the query | Off |
| **Max files to process** | Maximum number of matching files to process (0 = unlimited) | 1000 |
| **Default file manager** | Custom file manager for opening directories | Windows Explorer |
| **Open folders in existing window** | Open folders in an existing Explorer/file manager window | On |
| **Show file modification age** | Display relative time ("2 hours ago") instead of timestamps | On |
| **Default preview folder view** | Icons or Details view for folder preview | Icons |
| **Stop indexer on exit** | Stop the Fluent Search indexer service when closing the app | Off |
| **File extension tags** | Configure custom groups of file extensions as search tags | video, audio, document, image |

To access: **Settings → Apps → Files**.

---

### Troubleshooting

#### Indexer service not running
1. Open Windows Services (`services.msc`)
2. Find **FluentSearch.FileIndexer**
3. Ensure the service is running; start it manually if needed

#### Stale or missing results
- Rebuild the index: **Settings → Apps → Files → File Indexer → Rebuild Index**
- Verify that the relevant directory is in your indexed paths and not in your ignored paths

#### Everything integration not working
- Ensure the Everything service is running
- If Everything runs elevated (as admin), Fluent Search must also run as administrator

For further help: [GitHub Issues](https://github.com/adirh3/Fluent-Search/issues) or [Discord](https://discord.com/invite/fluentsearch).

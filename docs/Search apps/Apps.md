## Apps Search App

The **Apps** Search App helps you find and launch applications installed on your computer. It's the "launcher" side of Fluent Search — if you know the name of what you want to open, you can get there in a few keystrokes.

---

### What it searches

- Applications installed from the Microsoft Store
- Desktop applications (including traditional/legacy programs from Control Panel and Add/Remove Programs)
- App shortcuts and `.lnk` files
- Custom application paths you configure

### Common use cases

- **Launch any installed app** — type its name and press `Enter`
- **Run as administrator** — select an app and press `Ctrl + Shift + Enter`
- **Open the app's install folder** — press `Ctrl + 2` on a selected result
- **Uninstall an application** — press `Ctrl + 3` to invoke the uninstaller
- **View recent files** — expand an app result to see files recently opened with that application (pulled from Windows Jump Lists)

---

### Search Tags

The Apps Search App creates a **search tag for each installed application**. This means you can type an app name, press `Tab`, and see results scoped to that app (such as recent files opened with it).

Additionally:

- `Apps` — Focus search on installed applications only
- `Run` — Emulate the Windows Run dialog: open paths, run commands, or launch apps by executable name

**To use:** Type the tag name → press **`Tab`** → type your query.

---

### Result actions

| Action | Shortcut | Description |
|---|---|---|
| **Open App** | `Ctrl + 1` | Launches a new instance of the application |
| **Open App As Admin** | `Ctrl + Shift + Enter` | Launches the application with administrator privileges |
| **Open App Folder** | `Ctrl + 2` | Opens the folder containing the app's executable |
| **Uninstall App** | `Ctrl + 3` | Launches the application's uninstaller |

When you expand an app result (by clicking the expand arrow), you'll see **child results** including:
- Running instances of the app (processes)
- Recently opened files from the Windows taskbar (Jump List items), each of which can be opened directly

---

### Settings

| Setting | Description | Default |
|---|---|---|
| **Search legacy apps** | Include legacy programs and Control Panel applications in results | On |
| **Disable app background caching** | Reduces background resource usage, but newly installed apps won't be recognized until the next restart | Off |
| **Custom Apps Paths** | Add custom directories or `.lnk`/`.exe` files to be included in app search | Empty |

To access: **Settings → Apps → Apps**.

---

### Tips

- If you mostly use Fluent Search as an app launcher, keep **Apps** enabled in general search and consider setting other Search Apps to **Search Tag Only** to reduce noise.
- For apps you launch frequently, consider assigning an **App Hotkey** in Settings → Hotkeys. App Hotkeys let you launch or switch to a specific application with a single key combination — like having a keyboard-based application dock.
- Fluent Search prioritizes commonly-used applications (like Chrome, Edge, VS Code, WhatsApp, Telegram) in its suggestions.

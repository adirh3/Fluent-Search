## Getting Started with Fluent Search

<img alt="Fluent Search Window" src="/docs/images/SearchLight.webp" width="600" height="auto">

Fluent Search is a fast launcher + search tool for Windows that helps you do common “computer navigation” tasks without breaking flow: launch apps, find files, search browser data, run commands, perform web searches, and use your keyboard to act on results.

This guide focuses on the quickest way to become productive, plus the mental model that makes Fluent Search feel predictable.

---

## Quick start (2 minutes)

1. Open Fluent Search with the default hotkey: **`Ctrl + Alt`**.
2. Start typing. Results update as you type.
3. Use **`↑/↓`** to move between results.
4. Press **`Enter`** to open the selected result.
5. Press **`Esc`** to close Fluent Search.

Tip: If you want to focus your search (for example, “only files” or “only browser history”), use a **Search Tag**.

Install options (Stable, Nightly, Installer/APPX/Portable): [Installation.md](Installation.md)

---

## Core concepts

### Search apps

Fluent Search is powered by multiple **Search apps**. Each one specializes in a type of content (Files, Browser, Commands, Web, etc.) and contributes results.

You can enable/disable Search apps and configure them in **Settings → Apps**.

### Search Tags

Search Tags are “filters” you add to the query to narrow results. Typical examples:

- `Files` to search files and folders
- `Browser` / `History` / `Bookmark` to search browser data
- `Run` to run a command or open a path

To insert a tag quickly:

1. Type the tag name
2. Press **`Tab`** to insert it

To jump focus to the Search Tags UI, use **`Alt + T`** (default).

### Preview

Preview lets you inspect a result without fully opening it.

- Toggle preview: **`Alt + P`** (default) or click the preview icon

---

## Everyday workflows

### Launch an app

1. Open Fluent Search (`Ctrl + Alt`)
2. Type the app name
3. Press `Enter`

### Find a file (fast)

1. Open Fluent Search (`Ctrl + Alt`)
2. Type `Files` and press `Tab`
3. Type part of the file name

### Search only inside a folder

1. Paste or type a folder path (for example: `C:\Projects`)
2. Press `Tab`
3. Type what you’re looking for

### Run a command / open a path

1. Type `Run` and press `Tab`
2. Type a command (for example: `cmd`, `powershell`, `notepad`) or a path
3. Press `Enter`

### Search the web

1. Open Fluent Search
2. Type your query
3. Choose a web search option (or use a web Search Tag)

---

## If results are missing

Use this checklist:

- Check **Settings → Apps** and confirm the relevant Search App is enabled.
- If you’re searching files, confirm your file indexer is configured in the Files Search App.
- If you’re searching browser data, confirm supported browser profiles are enabled.

If you want to search inside open windows (for example, browser tabs), see [Search apps/Windows.md](Search%20apps/Windows.md).

---

## Support and community

- Website: https://fluentsearch.net/
- GitHub: https://github.com/adirh3/Fluent-Search
- Discord: https://discord.com/invite/fluentsearch

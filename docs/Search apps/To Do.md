# To Do

Fluent Search integrates with **Microsoft To Do**, letting you search, complete, rename, and create tasks — all from the search bar.

---

## Setup

1. The To Do search app is **disabled by default**. Enable it in **Settings → Search apps → To Do**.
2. Sign in with your **Microsoft account** (see [Microsoft Account](../Microsoft%20Account.md)). You can sign in from the To Do settings page or when prompted during your first search.

---

## Usage

1. Type `todo` and press **Tab** to activate the To Do search tag.
2. Your task lists and tasks appear immediately.
3. Type to filter tasks by name.

Each task list creates its own sub-tag (e.g., `todo Tasks`, `todo Shopping`), so you can filter by list.

---

## Operations

| Operation | Shortcut | Description |
|---|---|---|
| **Complete** | `Ctrl+1` | Mark the task as completed (removes it from the list) |
| **Rename** | `F2` | Open a dialog to edit the task title |
| **Open in Web** | `Ctrl+2` | Open the task in the Microsoft To Do web app |
| **Create** | — | Appears when your search text doesn't match any existing task in a list. Creates a new task with that name |

---

## How results look

- **Task results** show the task title as the result name, grouped by task list name
- **Additional info** shows the list name and last modified date
- **Create task** results appear with a **+** icon when no existing task matches your search text within a given list

---

## Data and sync

- Tasks are fetched from Microsoft Graph using **delta queries** for efficient incremental sync.
- The local cache refreshes at most **once per minute** — changes you make in the To Do app may take up to a minute to appear in Fluent Search.
- A "Loading..." result appears while tasks are being fetched for the first time.
- Completed tasks are automatically filtered out.
- Tasks are stored **in memory only** — they are re-fetched from Microsoft on each Fluent Search launch.

---

## Tips

- **Create tasks instantly** — type `todo` → `Tab` → type your task text → select the "Create" result under the desired list.
- If you see a **"Login to Microsoft Account"** result, click it to sign in.
- The To Do app needs the `Tasks.ReadWrite` permission scope from your Microsoft account.

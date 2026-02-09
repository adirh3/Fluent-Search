# Result selector trigger

**Type:** `Result selector` | **Category:** Trigger | **Icon:** 📋

The Result selector trigger fires when a search result appears that matches your configured filters. This lets you **attach custom operations to existing Fluent Search results** — for example, adding an "Open in VS Code" action to file results, or a "Run as Admin" option to `.exe` files.

---

## Settings

| Setting | Type | Default | Description |
|---|---|---|---|
| **Name** | TextMatchSetting | Contains, `""` | Match the result's display name |
| **Context** | TextMatchSetting | Wildcard, `*` | Match the result's context (file path, URL, or other context string) |
| **Tag** | SearchTagSetting | any | Match a specific active search tag |
| **Search App** | MultiListSelection | "Any" | Match results from a specific Search App (Apps, Files, Browser, etc.) |

---

## Outputs

The Result selector outputs an `ISearchResult` object with these properties:

| Property | Type | Description |
|---|---|---|
| `DisplayName` | string | The result's display name |
| `ResultType` | string | The result type label (e.g., "File", "Folder", "App") |
| `Context` | string | Context information — typically a file path, URL, or folder path |

### Additional properties available on specific result types

| Property | Description |
|---|---|
| `ApplicationInfo?.LinkPath` | For App results, the `.lnk` file path |
| `SearchedText` | The user's original search text |

### Default variable mappings

| Variable Name | Expression | Description |
|---|---|---|
| `searchResult` | `result` | The full search result object |

---

## How it works

Unlike the Search trigger (which fires on user input), the Result selector fires **when results are generated** by any Search App. It operates on a high-performance channel to avoid blocking the UI.

When the trigger fires, connected downstream operations execute — typically adding **Custom operations** (action buttons) to the matched result.

---

## Examples

### Add "Open in VS Code" to file/folder results

- **Name:** Contains, `""` (any name)
- **Context:** Wildcard, `*` (any path)
- **Search App:** Files
- Then connect a [Custom operation](../Operations/Custom%20operation.md) node named "Open in VS Code" → [Open](../Operations/Open.md) with `FileName = "code"`, `Arguments = "{searchResult.Context}"`

### Add "Run as Admin" to `.exe` files only

- **Name:** Contains, `""` (any)
- **Context:** Wildcard, `*.exe`
- **Search App:** Files
- Then connect a Custom operation → Open with `RunAsAdmin = true`, `FileName = "{searchResult.Context}"`

### Add custom operations to browser bookmarks

- **Search App:** Browser
- **Tag:** `Bookmark`
- Then connect your custom operations

---

## Tips

- Use **Context wildcards** (`*.exe`, `*.bat`, `*.cmd`, `*.ps1`) to keep operations visible only where they make sense.
- Prefer `Exact` matching on **type** and `Wildcard` on **context** for good signal-to-noise.
- This trigger fires frequently (once per matching result), so keep downstream operations lightweight — avoid expensive HTTP calls or scripts in the direct chain. Use a [Custom operation](../Operations/Custom%20operation.md) node (which acts as a trigger when the user clicks it) to defer heavy work until the user explicitly invokes the action.

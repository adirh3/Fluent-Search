# Search trigger

**Type:** `Search` | **Category:** Trigger | **Icon:** 🔍

The Search trigger starts a Task chain when the user types something in Fluent Search that matches a configured pattern. This is the most commonly used trigger in Task projects.

---

## Settings

| Setting | Type | Default | Description |
|---|---|---|---|
| **Search Prefix** | string | `""` | A keyword before the search text that acts as a command identifier (e.g., `define`, `wt`, `calc`) |
| **Searched Text** | TextMatchSetting | Contains, `""` | Match pattern for the remaining search text after the prefix. Use `*` to match any value |
| **Text Match Type** | `Exact` / `Contains` / `Wildcard` / `Regex` | Contains | How the text matching is performed |
| **Match Case** | bool | false | Whether matching is case-sensitive |
| **Searched Tag Exact** | string | `""` | Only trigger when this exact search tag is active. If the tag doesn't already exist, Fluent Search auto-creates it |
| **Search Tag Icon** | PreviewImageProviderSetting | `\uEF90` | Icon for the auto-created search tag |
| **Search Type** | `SearchAll` / `SearchProcess` | SearchAll | Which search mode to match (almost always `SearchAll`) |

---

## Outputs

The Search trigger outputs a `SearchRequest` object with these properties:

| Property | Type | Description |
|---|---|---|
| `SearchedText` | string | The searched text (lowercase) |
| `SearchedTag` | string | The active search tag (lowercase) |
| `DisplayedSearchText` | string | The search text as displayed in the search bar (preserves case) |

### Default variable mappings

| Variable Name | Expression | Description |
|---|---|---|
| `searchText` | `result.SearchedText` | The user's search query |
| `searchTag` | `result.SearchedTag` | The active search tag |

---

## TextMatchSetting reference

The text matching system supports four modes:

| Mode | Description | Example |
|---|---|---|
| **Exact** | Must match the entire string | `hello` matches only "hello" |
| **Contains** | Must appear somewhere in the string | `llo` matches "hello" |
| **Wildcard** | Glob-style patterns; `*` matches anything, `;` separates alternatives | `*.exe;*.bat` matches "app.exe" and "run.bat" |
| **Regex** | Full .NET regular expression | `^define\s+\w+$` |

---

## Examples

### Simple prefix trigger

Trigger when user types `define <word>`:
- **Search Prefix:** `define`
- **Searched Text:** Contains, `""` (any text)
- **Variables:** `searchText = result.SearchedText`

### Tag-based trigger

Trigger only when the user activates a custom "Weather" tag:
- **Searched Tag Exact:** `Weather`
- **Searched Text:** Contains, `""`
- **Search Tag Icon:** ☁️ icon

This auto-creates the "Weather" tag in Fluent Search. Users type `Weather` → `Tab` → their query.

### Regex trigger

Trigger on a pattern like `12 USD in EUR`:
- **Searched Text:** Regex, `^\d+\s+\w{3}\s+in\s+\w{3}$`

---

## Tips

- **Keep prefixes strict** — use `Exact` matching on the prefix to avoid accidental triggers during normal searches.
- **Prefer anchored regex** (`^...$`) when using Regex mode to prevent partial matches.
- If you expect arguments after the prefix, match the prefix strictly and keep Searched Text flexible (Contains or Wildcard `*`).
- Search results added by downstream operations (Custom result, Custom operation) automatically appear in the Fluent Search UI.

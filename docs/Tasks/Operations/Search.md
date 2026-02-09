# Search (operation)

**Type:** `Search`

The Search node matches user input in the Fluent Search search box. In most Task projects this is used as a **trigger** (the first node in the chain), but it is technically an operation type in the Task graph.

For full documentation, see the [Search trigger](../Triggers/Search.md) page.

---

## Settings

| Setting | Type | Default | Description |
|---|---|---|---|
| **Search Prefix** | string | `""` | A command prefix keyword |
| **Searched Text** | TextMatchSetting | Contains, `""` | Match pattern for the search text |
| **Text Match Type** | `Exact` / `Contains` / `Wildcard` / `Regex` | Contains | Matching mode |
| **Match Case** | bool | false | Case sensitivity |

---

## Outputs

| Variable | Expression | Description |
|---|---|---|
| `searchText` | `result.SearchedText` | The user's search query |
| `searchTag` | `result.SearchedTag` | The active search tag |

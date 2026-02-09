# For each trigger

**Type:** `For each` | **Category:** Trigger | **Icon:** 🔁

The For each trigger iterates over a collection (array, list, or enumerable) and triggers connected child operations **once per item**. This is essential when an HTTP response or script returns multiple results that each need their own processing.

This trigger is used **mid-flow** (connected after another operation) — it takes the previous operation's result (or a specified variable) and loops over it.

---

## Settings

| Setting | Type | Default | Description |
|---|---|---|---|
| **Input Variable** | string | `""` | The variable name containing the array to iterate. Leave empty to use the last operation's result directly. Can be a C# expression |

---

## Outputs

Each iteration outputs the current item as an object.

### Default variable mappings

| Variable Name | Expression | Description |
|---|---|---|
| `item` | `result` | The current item in the iteration |

---

## Examples

### Display multiple HTTP results

1. Search trigger → HTTP Action (fetches a JSON array of results)
2. Parse JSON → creates `json` variable
3. **For each** with **Input Variable:** `json` (or empty to use last result)
4. Custom result → `Name = "{item["title"]}"`, Context = `"{item["url"]}"`

Each item in the JSON array creates a separate search result in the Fluent Search UI.

### Process each line of a file

1. Hotkey trigger → Read file text → C# Script: `return fileContent.Split('\n');`
2. **For each** (iterates over each line)
3. Custom result showing each line

---

## Tips

- For each supports any `IEnumerable` — arrays, lists, LINQ results, and split strings all work.
- Keep the loop body lightweight for large collections — avoid HTTP calls inside For each loops (fetch all data first, then iterate).
- The iteration respects cancellation — if the user starts a new search, the loop stops.
- Combine with Condition nodes inside the loop body to filter items.

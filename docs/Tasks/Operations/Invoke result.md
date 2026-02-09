# Invoke result

**Type:** `Invoke result` | **Category:** Search | **Icon:** ▶️

Invokes a saved search result (triggering its action), or returns it to the search window for the user to interact with.

---

## Settings

| Setting | Type | Default | Description |
|---|---|---|---|
| **Search Result** | SearchResultId (UI picker) | — | The search result to invoke, selected via the UI |
| **Search Operation** | string (UI picker) | — | Which operation to invoke on the result |
| **Return Result** | bool | false | If true, returns the result to the search window instead of invoking it |

---

## Outputs

| Output Type | Description |
|---|---|
| Object | The invoked `ISearchResult` |

### Default variable mappings

| Variable Name | Expression | Description |
|---|---|---|
| `invokedSearchResult` | `result` | The search result |

---

## Tips

- Use **Return Result** to programmatically populate the search window with specific results.
- Configure the result and operation via the UI picker buttons in the Task editor.

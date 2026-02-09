# Triggers

A **trigger** is what starts a Task operations chain. When its conditions are met, the trigger fires and executes all connected downstream operations.

This page is an index of all available trigger types. Each trigger has its own detailed page:

---

## Available triggers

| Trigger | Category | Description |
|---|---|---|
| [**Search**](Triggers/Search.md) | Trigger | Fires when user input in Fluent Search matches a configured pattern (prefix, text, tag) |
| [**Result selector**](Triggers/Result%20selector.md) | Trigger | Fires when a search result matches filters — lets you attach custom operations to existing results |
| [**Hotkey**](Triggers/Hotkey.md) | Trigger | Fires when a configured global hotkey is pressed |
| [**Process switched**](Triggers/Process%20switched.md) | Trigger | Fires when the user switches between applications (window focus changes) |
| [**Condition**](Triggers/Condition.md) | Trigger | Gates the chain based on a boolean expression — can be used mid-flow |
| [**For each**](Triggers/For%20each.md) | Trigger | Iterates over a collection, triggering child operations once per item |

---

## How triggers work

1. A trigger listens for a specific event (search input, hotkey press, process switch, etc.).
2. When the event occurs and matches the trigger's filters, it fires.
3. The trigger creates a fresh **variables dictionary** with any project settings and trigger outputs.
4. Connected operations execute sequentially, passing variables along the chain.

---

## Trigger outputs

Most triggers produce an **output** that can be mapped into variables:

| Trigger | Output Type | Default Variables |
|---|---|---|
| Search | `SearchRequest` object | `searchText = result.SearchedText`, `searchTag = result.SearchedTag` |
| Result selector | `ISearchResult` object | `searchResult = result` |
| Hotkey | None | — |
| Process switched | `ProcessSwitchEventArgs` object | `processSwitchEvent = result` |
| Condition | None | — |
| For each | Current item object | `item = result` |

---

## Tips

- Community Task projects are a great place to see real trigger setups: https://github.com/adirh3/Fluent-Search-Tasks
- Most Tasks use a **Search** trigger with a prefix — this keeps triggers from firing accidentally.
- **Result selector** is powerful for adding "Open in VS Code" or "Run as Admin" actions to existing results.
- **Process switched** enables context-aware automation — for example, automatically setting a window layout when switching to a specific app.

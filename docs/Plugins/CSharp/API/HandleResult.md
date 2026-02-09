# HandleResult

`HandleResult` (returned as `IHandleResult`) tells Fluent Search what to do after an operation runs.

**Typical namespace:** `Blast.Core.Results`

## Common outcomes

- **Operation succeeded**: return a `HandleResult` that indicates success.
- **Search again**: return a `HandleResult` configured so Fluent Search reruns the query (useful when an operation changes state and results should refresh).
- **Change the query**: some plugins set a new `SearchRequest` (and/or `SearchTag`) so Fluent Search immediately searches a different query.

## Typical fields (version-dependent)

Different Fluent Search versions expose slightly different properties on the returned handle result, but community plugins commonly use:

- `Success` (or constructor argument): did the operation succeed?
- `SearchAgain` (or constructor argument): should Fluent Search rerun the search?
- `SearchRequest`: optionally provide a new `SearchRequest` to run.
- `SearchTag`: optionally provide a new tag.

## Example scenarios

- “Keep result” / “Remove result” actions: update your backing store and request search refresh.
- “Pick a tag” result: in `HandleSearchResult`, return a handle result that sets `SearchRequest` with the chosen tag.

See: [SearchRequest](SearchRequest.md)

## Example: request a search refresh

```csharp
// After mutating stored state, ask Fluent Search to rerun search.
return new ValueTask<IHandleResult>(new HandleResult(success: true, searchAgain: true));
```

## Example: change to a new tag

```csharp
return new ValueTask<IHandleResult>(new HandleResult(true, true)
{
	SearchRequest = new SearchRequest(string.Empty, tagName, SearchType.SearchAll),
	SearchTag = new SearchTag { Name = tagName }
});
```

Treat this pattern as version-sensitive: follow the types your referenced package exposes.

# SearchRequest

`SearchRequest` represents the user’s current search input.

**Typical namespace:** `Blast.Core.Objects`

## Common properties

- `SearchedText`: the free text part of the query.
- `SearchedTag`: the active tag (if any).
- `SearchType`: the search mode (for example `SearchAll` vs process search).

Depending on version, you may also see additional fields (for example the calling app context). Treat this object as the “current query snapshot”.

## Why `SearchType` matters

Many plugins skip work when Fluent Search is performing a process-search pass:

- If `SearchType == SearchType.SearchProcess`, return no results.

This avoids doing network calls or heavy computation when Fluent Search is asking for a different kind of search.

## Example usage

```csharp
public async IAsyncEnumerable<ISearchResult> SearchAsync(SearchRequest request,
	[EnumeratorCancellation] CancellationToken token)
{
	if (token.IsCancellationRequested)
		yield break;

	if (request.SearchType == SearchType.SearchProcess)
		yield break;

	var tag = request.SearchedTag;
	var text = request.SearchedText?.Trim();
	if (string.IsNullOrWhiteSpace(text))
		yield break;

	// Optional: only run when the plugin’s tag is used
	// if (!string.Equals(tag, "mytag", StringComparison.OrdinalIgnoreCase)) yield break;

	// yield return ...
	await Task.CompletedTask;
}
```

## Triggering a follow-up search

In `HandleSearchResult`, a plugin can request Fluent Search to search again by returning a `HandleResult` configured with a new `SearchRequest`.

See: [HandleResult](HandleResult.md)

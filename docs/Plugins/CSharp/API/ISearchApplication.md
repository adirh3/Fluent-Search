# ISearchApplication

`ISearchApplication` is the entrypoint for a C# Search App plugin.

**Typical namespace:** `Blast.Core.Interfaces`

**Typical related types:** `SearchApplicationInfo`, `SearchRequest`, `ISearchResult`, `IHandleResult`

Implementations typically:

1. Describe the app via `SearchApplicationInfo`.
2. Return results from `SearchAsync`.
3. Perform actions in `HandleSearchResult` when the user selects an operation.

## Minimal skeleton

Below is a “shape correct” skeleton that matches how plugins are commonly structured. Names/signatures can vary slightly by version, but the flow is stable.

```csharp
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Blast.Core.Interfaces;
using Blast.Core.Objects;
using Blast.Core.Results;

public sealed class MySearchApp : ISearchApplication
{
	private readonly SearchApplicationInfo _info;

	public MySearchApp()
	{
		_info = new SearchApplicationInfo(
			name: "MyApp",
			description: "Does something useful",
			supportedOperations: new List<ISearchOperation>());
	}

	public SearchApplicationInfo GetApplicationInfo() => _info;

	public ValueTask LoadSearchApplicationAsync() => ValueTask.CompletedTask;

	public async IAsyncEnumerable<ISearchResult> SearchAsync(
		SearchRequest request,
		[EnumeratorCancellation] CancellationToken cancellationToken)
	{
		if (cancellationToken.IsCancellationRequested)
			yield break;

		// Many plugins also early-exit for process-search passes
		// if (request.SearchType == SearchType.SearchProcess) yield break;

		var searchedText = request.SearchedText;
		if (string.IsNullOrWhiteSpace(searchedText))
			yield break;

		// yield return new MySearchResult(...);
		await Task.CompletedTask;
	}

	public ValueTask<IHandleResult> HandleSearchResult(ISearchResult searchResult)
	{
		// Inspect searchResult.SelectedOperation and act
		return new ValueTask<IHandleResult>(new HandleResult(success: true, searchAgain: false));
	}

	// Signature differs by version: some builds use object, some use string.
	public ValueTask<ISearchResult> GetSearchResultForId(object searchObjectId)
	{
		// Rebuild a result for custom tags / pinned results.
		return new ValueTask<ISearchResult>();
	}
}
```

## Key members

### `SearchApplicationInfo GetApplicationInfo()`

Returns static metadata about your app (name, icon, supported operations, default search tags, settings page, etc.).

See: [SearchApplicationInfo](SearchApplicationInfo.md)

### `ValueTask LoadSearchApplicationAsync()`

Runs once on Fluent Search startup.

Use it to:

- Load settings-dependent state after settings are available.
- Warm caches (carefully) or load external metadata.

Tip: Keep this fast. Slow startup impacts the whole app.

:bulb: Developer tip: if you rely on settings values, initialize anything settings-dependent here (some plugins intentionally avoid reading settings in the constructor).

### `IAsyncEnumerable<ISearchResult> SearchAsync(SearchRequest request, CancellationToken token)`

Generates results for the current query.

Common patterns seen in community plugins:

- Ignore process search: return nothing when `request.SearchType == SearchType.SearchProcess`.
- Filter by tag: only handle your tag(s) and return `yield break` for others.
- Stream results as you compute them (good UX) rather than building huge lists.

See: [SearchRequest](SearchRequest.md) and [SearchResultBase](SearchResultBase.md)

#### Cancellation and responsiveness

- Check `token.IsCancellationRequested` early and often.
- Prefer streaming results (`yield return` as soon as you have something) over collecting everything in memory.
- Avoid throwing exceptions for “no results”; just `yield break`.

### `ValueTask<IHandleResult> HandleSearchResult(ISearchResult result)`

Called when the user executes an operation (right-side action panel or operation hotkey).

Typical responsibilities:

- Detect the selected operation (often by type checks on `result.SelectedOperation`).
- Perform the action (copy to clipboard, open URL, start a process, etc.).
- Optionally ask Fluent Search to re-run the search.

See: [HandleResult](HandleResult.md)

#### Operation dispatch

Most plugins dispatch by operation *type*:

```csharp
var op = result.SelectedOperation;
if (op is CopySearchOperation) { ... }
else if (op is MyCustomOperation myOp) { ... }
```

This is more robust than matching strings (operation names can change).

### `ValueTask<ISearchResult> GetSearchResultForId(object searchObjectId)`

Used for “custom tag” / pinned result scenarios where Fluent Search needs to rebuild a result after restart.

Common approach:

- Store a stable `SearchObjectId` on the result (string/id or a serializable object).
- Recreate a fresh `ISearchResult` when this method is called.

See: [SearchResultBase](SearchResultBase.md)

#### Version note

Some community plugins show `GetSearchResultForId(string serializedSearchObjectId)` while others use `object`.
Treat this as version-dependent and follow the interface in your referenced `Blast.API`/Fluent Search version.

## Practical tips

- Prefer **strict early exits** (wrong tag, empty input, cancellation requested) to reduce work.
- Avoid throwing exceptions on normal “no result” flows; just return no results.

## See also

- [SearchApplicationInfo](SearchApplicationInfo.md)
- [SearchRequest](SearchRequest.md)
- [HandleResult](HandleResult.md)

# SearchResultBase

`SearchResultBase` is a convenient base class for results returned by plugins.

**Typical namespace:** `Blast.Core.Results`

**Implements:** `ISearchResult` (via base implementation)

Plugins usually inherit it instead of implementing `ISearchResult` from scratch.

## Constructor patterns

Community plugins typically call a `SearchResultBase` constructor with:

- Search app name
- Displayed/result name
- Searched text
- Result type
- Score
- Supported operations
- Tags

Then they set optional properties (icon glyph, caching, preview builder, etc.).

## What a result contains

Commonly used properties (non-exhaustive):

- Identity / display: `DisplayedName`, `ResultName`, `ResultType`, `Score`
- Search context: `SearchedText`, `Tags`, `Context`
- Actions: `SupportedOperations`, `SelectedOperation`
- UI: `IconGlyph`, `UseIconGlyph`, `PreviewImage`, `InformationElements`
- Persistence: `SearchObjectId` (and sometimes a stable pin id)

## Selection lifecycle

`SearchResultBase` exposes a hook often used for UI updates:

- `OnSelectedSearchResultChanged()` (override)

If you override it, keep it lightweight; selection changes happen on user navigation.

## Custom tag / pin support

If you want Fluent Search to reconstruct results after restart (for example for custom tags), assign a stable `SearchObjectId` and implement `ISearchApplication.GetSearchResultForId(...)`.

### Guidelines

- Prefer a stable string/id as `SearchObjectId` unless you *know* the object will serialize reliably.
- If you use a custom object, keep it simple (no images/streams, no non-serializable fields).

## Result preview UI

Some plugins attach a custom preview builder to results, allowing rich UI in the preview pane.

See: [Result Preview UI](ResultPreviewUI.md)

## Example: attach a preview builder

```csharp
public sealed class MyResult : SearchResultBase
{
	private static readonly IResultPreviewControlBuilder Preview = new MyPreviewBuilder();

	public MyResult(string searchedText) : base(
		resultName: "Hello",
		searchedText: searchedText,
		resultType: "Example",
		score: 1,
		supportedOperations: new List<ISearchOperation>(),
		tags: new List<SearchTag>())
	{
		ResultPreviewControlBuilder = Preview;
		UseIconGlyph = true;
		IconGlyph = "\uE8EF";
	}

	protected override void OnSelectedSearchResultChanged() { }
}
```

## Practical tips

- Prefer `ShouldCacheResult = false` for results that become stale quickly.
- If you want deterministic ordering, consider disabling ML-related ordering knobs when available.

Also consider:

- Avoid storing large payloads in the result object when you can compute on demand.
- Prefer immutable result data where possible (easier debugging, fewer race conditions).

See also: [Result behavior tuning](ResultBehaviorTuning.md)

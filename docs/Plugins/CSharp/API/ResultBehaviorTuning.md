# Result behavior tuning

`SearchResultBase` exposes several knobs that affect caching, ordering, and UI behavior.

This page collects commonly used flags/properties from community plugins.

## Ordering and ML

Some plugins set:

- `DisableMachineLearning = true`

Example (Clipboard plugin): disable ML ordering so results can be ordered purely by recency.

## Caching

Two related concepts you may see:

- `ShouldCacheResult = false` for results that become stale quickly
- Settings-based caching (store internal lists/settings to disk)

## Removing a result after an operation

Some operations remove an item and mark the result for removal:

```csharp
searchResult.RemoveResult = true;
return new HandleResult(true, true); // search again
```

Property names can vary by version, but the pattern is:

- update the backing store
- ask Fluent Search to refresh

## Pinning / stable identity

For “custom tag” and pinned results, plugins commonly set:

- `SearchObjectId` (used by `GetSearchResultForId`)

Some plugins also set:

- `PinUniqueId`

This should be a stable id (string) that identifies the underlying object across sessions.

## InformationElements

Results can show extra structured info lines.
Example (Translator plugin):

```csharp
InformationElements = new List<InformationElement>
{
    new("Latin", latinText)
};
```

Use this when you want to show additional fields without cramming text into the main title.

## Guidance

- Keep ids stable. If you change how you generate ids between versions, pinned/custom-tag results may break.
- If you disable ML ordering, ensure your scoring logic is still reasonable across many results.

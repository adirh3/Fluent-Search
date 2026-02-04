# SearchApplicationInfo

`SearchApplicationInfo` describes your Search App to Fluent Search.

**Typical namespace:** `Blast.Core.Objects`

This object is returned from `ISearchApplication.GetApplicationInfo()`.

## Commonly used fields

Settings vary by version, but community plugins commonly set:

- `MinimumSearchLength`: minimum input length before searching.
- `SearchTagOnly`: whether the app should only run when its tag is used.
- `ApplicationIconGlyph`: icon glyph used in the UI.
- `SearchAllTime`: a hint for how “fast” the app is expected to be.
- `DefaultSearchTags`: a list of `SearchTag` values the app exposes.
- `SettingsPage`: optional settings UI (see [Settings](Settings.md)).
- `PluginName`: friendly plugin name (optional).

Depending on version, there may be additional flags controlling:

- Whether your app runs without a tag
- Performance hints / scheduling
- Process search integration

## Supported operations

Search apps typically declare a list of supported operations and reuse instances rather than constructing new ones for every result.

### Example pattern

```csharp
private readonly List<ISearchOperation> _ops = new()
{
	new CopySearchOperation("Copy"),
	new MyOpenUrlOperation()
};

_info = new SearchApplicationInfo("MyApp", "Description", _ops)
{
	MinimumSearchLength = 1,
	SearchTagOnly = true,
	DefaultSearchTags = new List<SearchTag>
	{
		new() { Name = "mytag", IconGlyph = "\uE8EF" }
	}
};
```

The key idea: operations are part of the app contract and usually reused.

See: [SearchOperationBase](SearchOperationBase.md)

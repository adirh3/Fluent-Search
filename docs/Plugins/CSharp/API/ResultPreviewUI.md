# Result Preview UI (Avalonia)

Fluent Search supports custom preview UI for results using Avalonia.

This is the part of the ecosystem where you can build richer previews than plain text (images, scrollable content, buttons, etc.).

**Typical namespaces (community plugins):**

- `Avalonia.Controls` (Control, TextBlock, Button, Grid, ScrollViewer, etc.)
- `Avalonia.Input` (KeyGesture)
- `Blast.Core.Interfaces` (`ISearchResult`)
- `Blast.API.Graphics` (image helpers in some versions)

Community plugins commonly implement `IResultPreviewControlBuilder`:

- `CanBuildPreviewForResult(ISearchResult result)` to choose which results you handle.
- `CreatePreviewControl(ISearchResult result)` to return an Avalonia `Control`.

## Interface overview

`IResultPreviewControlBuilder` is typically shaped like:

- `bool CanBuildPreviewForResult(ISearchResult searchResult)`
- `ValueTask<Control> CreatePreviewControl(ISearchResult searchResult)`
- `PreviewBuilderDescriptor PreviewBuilderDescriptor { get; }`

Exact method signatures may vary slightly by version, but the concept is consistent.

## PreviewBuilderDescriptor

Preview builders can expose a descriptor with name/description and behaviors (for example auto-show preview).

Common fields you’ll see in the wild:

- `Name`
- `Description`
- `ShowPreviewAutomatically`

## Tips

- Keep preview building lightweight (avoid blocking UI threads).
- Prefer async workflows for network requests.
- If you must update UI from background work, marshal back to the UI dispatcher (when available in your API version).

## Example: simple preview builder

```csharp
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Layout;
using Blast.Core.Interfaces;

public sealed class MyPreviewBuilder : IResultPreviewControlBuilder
{
	public PreviewBuilderDescriptor PreviewBuilderDescriptor { get; } = new()
	{
		Name = "My Preview",
		Description = "Shows extra information",
		ShowPreviewAutomatically = true
	};

	public bool CanBuildPreviewForResult(ISearchResult searchResult)
		=> searchResult?.ResultType == "Example";

	public ValueTask<Control> CreatePreviewControl(ISearchResult searchResult)
	{
		var panel = new StackPanel
		{
			Orientation = Orientation.Vertical,
			Children =
			{
				new TextBlock { Text = searchResult.DisplayedName },
				new TextBlock { Text = searchResult.Context }
			}
		};

		return new ValueTask<Control>(panel);
	}
}
```

## Styling and themes

Community plugins often bind to dynamic resources so previews follow Fluent Search themes (for example setting background via a dynamic resource key instead of hard-coding colors).

If your preview uses custom colors, prefer theme resources where possible.

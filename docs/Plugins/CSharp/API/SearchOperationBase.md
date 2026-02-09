# SearchOperationBase

`SearchOperationBase` is the common base class for operations shown on the right side of Fluent Search.

**Typical namespace:** `Blast.Core.Results`

Operations are attached to results via `ISearchResult.SupportedOperations`.

## Common properties

- `OperationName`: label shown to the user.
- `Description`: operation help text.
- `IconGlyph`: operation icon.
- `HideMainWindow`: whether Fluent Search should hide when the op runs.
- `KeyGesture`: optional shortcut for the operation.

`KeyGesture` is commonly an Avalonia type (`Avalonia.Input.KeyGesture`).

## Built-in operations

`Blast.API` ships built-in operations that many plugins reuse:

- Copy operations (for example copying text/url to clipboard)
- Paste/self-run variants (used by some plugins to run immediately)

Tip: Reuse operation instances (store them as fields/static properties) to avoid allocations.

See also: [Built-in search operations](BuiltInSearchOperations.md)

## Example: custom operation

```csharp
public sealed class OpenWebsiteOperation : SearchOperationBase
{
	public OpenWebsiteOperation() : base(
		operationName: "Open website",
		description: "Opens the website in your default browser",
		icon: "\uE71B")
	{
		HideMainWindow = true;
	}
}
```

In `ISearchApplication.HandleSearchResult`, you typically dispatch by `result.SelectedOperation` type and then perform the action.

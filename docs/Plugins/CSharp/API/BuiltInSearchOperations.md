# Built-in search operations

`Blast.API` includes built-in operations you can reuse instead of writing your own `SearchOperationBase` for common actions.

**Typical namespaces seen in community plugins:**

- `Blast.API.Search.SearchOperations`
- `Blast.Core.Results`

## Copy operations

### `CopySearchOperation`

Used to copy text to the clipboard when executed.

Common patterns:

```csharp
var copy = new CopySearchOperation();
var copyUrl = new CopySearchOperation("Copy URL")
{
    Description = "Copies the page URL to clipboard."
};
```

In `HandleSearchResult`, many plugins still implement the copy explicitly (e.g., via `TextCopy.Clipboard.SetText(...)`) when the copied payload depends on selected operation.

## “Self run” operations

Some versions expose “self run” variants (used by the Clipboard plugin):

- `CopySearchOperationSelfRun`
- `PasteSearchOperationSelfRun`

Treat these as version-dependent and confirm they exist in your referenced package.

## KeyGesture and HideMainWindow

Operations often set:

- `HideMainWindow = false` for operations that should keep the UI visible (like “Keep result”).
- `KeyGesture` for quick execution (Avalonia’s `KeyGesture`).

Example:

```csharp
public sealed class RemoveSearchOperation : SearchOperationBase
{
    public RemoveSearchOperation() : base(
        "Remove from history",
        "Removes this item",
        "\uE74D")
    {
        HideMainWindow = false;
        KeyGesture = new KeyGesture(Key.Delete);
    }
}
```

## When to use built-ins vs custom operations

Use built-ins when:

- The operation is generic (copy text/url, etc.)
- You want consistency with other plugins

Use custom operations when:

- You need extra metadata/behavior on the operation type (e.g., an enum like `ActionType`)
- Your action needs complex dispatch logic

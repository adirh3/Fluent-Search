# Graphics & images

Plugins can attach images to results and/or show images inside preview UI.

**Typical namespaces seen in community plugins:**

- `Blast.API.Graphics`
- `Blast.Core.Results`
- `Avalonia.Media.Imaging` (when converting for preview UI)

## `BitmapImageResult`

`BitmapImageResult` is commonly used as the `PreviewImage` payload.

Patterns seen in community plugins:

### Embedded resource placeholder

```csharp
var assembly = Assembly.GetExecutingAssembly();
var placeholder = new BitmapImageResult(
    assembly.GetManifestResourceStream("MyPlugin.Assets.placeholder.png"));
```

### From a downloaded bitmap

Some plugins download an image stream and convert it to a bitmap, then wrap it.

## Converting for Avalonia controls

When building custom preview UI, plugins often convert to an Avalonia `Bitmap`:

```csharp
Bitmap bitmap = searchResult.PreviewImage.ConvertToAvaloniaBitmap();
```

Treat `ConvertToAvaloniaBitmap()` as version-dependent.

## Tips

- Prefer a lightweight placeholder when images are missing.
- Avoid downloading large images on every keystroke.
- Cache image results (and evict) if you fetch from the network.

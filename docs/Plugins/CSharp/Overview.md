# C# Plugins API Reference

Fluent Search supports plugins written in **C#**. The most common plugin type is a **Search App**: it receives the user's input and returns results.

This section is written for **developers** (plugin authors). It focuses on the shape of the APIs and patterns that work well in production plugins.

At a high level:

1. Implement `ISearchApplication` to create a Search App
2. Return `ISearchResult` items (usually by inheriting `SearchResultBase`)
3. Attach actions using `ISearchOperation` (usually by inheriting `SearchOperationBase`)
4. React to the user choosing an operation in `HandleSearchResult`

This section is an API-oriented companion to the tutorial in [Authoring C# plugins](../Authoring%20C%23%20plugins.md).

---

## NuGet packages

| Package | Target | Description |
|---|---|---|
| **Blast.API** | `net10.0` | Main package for plugin authors — includes all three assemblies below |
| Blast.Core | `net10.0` | Foundation types: interfaces, results, objects, search tags |
| Blast.API.Core | `net10.0` | Platform abstractions: processes, hotkeys, file system, graphics, AI |
| Blast.API | `net10.0` | High-level helpers: text matching, settings UI, built-in operations |

**Plugin `.csproj` requirements:**
- `<TargetFramework>net10.0</TargetFramework>`
- `<EnableDynamicLoading>true</EnableDynamicLoading>`
- Reference `Blast.API` with `<Private>false</Private>` and `<ExcludeAssets>runtime</ExcludeAssets>`

Package versions align with Fluent Search versions. Pin the exact version you ship against.

---

## Namespaces

| Namespace | Contains |
|---|---|
| `Blast.Core.Interfaces` | `ISearchApplication`, `ISearchResult`, `ISearchOperation`, `IHandleResult`, `IPreviewImageProvider`, `IResultPreviewControlBuilder`, `ISettingsPage`, `ISettingManager` |
| `Blast.Core.Results` | `SearchResultBase`, `SearchOperationBase`, `HandleResult`, `SearchTag`, `BitmapImageResult`, `CustomSearchResult`, `CustomSearchOperation`, `CopySearchOperation` |
| `Blast.Core.Objects` | `SearchApplicationInfo`, `SearchRequest`, `ProcessInfo`, `Setting`, `InformationElement`, `SettingPage` |
| `Blast.API.Search` | `SearchHelper` (text matching/scoring), `SearchWindow`, `SearchMapping`, `SearchResultsCacheManager`, `ActionSearchOperation`, `CopySearchOperation`, `PasteSearchOperation`, `LoadingSearchResult` |
| `Blast.API.Processes` | `ProcessUtils`, `ProcessManager`, `BackgroundProcessUtils` |
| `Blast.API.Settings` | `SearchApplicationSettingsPage`, `SettingsUtils`, `GenericTypeControlBuilder`, `AppHotkeySetting`, `ActionSettingButton` |
| `Blast.API.FileSystem` | `FileUtils`, `DirectoryFinder` |
| `Blast.API.Graphics` | `BitmapUtils`, `ScreenUtils` |
| `Blast.API.Hotkeys` | `HotkeyManager`, `HotkeyUtils` |
| `Blast.API.AI` | `AIUtils` (text similarity) |
| `Blast.API.Appearance` | `AppearanceUtils`, `TextIcon` |
| `Blast.API.Controllers` | `KeyboardController`, `MouseController`, `SpeechUtils` |

---

## Core architecture

### Start here

| Topic | Page |
|---|---|
| The plugin contract | [ISearchApplication](API/ISearchApplication.md) |
| The search input model | [SearchRequest](API/SearchRequest.md) |
| Results | [SearchResultBase](API/SearchResultBase.md) |
| Operations | [SearchOperationBase](API/SearchOperationBase.md) |
| Returning actions | [HandleResult](API/HandleResult.md) |

### Common building blocks

| Topic | Page |
|---|---|
| Search tags | [SearchTag](API/SearchTag.md) |
| App metadata | [SearchApplicationInfo](API/SearchApplicationInfo.md) |
| Settings pages + persistence | [Settings](API/Settings.md) |
| Launching processes / URLs | [Processes](API/Processes.md) |
| Custom preview UI (Avalonia) | [Result Preview UI](API/ResultPreviewUI.md) |

### Utility APIs

| Topic | Page |
|---|---|
| Built-in operations (Copy/Paste/Action) | [Built-in Operations](API/BuiltInSearchOperations.md) |
| Text matching and scoring | [Text Matching](API/TextMatching.md) |
| Async enumerable patterns | [Async Helpers](API/AsyncHelpers.md) |
| Images and bitmaps | [Graphics & Images](API/GraphicsImages.md) |
| Result ranking, caching, grouping | [Result Behavior Tuning](API/ResultBehaviorTuning.md) |

---

## Complete API surface

### Interfaces (Blast.Core.Interfaces)

| Interface | Purpose |
|---|---|
| `ISearchApplication` | **The plugin contract** — implement this to create a Search App |
| `ISearchResult` | Full result interface (prefer `SearchResultBase`) |
| `ISearchOperation` | Action on a result (prefer `SearchOperationBase`) |
| `ISearchResultHandler` | Base interface for result handling |
| `IHandleResult` | Return type from handling a result |
| `IPreviewImageProvider` | Provides icon glyph or bitmap preview |
| `IResultPreviewControlBuilder` | Creates AvaloniaUI preview controls |
| `ISettingsPage` | Settings page declaration |
| `ISettingManager` | Controls default/suggestion behavior |
| `ISettingMigrationManager` | Migrates old settings values |
| `IEnablable` | Toggle enable/disable |
| `IControlEdit` | Create an edit control |

### Result types (Blast.Core.Results)

| Class | Purpose |
|---|---|
| `SearchResultBase` | Base class for search results |
| `SearchOperationBase` | Base class for result operations |
| `HandleResult` | Standard `IHandleResult` implementation |
| `SearchTag` / `SearchTagDescriptor` | Search tag definitions |
| `BitmapImageResult` | Image wrapper (Bitmap/Stream → Avalonia) |
| `InformationalSearchResult` | Result with information elements + image |
| `CustomSearchResult` | Generic result with dynamic children |
| `CustomSearchOperation` | Simple operation returning success |
| `FuncSearchOperation` | Operation backed by `Action` or `Func<Task>` |
| `CopySearchOperation` | Built-in clipboard copy operation |

### Data models (Blast.Core.Objects)

| Class | Purpose |
|---|---|
| `SearchApplicationInfo` | Metadata about your Search App |
| `SearchRequest` | Incoming search parameters |
| `Setting` | Full-featured setting with change tracking |
| `ProcessInfo` | Process metadata (PID, title, icon, etc.) |
| `InformationElement` | Key-value pair for the result UI |
| `SettingPage` | Settings page model |
| `SearchType` (enum) | `SearchAll`, `SearchProcess` |

### Platform abstractions (Blast.API.Core)

| Area | Key types |
|---|---|
| **Processes** | `IProcessManager`, `IProcessUtils`, `IBackgroundProcess`, `IWindowMonitor`, `ProcessSwitchedEventArgs` |
| **File system** | `IFileManagerController`, `IFileUtils`, `IOsDirectoryFinder`, `ApplicationInfo` |
| **Graphics** | `IScreenUtils`, `ScreenInfo` |
| **Hotkeys** | `Hotkey`, `IHotkeyManager`, `KeyPressedEventArgs` |
| **AI** | `IAIUtils`, `IEmbedder`, `ITextSimilarity` |
| **Controllers** | Keyboard, Mouse, Speech subdirectories |
| **OS** | `IOsNotificationManager`, `IOsOperationProvider`, `IOsSettingsProvider`, `IWindowUtils` |

---

## Key design patterns

### IAsyncEnumerable for results

`SearchAsync` returns `IAsyncEnumerable<ISearchResult>` — yield results as they become available:

```csharp
public async IAsyncEnumerable<ISearchResult> SearchAsync(SearchRequest request,
    [EnumeratorCancellation] CancellationToken ct)
{
    await foreach (var item in FetchItemsAsync(ct))
    {
        yield return new MySearchResult(item);
    }
}
```

### Cancellation

Always check `cancellationToken.IsCancellationRequested` and pass the token to async operations. When the user types a new character, the old search is cancelled.

### Static operation instances

Pre-allocate operation objects to avoid re-creating them on every search:

```csharp
public static ISearchOperation CopyOperation { get; } = new CopySearchOperation("Copy");
```

### Settings pages

Use `SearchApplicationSettingsPage` from `Blast.API` to auto-generate settings UI from your model class with `[Setting]` attributes.

---

## Dependencies

| Library | Version | Used for |
|---|---|---|
| AvaloniaUI | 12.x | Custom UI controls and preview panels |
| SkiaSharp | 3.x | Image processing |
| System.Drawing.Common | 10.x | Bitmap handling |
| YamlDotNet | 16.x | YAML serialization (Tasks system) |
| TextCopy | 1.x | Cross-platform clipboard |

---

## Versioning

`Blast.API` package versions align with Fluent Search versions. If you target a specific build, pin the matching version to avoid runtime API mismatches.

**Tip:** Don't rely on floating pre-release ranges (`*-*`) in production plugins. Pin the exact version you ship against.

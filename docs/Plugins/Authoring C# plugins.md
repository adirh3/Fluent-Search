## Authoring C# Plugins for Fluent Search

Fluent Search supports writing plugins in **C#** and building custom UI controls with [**AvaloniaUI**](http://avaloniaui.net/), a cross-platform .NET UI framework.

This guide walks you through creating a complete Search App plugin from scratch.

##### Table of Contents
- [Prerequisites](#prerequisites)
- [Getting started](#getting-started)
- [Source code](#source-code)
- [Create a new class library project](#create-a-new-class-library-project)
- [Add the NuGet packages](#add-the-nuget-packages)
- [Implementation](#implementation)
- [Load the Search App](#load-the-search-app)
- [Debugging](#debugging)
- [Best practices](#best-practices)
- [More on ISearchResult](#more-on-isearchresult)
- [Implement support for custom tags](#implement-support-for-custom-tags-optional)
- [Examples](#examples)
- [Troubleshooting](#troubleshooting)

---

## Prerequisites

| Requirement | Details |
|---|---|
| **.NET SDK** | .NET 10.0 — [Download](https://dotnet.microsoft.com/download/dotnet/10.0) |
| **C# knowledge** | Basic to intermediate |
| **IDE** | [JetBrains Rider](https://www.jetbrains.com/rider/) (Paid), [Visual Studio Community](https://visualstudio.microsoft.com/vs/community/) (Free), or [Visual Studio Code](https://code.visualstudio.com) |
| **Blast.API NuGet** | [nuget.org/packages/Blast.API](https://www.nuget.org/packages/Blast.API/) — package version aligns with Fluent Search version |
| **Fluent Search** | [Download](https://fluentsearch.net/) |

---

## Getting started

Fluent Search uses **Search Apps** to search through different resources. In this guide, we'll build a Search App that converts numbers to Hex/Binary format.

For API-level documentation (one page per key type), see the [C# API reference](CSharp/Overview.md).

## Source code

Find the complete example code on [GitHub](https://github.com/adirh3/NumberConverter.Fluent.Plugin/).

---

## Create a new class library project

### Using Terminal

```powershell
mkdir NumberConverter.Fluent.Plugin && cd NumberConverter.Fluent.Plugin
dotnet new sln
dotnet new classlib -n "NumberConverter.Fluent.Plugin"
dotnet sln NumberConverter.Fluent.Plugin.sln add NumberConverter.Fluent.Plugin\NumberConverter.Fluent.Plugin.csproj
```

### Using Visual Studio

1. Launch Visual Studio → **Create a new project**
2. Choose **Class Library**
3. Name: `NumberConverter.Fluent.Plugin`
4. Ensure **Place solution and project in the same directory** is **disabled**
5. Choose **.NET 10.0**

> **Important:** The plugin DLL must end with the suffix `Fluent.Plugin.dll`. Fluent Search uses this naming convention to discover plugins.

Edit `NumberConverter.Fluent.Plugin.csproj`:

```xml
<Project Sdk="Microsoft.NET.Sdk">

    <PropertyGroup>
        <TargetFramework>net10.0</TargetFramework>
        <ImplicitUsings>enable</ImplicitUsings>
        <EnableDynamicLoading>true</EnableDynamicLoading>
    </PropertyGroup>

    <ItemGroup>
        <PackageReference Include="Blast.API" Version="1.1.*-*">
            <Private>false</Private>
            <ExcludeAssets>runtime</ExcludeAssets>
        </PackageReference>
    </ItemGroup>

</Project>
```

Key points:
- `EnableDynamicLoading` is **required** — allows Fluent Search to load your DLL dynamically
- `Private=false` and `ExcludeAssets=runtime` prevent duplicating Blast.API assemblies that Fluent Search already provides
- Update the `Version` to match your target Fluent Search version

---

## Add the NuGet packages

```powershell
cd NumberConverter.Fluent.Plugin
dotnet add package Blast.API --prerelease
dotnet restore
```

Or install via the NuGet Package Manager in your IDE.

---

## Implementation

You need three classes:

### 1. Create a search result

Each Search App returns `ISearchResult` objects. Inherit from `SearchResultBase`:

```csharp
using System.Collections.Generic;
using Blast.Core.Interfaces;
using Blast.Core.Objects;
using Blast.Core.Results;

namespace NumberConverter.Fluent.Plugin
{
    public sealed class NumberConversionSearchResult : SearchResultBase
    {
        public NumberConversionSearchResult(int number, string searchAppName,
            string convertedNumber, string resultName, string searchedText,
            string resultType, double score, IList<ISearchOperation> supportedOperations,
            ICollection<SearchTag> tags, ProcessInfo processInfo = null)
            : base(searchAppName, resultName, searchedText, resultType, score,
                supportedOperations, tags, processInfo)
        {
            Number = number;
            ConvertedNumber = convertedNumber;

            // Optional: ML features for search prediction
            MlFeatures = new Dictionary<string, string>
            {
                ["ConvertedNumber"] = ConvertedNumber
            };
        }

        public int Number { get; }
        public string ConvertedNumber { get; set; }

        protected override void OnSelectedSearchResultChanged()
        {
            // Called when this result is selected/deselected in the UI
        }
    }
}
```

### 2. Create search operations

Operations are the actions that appear on the right side of Fluent Search when a result is selected. Inherit from `SearchOperationBase`:

```csharp
using Blast.Core.Results;

namespace NumberConverter.Fluent.Plugin
{
    public enum ConversionType
    {
        Any,
        Hex,
        Binary
    }

    public class ConversionSearchOperation : SearchOperationBase
    {
        public ConversionType ConversionType { get; }

        // Static instances to avoid recreating the same objects
        public static ConversionSearchOperation HexConversionSearchOperation { get; } =
            new ConversionSearchOperation(ConversionType.Hex);

        public static ConversionSearchOperation BinaryConversionSearchOperation { get; } =
            new ConversionSearchOperation(ConversionType.Binary);

        public ConversionSearchOperation(ConversionType conversionType)
            : base($"Convert more {conversionType} in web",
                   $"Opens a {conversionType} conversion website", "\uE8EF")
        {
            ConversionType = conversionType;
        }
    }
}
```

### 3. Create the search application

Implement `ISearchApplication` — this is the main plugin contract:

```csharp
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Blast.API.Core.Processes;
using Blast.API.Processes;
using Blast.Core;
using Blast.Core.Interfaces;
using Blast.Core.Objects;
using Blast.Core.Results;

namespace NumberConverter.Fluent.Plugin
{
    public class NumberConversionSearchApp : ISearchApplication
    {
        private const string SearchAppName = "NumberConvertor";
        private readonly List<SearchTag> _searchTags;
        private readonly SearchApplicationInfo _applicationInfo;
        private readonly List<ISearchOperation> _supportedOperations;

        public NumberConversionSearchApp()
        {
            // Icon glyphs: https://learn.microsoft.com/windows/apps/design/style/segoe-ui-symbol-font
            _searchTags = new List<SearchTag>
            {
                new SearchTag
                {
                    Name = ConversionType.Hex.ToString(),
                    IconGlyph = "\uE8EF",
                    Description = "Convert to hex"
                },
                new SearchTag
                {
                    Name = ConversionType.Binary.ToString(),
                    IconGlyph = "\uE8EF",
                    Description = "Convert to binary"
                }
            };

            _supportedOperations = new List<ISearchOperation>
            {
                ConversionSearchOperation.HexConversionSearchOperation,
                ConversionSearchOperation.BinaryConversionSearchOperation
            };

            _applicationInfo = new SearchApplicationInfo(SearchAppName,
                "This app converts hex to decimal", _supportedOperations)
            {
                MinimumSearchLength = 1,
                IsProcessSearchEnabled = false,
                IsProcessSearchOffline = false,
                ApplicationIconGlyph = "\uE8EF",
                SearchAllTime = ApplicationSearchTime.Fast,
                DefaultSearchTags = _searchTags
            };
        }

        public ValueTask LoadSearchApplicationAsync()
        {
            // Load resources async on Fluent Search startup (optional)
            return ValueTask.CompletedTask;
        }

        public SearchApplicationInfo GetApplicationInfo()
        {
            return _applicationInfo;
        }

        public async IAsyncEnumerable<ISearchResult> SearchAsync(SearchRequest searchRequest,
            [EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested ||
                searchRequest.SearchType == SearchType.SearchProcess)
                yield break;

            string searchedTag = searchRequest.SearchedTag;
            string searchedText = searchRequest.SearchedText;
            ConversionType conversionType = ConversionType.Any;

            // Check if the search tag is relevant to this app
            if (!string.IsNullOrWhiteSpace(searchedTag))
            {
                if (!searchedTag.Equals(SearchAppName, StringComparison.OrdinalIgnoreCase) &&
                    !Enum.TryParse(searchedTag, true, out conversionType))
                    yield break;
            }

            if (!int.TryParse(searchedText, out int number))
                yield break;

            if (conversionType == ConversionType.Any || conversionType == ConversionType.Hex)
            {
                string convertedNumber = number.ToString("X");
                yield return new NumberConversionSearchResult(number, SearchAppName,
                    convertedNumber, $"Hex {searchedText} is {convertedNumber}",
                    searchedText, "Hex", 2, _supportedOperations, _searchTags);
            }

            if (conversionType == ConversionType.Any || conversionType == ConversionType.Binary)
            {
                string convertedNumber = Convert.ToString(number, 2);
                yield return new NumberConversionSearchResult(number, SearchAppName,
                    convertedNumber, $"Binary {searchedText} is {convertedNumber}",
                    searchedText, "Binary", 2, _supportedOperations, _searchTags);
            }
        }

        public ValueTask<ISearchResult> GetSearchResultForId(object searchObjectId)
        {
            // Used for custom tags (bookmarked results) — optional
            return new ValueTask<ISearchResult>();
        }

        public ValueTask<IHandleResult> HandleSearchResult(ISearchResult searchResult)
        {
            if (searchResult is not NumberConversionSearchResult numberResult)
                throw new InvalidCastException(nameof(NumberConversionSearchResult));

            if (numberResult.SelectedOperation is not ConversionSearchOperation conversionOp)
                throw new InvalidCastException(nameof(ConversionSearchOperation));

            IProcessManager managerInstance = ProcessUtils.GetManagerInstance();
            switch (conversionOp.ConversionType)
            {
                case ConversionType.Hex:
                    managerInstance.StartNewProcess(
                        $"https://www.hexadecimaldictionary.com/hexadecimal/{numberResult.Number:X}");
                    break;
                case ConversionType.Binary:
                    managerInstance.StartNewProcess(
                        $"https://www.binary-code.org/binary/16bit/{Convert.ToString(numberResult.Number, 2)}");
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return new ValueTask<IHandleResult>(new HandleResult(true, false));
        }
    }
}
```

---

## Load the Search App

### Compile

```powershell
dotnet publish -c Release -r win-x64
```

Copy all DLLs (or just your plugin DLL) from `bin\Release\net10.0\win-x64\publish\` to the appropriate plugins directory:

| Install Type | Directory |
|---|---|
| **Microsoft Store** | `%LOCALAPPDATA%\Packages\21814BlastApps.BlastSearch_pdn8zwjh47aq4\LocalCache\Roaming\Blast\FluentSearchPlugins\NumberConversionSearchApp\` |
| **Sideload** | `%LOCALAPPDATA%\Packages\FluentSearch.SideLoad_4139t8dvwn2ka\LocalCache\Roaming\Blast\FluentSearchPlugins\NumberConversionSearchApp\` |
| **EXE installer** | `%APPDATA%\Blast\FluentSearchPlugins\NumberConversionSearchApp\` |

You'll need to create these directories manually.

### Create `pluginsInfo.json`

Add this file to your plugin directory:

```json
{
  "IsEnabled": true,
  "InstalledVersion": "1.0.0.0",
  "Name": "NumberConverter",
  "DisplayName": "Number Converter",
  "Description": "Use hex/binary tags to convert numbers",
  "PublisherName": "Blast Apps",
  "Version": "1.0.0.0",
  "URL": "https://github.com/adirh3/NumberConverter.Fluent.Plugin/",
  "IconGlyph": "\uE8EF"
}
```

Icon glyphs: [Segoe MDL2 Assets](https://learn.microsoft.com/windows/apps/design/style/segoe-ui-symbol-font)

### Test in Fluent Search

Restart Fluent Search and try typing a number — you should see Hex and Binary conversion results.

---

## Debugging

### JetBrains Rider

1. Launch Fluent Search
2. Open your project in Rider, set breakpoints
3. Press `Ctrl + Alt + P` → select the Fluent Search process
4. Search in Fluent Search to trigger your plugin — breakpoints will hit
5. Evaluate expressions with `Shift + F9`

### Visual Studio

1. Launch Fluent Search
2. In Visual Studio: **Debug → Attach to Process** → select Fluent Search
3. Set breakpoints and search to trigger

---

## Best practices

### Performance

- **Avoid `try-catch` blocks** where possible — exception handling is expensive. Check conditions first.
- **Don't use `HttpResponseMessage.EnsureSuccessStatusCode()`** — check the status code property instead.
- **Create `HttpClient` with `using`:** `using var httpClient = new HttpClient();`
- **Use `System.Text.Json`** for JSON parsing.
- **Reduce `async` overhead** — use `ContinueWith` instead of `async/await` where appropriate.
- **Prefer `Channel` over `ConcurrentBag`** for producer/consumer patterns.
- **Don't pass `cancellationToken` to `ContinueWith(() => channel.Writer.Complete())`** — you don't want the channel left open on cancellation.
- **Check `task.IsCompletedSuccessfully`** before accessing `task.Result`.
- **Pass cancellation tokens to `ReadAllAsync()`**.

### String and text

- Use `+` operator for string concatenation (no practical performance difference for small strings).
- Use `sampleText.SearchDistance(searchedText)` for fuzzy matching scores (built into `Blast.API`).
- Compare tags case-insensitively: `searchedTag.Equals(TagName, StringComparison.OrdinalIgnoreCase)`

### Parallel network calls

For multiple network calls in a loop, use `ParallelForEachAsync` instead of sequential `foreach`.

### JSON

Make JSON model classes `internal` with `UpperCamelCase` property names, then use `PropertyNameCaseInsensitive = true` in deserialization options.

### Built-in operations

Use `new CopySearchOperation("Copy Text")` — a built-in operation from `Blast.API` — instead of implementing copy yourself.

### UI thread

Use `UiUtilities.UiDispatcher.Post(() => { })` to update UI elements or show dialogs. Use sparingly — it impacts performance.

### Code formatting

- **Rider:** `Ctrl + Alt + Enter` to format a file, or `Code > Code Cleanup` for the whole project
- **Visual Studio + ReSharper:** similar formatting capabilities
- **Free alternatives:** [CodeMaid](https://marketplace.visualstudio.com/items?itemName=SteveCadwallader.CodeMaid), [Roslynator](https://marketplace.visualstudio.com/items?itemName=josefpihrt.Roslynator2019)

---

## More on ISearchResult

The `SearchResultBase` class exposes many properties you can set:

| Property | Description |
|---|---|
| `ResultName` | Text displayed in the right panel |
| `DisplayedName` | Text of the search result on the left side |
| `SearchedText` | The user's typed text |
| `ResultType` | Type label displayed in the result |
| `Score` | Sort priority (higher = higher position). Also use `sampleText.SearchDistance(searchedText)` |
| `Tags` | Active search tags |
| `SupportedOperations` | List of available operations for this result |
| `IconGlyph` | Icon displayed when no preview image is available |
| `PreviewImage` | A `BitmapImageResult` from a `Bitmap` or `Stream` |
| `UseIconGlyph` | Force icon glyph even when PreviewImage exists |
| `AdditionalInformation` | Text displayed below the result name |
| `Context` | URL or text used for context-aware features |
| `SearchObjectId` | Unique ID for custom tag (bookmark) support |
| `MlFeatures` | Key-value pairs for ML-based ranking |

This list is non-exhaustive — use **Go to Declaration** on `SearchResultBase` in your IDE to discover all properties.

---

## Implement support for custom tags (optional)

Custom tags let users **bookmark** search results. Since serialization of complex results can be costly, Fluent Search delegates result recreation to the plugin.

### How it works

1. User clicks **+** on a result to save it under a custom tag
2. Fluent Search stores the `SearchObjectId` you provided
3. When the user activates that custom tag later, Fluent Search calls `GetSearchResultForId(searchObjectId)`
4. Your plugin recreates the result from the stored ID

### Implementation

```csharp
public ValueTask<ISearchResult> GetSearchResultForId(object searchObjectId)
{
    MyDataClass data;
    switch (searchObjectId)
    {
        case string json:
            data = JsonSerializer.Deserialize<MyDataClass>(json);
            break;
        case MyDataClass typed:
            data = typed;
            break;
        default:
            return default;
    }

    // Recreate the search result from the stored data
    return new ValueTask<ISearchResult>(CreateResultFrom(data));
}
```

> **Tip:** Always check the type before casting — Fluent Search may provide a JSON string if deserialization to your class fails.

### Testing

1. Save a result from your plugin under a custom tag
2. Exit and restart Fluent Search
3. Activate your custom tag — if the result appears correctly, the implementation works. Otherwise, Fluent Search shows "Not Available."

See the [Wikipedia Preview plugin](https://github.com/MakeshVineeth/WikiPreview.Fluent.Plugin) for a working example.

---

## Examples

| Plugin | Source |
|---|---|
| **Clipboard** | [GitHub](https://github.com/adirh3/Clipboard.Fluent.Plugin) |
| **Wikipedia Preview** | [GitHub](https://github.com/MakeshVineeth/WikiPreview.Fluent.Plugin) |
| **Number Converter** | [GitHub](https://github.com/adirh3/NumberConverter.Fluent.Plugin/) |
| **Translator** | [GitHub](https://github.com/adirh3/Translator.Fluent.Plugin) |

---

## Troubleshooting

If your Search App doesn't load:

1. Check for **error logs** in the plugin directory (e.g., `..\FluentSearchPlugins\NumberConversionSearchApp\`)
2. Ensure all required DLLs are present — missing dependencies are the most common failure
3. Verify the DLL name ends with `Fluent.Plugin.dll`
4. Check that `pluginsInfo.json` exists and `IsEnabled` is `true`
5. Ensure your plugin targets the correct .NET version (`net10.0`)

---

**For help:** support@fluentsearch.net | [Discord](https://discord.gg/W2EuWvD6GD)

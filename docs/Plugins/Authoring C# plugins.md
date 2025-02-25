Fluent Search supports writing plugins in **C#** and also supports making Custom UI Controls for Plugins using a cross-platform .NET UI framework called [**AvaloniaUI**](http://avaloniaui.net/).

##### Table of Contents  
- [Prerequisites](#prerequisites)
- [Getting Started](#getting-started)
- [Source Code](#source-code)
- [Create a new class library project](#create-a-new-class-library-project)
    + [Using Terminal](#using-terminal)
    + [Using Visual Studio](#using-visual-studio)
- [Add the NuGet packages](#add-the-nuget-packages)
- [Implementation](#implementation)
  * [Create a search result](#create-a-search-result)
  * [Create the search operation](#create-the-search-operation)
  * [Create the search application](#create-the-search-application)
- [Load the Search app](#load-the-search-app)
  * [Compile](#compile)
  * [Plugins Info file](#plugins-info-file)
  * [Check in Fluent Search](#check-in-fluent-search)
- [Debugging in JetBrains Rider IDE](#debugging-in-jetbrains-rider-ide)
- [Best Practices](#best-practices)
    + [Format Code](#format-code)
- [More on ISearchResult](#more-on-isearchresult)
- [Implement Support for Custom Tags (Optional)](#implement-support-for-custom-tags-optional)
    + [How it works](#how-it-works)
    + [Testing](#testing)
- [Examples](#examples)
- [Troubleshooting](#troubleshooting)

## Prerequisites
* .NET 7.0 - [**Download**](https://dotnet.microsoft.com/download/dotnet/7.0)
* Basic C# Knowledge.
* [**JetBrains Rider**](https://www.jetbrains.com/rider/) (Paid) | [**Visual Studio Community**](https://visualstudio.microsoft.com/vs/community/) (Free) | [**Visual Studio Code**](https://code.visualstudio.com) | any C# IDE.
* Blast NuGet Packages: [**nuget.org**](https://www.nuget.org/packages/Blast.API/), the package version aligns with Fluent Search version.
* Fluent Search Version [**Download**](https://fluentsearch.net/)

## Getting Started
Fluent Search uses `Search Applications` to search through many resources. In this guide, we will write a Search Application that converts numbers to Hex/Binary format.

## Source Code
You can find an Up-to-Date code of the example below on the [**GitHub**](https://github.com/adirh3/NumberConverter.Fluent.Plugin/).

## Create a new class library project
#### Using Terminal
Open PowerShell in any directory & type in:
- `mkdir NumberConverter.Fluent.Plugin && cd NumberConverter.Fluent.Plugin`
- `dotnet new sln`
- `dotnet new classlib -n "NumberConverter.Fluent.Plugin"`
- `dotnet sln NumberConverter.Fluent.Plugin.sln add NumberConverter.Fluent.Plugin\NumberConverter.Fluent.Plugin.csproj`

#### Using Visual Studio
You can also create your project using Visual Studio through following steps:
- Launch Visual Studio and click on `Create a new project`.
- Choose **Class Library** project.
- Name the Project and Solution Name to `NumberConverter.Fluent.Plugin`
- Make sure `Place solution and project in the same directory` option is **disabled**.
- Choose **.NET 6.0 (Current)**

:information_source: **NOTE:** The Plugin DLL has to end with the suffix `Fluent.Plugin.dll`, if not Fluent Search will not try to load it.

Go to **NumberConverter.Fluent.Plugin** directory and edit the `NumberConverter.Fluent.Plugin.csproj` to: (Change the Assembly Version whenever you want to give an update to the Plugin)

<Project Sdk="Microsoft.NET.Sdk">

    <PropertyGroup>
        <TargetFramework>net7.0</TargetFramework>
        <ImplicitUsings>enable</ImplicitUsings>
        <EnableDynamicLoading>true</EnableDynamicLoading>
    </PropertyGroup>
    
    <ItemGroup>
        <PackageReference Include="Blast.API" Version="0.9.92-*">
            <Private>false</Private>
            <ExcludeAssets>runtime</ExcludeAssets>
        </PackageReference>
    </ItemGroup>
    
</Project>


## Add the NuGet packages
In the PowerShell, run the following commands:

- `cd NumberConverter.Fluent.Plugin`
- `dotnet add package Blast.API --prerelease`
- `dotnet restore`

You can also install it using NuGet Package Manager in Visual Studio or JetBrains Rider.

## Implementation
You will need to add the following files to the `NumberConverter.Fluent.Plugin` directory.

### Create a search result
Each Search Application in Fluent Search returns `ISearchResult` object that contains all the relevant information of the search result. (The left side of Fluent Search). Add a new file called `NumberConversionSearchResult.cs` with the following code:

    using System.Collections.Generic;
    using Blast.Core.Interfaces;
    using Blast.Core.Objects;
    using Blast.Core.Results;

    namespace NumberConverter.Fluent.Plugin
    {
        public sealed class NumberConversionSearchResult : SearchResultBase
        {
            public NumberConversionSearchResult(int number, string searchAppName, string convertedNumber, string resultName, string searchedText,
                string resultType, double score, IList<ISearchOperation> supportedOperations, ICollection<SearchTag> tags,
                ProcessInfo processInfo = null) : base(searchAppName,
                resultName, searchedText, resultType, score,
                supportedOperations, tags, processInfo)
            {
                Number = number;
                ConvertedNumber = convertedNumber;

                // You can also add Machine Learning features to improve search predictions (optional)
                MlFeatures = new Dictionary<string, string>
                {
                    ["ConvertedNumber"] = ConvertedNumber
                };
            }

            public int Number { get; }
        
            public string ConvertedNumber { get; set; }
    
            protected override void OnSelectedSearchResultChanged()
            {
                 // Leave this method empty for now.
            }
        }
    }

The `Blast.API` gives the pre-implemented `SearchResultBase` so you won't need to implement `ISearchResult`.

### Create the search operation
All search results contain a list of `ISearchOperation` (The right side of Fluent Search). The user can select any operation to trigger it. Add a new file called `NumberConversionSearchOperation.cs` with the following code:

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

            public static ConversionSearchOperation HexConversionSearchOperation { get; } =
                new ConversionSearchOperation(ConversionType.Hex);

            public static ConversionSearchOperation BinaryConversionSearchOperation { get; } =
                new ConversionSearchOperation(ConversionType.Binary);

            public ConversionSearchOperation(ConversionType conversionType) : base($"Convert more {conversionType} in web",
                $"Opens a {conversionType} conversion website", "\uE8EF")
            {
                ConversionType = conversionType;
            }
        }
    }

This is a basic implementation of the two supported operations - Hex / Binary. We used static code to not create the same object each time.

### Create the search application
You must add a search application, which is a class that implements `ISearchApplication`. Add a new file called `NumberConversionSearchApp.cs` with the following code:

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
                // For Icon Glyphs, visit: https://docs.microsoft.com/en-us/windows/uwp/design/style/segoe-ui-symbol-font
                _searchTags = new List<SearchTag>
                {
                    new SearchTag
                        {Name = ConversionType.Hex.ToString(), IconGlyph = "\uE8EF", Description = "Convert to hex"},
                    new SearchTag
                        {Name = ConversionType.Binary.ToString(), IconGlyph = "\uE8EF", Description = "Convert to binary"}
                };

                _supportedOperations = new List<ISearchOperation>
                {
                    ConversionSearchOperation.HexConversionSearchOperation,
                    ConversionSearchOperation.BinaryConversionSearchOperation
                };

                _applicationInfo = new SearchApplicationInfo(SearchAppName,
                    "This apps converts hex to decimal", _supportedOperations)
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
                // This is used if you need to load anything asynchronously on Fluent Search startup
                return ValueTask.CompletedTask;
            }

            public SearchApplicationInfo GetApplicationInfo()
            {
                return _applicationInfo;
            }

            public async IAsyncEnumerable<ISearchResult> SearchAsync(SearchRequest searchRequest,
                [EnumeratorCancellation] CancellationToken cancellationToken)
            {
                if (cancellationToken.IsCancellationRequested || searchRequest.SearchType == SearchType.SearchProcess)
                    yield break;
                string searchedTag = searchRequest.SearchedTag;
                string searchedText = searchRequest.SearchedText;
                ConversionType conversionType = ConversionType.Any;

                // Check that the search tag is something this app can handle
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
                    yield return new NumberConversionSearchResult(number, SearchAppName, convertedNumber,
                        $"Hex {searchedText} is {convertedNumber}", searchedText, "Hex", 2,
                        _supportedOperations, _searchTags);
                }

                if (conversionType == ConversionType.Any || conversionType == ConversionType.Binary)
                {
                    string convertedNumber = Convert.ToString(number, 2);

                    // You can return multiple results, as this is an IAsyncEnumerable.
                    yield return new NumberConversionSearchResult(number, SearchAppName, convertedNumber,
                        $"Binary {searchedText} is {convertedNumber}", searchedText, "Binary", 2,
                        _supportedOperations, _searchTags);
                }
            }

            public ValueTask<ISearchResult> GetSearchResultForId(object searchObjectId)
            {
                // This is used to calculate a search result after Fluent Search has been restarted.
                // This is only used by the custom search tag feature and is optional to implement.
                return new ValueTask<ISearchResult>();
            }
            
            // This is where you're going to implement the code for search operations.
            public ValueTask<IHandleResult> HandleSearchResult(ISearchResult searchResult)
            {
                if (!(searchResult is NumberConversionSearchResult numberConversionSearchResult))
                {
                    throw new InvalidCastException(nameof(NumberConversionSearchResult));
                }

                if (!(numberConversionSearchResult.SelectedOperation is ConversionSearchOperation conversionSearchOperation)
                )
                {
                    throw new InvalidCastException(nameof(ConversionSearchOperation));
                }

                // Get Fluent Search process manager instance
                IProcessManager managerInstance = ProcessUtils.GetManagerInstance();
                switch (conversionSearchOperation.ConversionType)
                {
                    case ConversionType.Hex:
                        managerInstance.StartNewProcess(
                            $"https://www.hexadecimaldictionary.com/hexadecimal/{numberConversionSearchResult.Number:X}");
                        break;
                    case ConversionType.Binary:
                        managerInstance.StartNewProcess(
                            $"https://www.binary-code.org/binary/16bit/{Convert.ToString(numberConversionSearchResult.Number, 2)}");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
 
                return new ValueTask<IHandleResult>(new HandleResult(true, false));
            }
        }
    }

This Search Application converts the searched text to hex/binary based on the searched tag.

For example, if you receive input as following:

**Searched Text** - "10" & **Searched Tag** - ""
> The results will be "Hex 10 is A" and "Binary 10 is 1010".

And for **Searched Text** - "10" & **Searched Tag** - "hex"
> The results will be only "Hex 10 is A".

## Load the Search app
### Compile
Firstly, you should compile your Plugin for release.

In the PowerShell you opened earlier run the following command:

- `dotnet publish -c Release -r win10-x64`

Now, copy all the files (you can copy only your DLLs, in this case it's `NumberConversionSearchApp.dll`) from `{YourDir}\NumberConversionSearchApp\bin\Release\net7.0\win10-x64\publish` to:

- If installed through Microsoft Store - `C:\Users\{Your_User_Name}\AppData\Local\Packages\21814BlastApps.BlastSearch_pdn8zwjh47aq4\LocalCache\Roaming\Blast\FluentSearchPlugins\NumberConversionSearchApp\`

- If installed through sideload - `C:\Users\{Your_User_Name}\AppData\Local\Packages\FluentSearch.SideLoad_4139t8dvwn2ka\LocalCache\Roaming\Blast\FluentSearchPlugins\NumberConversionSearchApp\`

- If installed through EXE - `C:\Users\{Your_User_Name}\AppData\Roaming\Blast\FluentSearchPlugins\NumberConversionSearchApp\`

You will need to create these directories manually.

### Plugins Info file
In addition, you will need to add a file called `pluginsInfo.json` to your plugin directory, with the following information:
   
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

You can find Icon Glyphs at [**HERE**](https://docs.microsoft.com/en-us/windows/uwp/design/style/segoe-ui-symbol-font).

### Check in Fluent Search
Restart Fluent Search and check if your Search Application is working!

![image](https://fluentsearch.net/data/adirshamen/2020/10/Fluent%20Search%2030_10_2020%2020_03_37.png)

## Debugging in JetBrains Rider IDE
If you're using JetBrains Rider, then you can debug your Search Application right within the Fluent Search itself! Make sure you're on the latest DLLs.
- Launch Fluent Search.
- Open your project in Rider IDE, and choose some breakpoints.
- Press `Ctrl + Alt + P`, select the Fluent Search process from the list.
- Now open Fluent Search, and try to use your plugin, it should hit the breakpoint.
- You can also evaluate expressions during debugging by pressing `Shift + F9` and type your statements.

## Best Practices
The following tips are not just related to Plugins, but are related to C# in general:

- Avoid using `try catch` blocks as catching and throwing exceptions might affect the FS Performance.
- Avoid using `HttpResponseMessage.EnsureSuccessStatusCode`, same as above, throwing exceptions might affect performance. You should just check the status code property and if it's not success then don't return a result.
- Try creating an `HttpClient` every time you do a request like this - `using var httpClient = new HttpClient();` the `using` part means "Release the resources used by the client when this method finished executing".
- Use `+` operator for string concatenations instead of `StringBuilder` as there is no practical performance difference if there are not too many strings.
- If you're making multiple network calls in a `for-each` loop, you can try look into `ParallelForEachAsync` method​ instead. But do remember that, Parallel Programming may not always be faster but you can try nevertheless.
- Use `System.Text.Json` for JSON Parsing.
- Reduce `async` overheads whenever possible by using `ContinueWith` instead of `async await`.
- Prefer `Channel` instead of `Bag`.
- Don't pass `cancellationToken` to `ContinueWith(_=> channel.Writer.Complete()` because you don't want the Channel to stay open because the search was cancelled.
- Don't check `task.Result` immediately, check first `task.IsCompletedSuccessfully` and only if it is, then get `Result`.
- Pass the cancellation token to `ReadAllAsync()` if you have it in your code.
- You can use `UiUtilities.UiDispatcher.Post(() => {})` to alter UI Elements of your Search Result and also to show UI Dialogs like `MessageBox`, `SaveFileDialog` etc. But it is bad for Performance and use only when it is essential for your plugin.
- You can use `sampleText.SearchDistance(searchedText)` method to find a score and provide it to `ResultScore`. It is a built-in method in `Blast.API`
- Make your JSON class `internal` and change all property names to be in the `UpperUpper` convention. Then you will need to make the JSON serialization case in-sensitive in **GetFromJsonAsync** by adding `new JsonSerializerOptions(){PropertyNameCaseInsensitive = true}` after the URL parameter.
- In the `SearchAsync` method, check that `searchedTag.Equals(WikiSearchTagName, StringComparison.OrdinalIgnoreCase)`.
- If your plugin needs to have a Text Copy operation, then you can use the `new CopySearchOperation("Copy Text")` which is a built-in operation that `Blast.API` provides.

#### Format Code
It is always recommended to format your code every time you make a change to make it much readable for other devs. You can use following tools to format your code:
- JetBrains Rider has great code formatter built-in. You can press `Ctrl + Alt + Enter` to format a single file. You can also use `Code Cleanup` from the `Menu > Code` to clean and format all the files in one go.
- Visual Studio + JetBrains ReSharper Extension **([Paid](https://www.jetbrains.com/resharper/))** gives the similar code formatting as JetBrains Rider.
- You can also try free extensions like [**CodeMaid**](https://marketplace.visualstudio.com/items?itemName=SteveCadwallader.CodeMaid) & [**Roslynator 2019**](https://marketplace.visualstudio.com/items?itemName=josefpihrt.Roslynator2019).

## More on ISearchResult
In `NumberConversionSearchResult.cs` file, you have declared and passing several values to the `ISearchResult` which is nothing but `NumberConversionSearchResult`. You can find some of the values that can be passed here:
- `ResultName` - This is the text that will appear in the Right side of the Fluent Search.
- `DisplayedName` - This is the text of the Search Result on the Left Side of the Fluent Search.
- `SearchedText` - User typed text.
- `ResultType` - Mention the type of the Result. It will be displayed in the Search Result on the Left Side.
- `Score` - FS will sort the results basing on this score. You can also use `sampleText.SearchDistance(searchedText)` which calculates the distance between data and search using Fastenshtein (Levenshtein). Basically, the results are ordered by Score +  ML probability.
- `Tags` - Search tag that is being used currently.
- `SupportedOperations` - Give a list of supported operations, you can provide different operations for different results as you wish.
- `IconGlyph` - Display Icon Glyph. If a Preview Image is available, then that image will be displayed instead of Icon Glyph.
- `PreviewImage` - Provide `BitmapImageResult` which accepts a `Bitmap` or a `Stream`. If `PreviewImage` is `null`, then `IconGlyph` is shown.
- `SearchObjectId` - Pass in a Class Object or a Unique String ID that can help you to recreate the result for custom tags feature. It will be used in `GetSearchResultForId` method.
- `public override string Context => AnyValue;` - Pass in a website url or any text, it will be used by FS for context aware results/features.
- `UseIconGlyph` - Force use `IconGlyph` even if `PreviewImage` is available.
- `AdditionalInformation` - Show Additional Information underneath the `DisplayedName` in the Left Side of FS.
- `MlFeatures` - Used for Machine Learning purposes.

Please note that this list is **non-exhaustive**. You can find more values that can be passed into the `ISearchResult` by right-clicking on the `SearchResultBase` and choose `Go to Declaration or Usages` if your IDE supports it.

## Implement Support for Custom Tags (Optional)
Whenever, a User wants to save a Search Result (Bookmark a Search Result, in other context), then he/she can click on "**+**" button on the Right Panel of a Search Result and save it under a Custom Tag Folder. In order to support retrieval of latest data possible, Fluent Search won't save the Search Results automatically. Moreover, Serialization/Deserialization can be very costly if any of those search results have images. It is the duty of plugin developers to implement the custom tag feature by writing the code to recreate the same result inside `GetSearchResultForId` method.

#### How it works
Whenever a user tries to use a custom tag, it will call the `GetSearchResultForId(object searchObjectId)` method of that search result. The `SearchObjectId` that you've passed in the `ISearchResult` can be retrieved here.

:bulb: **Tip:** Pass a unique ID or a Serializable Class Object to `ISearchResult` that can help you to recreate the same result inside `GetSearchResultForId`.

Firstly, make sure that you're using the correct method signature which is `public ValueTask<ISearchResult> GetSearchResultForId(object searchObjectId)`. You can also find the correct method signature by right-clicking on the `ISearchApplication` and choose `Go to Declaration or Usages` if your IDE supports it.

You can cast the `object searchObjectId` in the following ways:
- `searchObjectId as string;` if you've passed a unique ID in string format.
- `searchObjectId as RandomDataClass;` if you've passed a Class Object. Fluent Search will take care of Serialization & Derialization if the Class is Simple & Serializable.

Sometimes, Fluent Search may fail to deserialize some classes, in such scenarios, it will provide the serialized JSON string instead of Class Object. It is recommended to compare `searchObjectId` with your Class Type before using it directly. Following code illustrates it:

            RandomDataClass randomClass;  
            switch (searchObjectId)  
            {
                case string json:
                    randomClass = JsonSerializer.Deserialize<RandomDataClass>(json);
                    break;
                case RandomDataClass id:
                    randomClass = id;
                    break;
                default:
                    return default;
            }

You can also take a look at the source code of [**Wikipedia Preview**](https://github.com/MakeshVineeth/WikiPreview.Fluent.Plugin) plugin which has the Custom Tag Implementation.

#### Testing
You can test the custom tag feature by using your plugin inside Fluent Search: 
- Save a search result generated by your plugin under a custom tag folder.
- Exit Fluent Search through System Tray and Start it again.
- Try to use your custom tag, if the result is shown, then you've implemented it correctly, else Fluent Search will display **Not Available** text.

## Examples
You can take a look at source code of following Plugins and get started with the Plugins development for Fluent Search:
- [**Clipboard**](https://github.com/adirh3/Clipboard.Fluent.Plugin#clipboardfluentplugin)
- [**Wikipedia Preview**](https://github.com/MakeshVineeth/WikiPreview.Fluent.Plugin)
- [**Number Converter**](https://github.com/adirh3/NumberConverter.Fluent.Plugin/)
- [**Translator**](https://github.com/adirh3/Translator.Fluent.Plugin)

## Troubleshooting
If the Search Application does not load, please check for error logs in the plugin directory, in this case:

`..\FluentSearchPlugins\NumberConversionSearchApp`

Usually, a plugin will fail to load when one or more of its dependencies are missing, so make sure you copy all the relevant DLLs to the plugin directory.


**For help, please send a mail to support@fluentsearch.net**  
**You can also get in touch with us using our [Discord Channel](https://discord.gg/W2EuWvD6GD).**
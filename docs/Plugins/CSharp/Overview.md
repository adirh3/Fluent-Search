# C# plugins ecosystem

Fluent Search supports plugins written in **C#**. The most common plugin type is a **Search App**: it receives the user’s input and returns results.

This section is written for **developers** (plugin authors). It focuses on the *shape* of the APIs and the patterns that work well in production plugins.

At a high level:

- Implement `ISearchApplication` to create a Search App.
- Return `ISearchResult` items (usually by inheriting `SearchResultBase`).
- Attach actions to results using `ISearchOperation` (usually by inheriting `SearchOperationBase`).
- React to the user choosing an operation in `HandleSearchResult`.

This section is an API-oriented companion to the tutorial in [docs/Plugins/Authoring%20C%23%20plugins.md](../Authoring%20C%23%20plugins.md).

## How the packages fit together

In the community plugin examples you’ll typically see these namespaces:

- `Blast.Core.Interfaces`: interfaces like `ISearchApplication`, `ISearchResult`.
- `Blast.Core.Objects`: models like `SearchRequest`, `SearchTag`, and app metadata.
- `Blast.Core.Results`: base types like `SearchResultBase`, `SearchOperationBase`, handle results.
- `Blast.API.*`: convenience helpers (settings, processes, built-in search operations, graphics helpers, etc.).

Exact namespaces and method signatures can vary slightly by Fluent Search / `Blast.API` version; the pages below call this out where it matters.

## Start here

- The plugin contract: [ISearchApplication](API/ISearchApplication.md)
- The search input model: [SearchRequest](API/SearchRequest.md)
- Results: [SearchResultBase](API/SearchResultBase.md)
- Operations: [SearchOperationBase](API/SearchOperationBase.md)
- Returning actions back to Fluent Search: [HandleResult](API/HandleResult.md)

## Common “ecosystem” building blocks

- Search tags in your app: [SearchTag](API/SearchTag.md)
- Declaring your app metadata: [SearchApplicationInfo](API/SearchApplicationInfo.md)
- Settings pages + persistence: [Settings](API/Settings.md)
- Launching processes / opening URLs: [Processes](API/Processes.md)
- Custom preview UI (Avalonia): [Result Preview UI](API/ResultPreviewUI.md)

## Versioning

`Blast.API` package versions align with Fluent Search versions. If you target a specific Fluent Search build, prefer the matching `Blast.API` version to avoid missing APIs at runtime.

Tip: When in doubt, pin the exact version you ship against (don’t rely on floating pre-release ranges for production plugins).

# Blast.API key APIs (C# plugins)

This folder documents the most-used APIs for building C# plugins.

:information_source: API surfaces can differ slightly by Fluent Search / `Blast.API` version. These pages focus on the stable *patterns* and call out common version-sensitive spots.

## How to use these pages

- If you’re starting a new plugin, read [ISearchApplication](ISearchApplication.md) first.
- If you already have a plugin compiling and want richer UX, jump to [SearchResultBase](SearchResultBase.md) and [Result Preview UI](ResultPreviewUI.md).
- If you need persistence and a settings page, see [Settings](Settings.md).

## Core plugin contract

- [ISearchApplication](ISearchApplication.md)
- [SearchRequest](SearchRequest.md)
- [HandleResult](HandleResult.md)

## Results + operations

- [SearchResultBase](SearchResultBase.md)
- [SearchOperationBase](SearchOperationBase.md)
- [Result behavior tuning](ResultBehaviorTuning.md)
- [Built-in search operations](BuiltInSearchOperations.md)

## App metadata and tags

- [SearchApplicationInfo](SearchApplicationInfo.md)
- [SearchTag](SearchTag.md)

## Platform integrations

- [Settings](Settings.md)
- [Processes](Processes.md)
- [Result Preview UI](ResultPreviewUI.md)
- [Graphics & images](GraphicsImages.md)
- [Async helpers](AsyncHelpers.md)

## Matching & scoring

- [Text matching & scoring](TextMatching.md)

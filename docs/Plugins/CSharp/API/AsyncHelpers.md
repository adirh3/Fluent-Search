# Async helpers & patterns

Plugins often need to balance:

- responsiveness (return something quickly)
- throughput (handle many candidates / network calls)
- cancellation (stop work when the user types)

This page documents common patterns used by community plugins.

## Avoid making `SearchAsync` async (when you don’t need to)

Some APIs return `IAsyncEnumerable<ISearchResult>` but don’t require true async work.
In that case, some versions expose `SynchronousAsyncEnumerable` (seen in the Clipboard plugin) to wrap a normal iterator:

```csharp
IEnumerable<ISearchResult> SearchClipboardHistory() { ... }
return new SynchronousAsyncEnumerable(SearchClipboardHistory());
```

Treat `SynchronousAsyncEnumerable` as version-dependent.

## Streaming results with channels

For network-backed apps, a common pattern is:

- Start a network request
- As results complete, write them into a `Channel<T>`
- `await foreach` the channel reader and `yield return`

This keeps UI feeling “live” and naturally supports cancellation.

## Parallel fan-out

The Wikipedia Preview plugin uses `Parallel.ForEachAsync` to process multiple items concurrently.
When you do this:

- limit concurrency if your work is expensive
- always pass the cancellation token
- make sure you `Complete()` the channel even on failures

## Cancellation checklist

- Check `token.IsCancellationRequested` early and frequently.
- Pass the token into `GetFromJsonAsync`, `ReadAllAsync`, etc.
- Avoid `ContinueWith(..., token)` when you *must* complete a channel; you can accidentally keep a channel open.

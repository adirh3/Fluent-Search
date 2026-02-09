# Text matching & scoring

Many plugins rely on string helper methods exposed by the Fluent Search/Blast packages to:

- Decide whether something “matches” the current query.
- Compute a numeric score used to sort results.

These helpers are commonly used in community plugins (Clipboard, Wikipedia Preview, Translator).

## Common helpers

### `SearchTokens(...)`

Used to compute a **score** based on how well a candidate string matches the searched text.

Example (Clipboard plugin):

```csharp
double score = copy.SearchTokens(searchedText);
if (score > 0)
{
    // yield a result with this score
}
```

### `SearchBlind(...)`

Used for a **boolean-ish match** where you don’t need a score.

Example (Translator plugin):

```csharp
if (searchAll || languageName.SearchBlind(searchedText))
    yield return ...;
```

### `SearchDistance(...)`

Some docs and examples mention using a distance-based helper for scoring.
Treat this as version-dependent: confirm your referenced package version exposes it.

## Scoring tips

- Treat the returned score as *relative*; combine it with domain-specific signals (recency, pinned state).
- Avoid expensive scoring work when a simple prefilter can cut the search space.

### Example: recency boost

Community plugins sometimes boost scores based on recency:

```csharp
score += 2.0 * lastCopied.ToFileTime() / DateTime.Now.ToFileTime();
```

## Pitfalls

- If you compute scores for thousands of candidates every keystroke, you can hurt overall FS responsiveness.
- Always respect cancellation in `SearchAsync` and `yield break` quickly.

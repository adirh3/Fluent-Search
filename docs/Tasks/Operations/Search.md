# Search

**Type:** `Search`

Matches user input in the Fluent Search search box.

In most Task projects this is used as a **trigger**, but it’s still an operation type in the Task graph.

## Common settings

- **searchPrefix**: Optional keyword/prefix.
- **searchedText**: Match rule for the remaining input.
- **textMatchType**: `Exact`, `Contains`, `Regex`, `Wildcard`.
- **matchCase**: Case sensitivity.

## Outputs

- `result.SearchedText`
- `result.SearchedTag`

# Search trigger

**Type:** `Search`

The Search trigger starts a Task chain when the user types something that matches a rule.

## Common settings

- **searchPrefix**: Optional keyword/prefix (for example `define`, `fs`, `d`).
- **searchedText**: The remaining text to match.
- **searchedTagExact** (or tag settings): Restrict to a specific search tag.
- **textMatchType**: `Exact`, `Contains`, `Regex`, `Wildcard`.
- **matchCase**: Case sensitivity.
- **searchType**: Commonly `SearchAll` in shared Tasks.

## Outputs

The Search trigger output is commonly mapped into variables:

- `searchText` → `result.SearchedText`
- `searchTag` → `result.SearchedTag`

## Practical tips

- Prefer **anchored regex** (for example `^...$`) when using `Regex`.
- Keep prefixes strict (`Exact` + a clear keyword) to avoid accidental triggers.
- If you expect arguments, match the prefix strictly and keep the rest flexible.

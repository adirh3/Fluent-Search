# SearchTag

`SearchTag` represents a tag users can type to narrow a search (for example `wiki`, `clipboard`, or a language name in a translator plugin).

**Typical namespace:** `Blast.Core.Objects`

## Common properties

- `Name`: tag display name / input name.
- `Description`: optional help text.
- `IconGlyph`: glyph shown in the UI.
- `Value`: optional value when you want to distinguish display name from underlying value.

## Typical patterns

- **Single app tag** (example: `clipboard`): only run when that tag is active.
- **Many tags** (example: languages in a translator): generate tags dynamically in `LoadSearchApplicationAsync()`.

## Tips

- Keep tag names short and memorable.
- If your app can’t reliably handle untagged searches, set `SearchTagOnly = true` in `SearchApplicationInfo`.

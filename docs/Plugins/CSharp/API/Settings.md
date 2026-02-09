# Settings

Plugins can expose settings via a settings page type (commonly `SearchApplicationSettingsPage`).

**Typical namespaces:**

- `Blast.API.Settings` (settings page base + attributes)
- `Blast.Core.Objects` (some setting value types)

Community plugins commonly use:

- A settings page class derived from `SearchApplicationSettingsPage`.
- Properties annotated with `[Setting(...)]` to define how settings render.
- `SettingsUtils.SaveSettings(...)` to persist changes.

## Example: settings page with hidden persistence

```csharp
using System.Collections.Generic;
using Blast.API.Settings;
using Blast.Core.Objects;

public sealed class MySettingsPage : SearchApplicationSettingsPage
{
	public MySettingsPage(SearchApplicationInfo info) : base(info) { }

	[Setting(Name = "Max results", DefaultValue = 10, MinValue = 1, MaxValue = 100)]
	public int MaxResults { get; set; } = 10;

	// Cache, not shown in UI
	[Setting(Name = "Cache", RenderSetting = false)]
	public List<string> CachedItems { get; set; } = new();
}
```

Attach it via `SearchApplicationInfo.SettingsPage = new MySettingsPage(_info);`

## Hidden settings (cache / internal state)

Some plugins store internal data in settings but hide it from the UI by using `RenderSetting = false`.

## Tips

- Keep settings stable across versions (renaming keys breaks migrations).
- Prefer “advanced” flags for settings that most users won’t need.

Also consider:

- Don’t do expensive work in property setters; settings UIs can set values frequently.
- If you store large lists, consider pruning/compaction to keep settings files small.

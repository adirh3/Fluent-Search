# Custom result

**Type:** `Custom result` | **Category:** Search | **Icon:** 📋

Creates a result row inside the Fluent Search UI. This is how Tasks display information to the user — search results with titles, icons, context, and attached operations.

---

## Settings

| Setting | Type | Default | Description |
|---|---|---|---|
| **Name** | string | `"My search result"` | Display name shown in the UI. Supports variables (e.g., `Definition of {searchText}`) |
| **Icon** | PreviewImageProviderSetting | `\uE113` | Result icon (glyph or image) |
| **Context** | string | `""` | Context information (file path, URL, etc.) |
| **Type** | string | `"Custom"` | Result type label displayed in the UI |
| **Group** | string | `""` | Group name for organizing related results |
| **Score** | int (0–100) | 20 | Position score — higher values appear higher in results |
| **Disabled Machine Learning** | bool | false | Disable ML-based result ranking |
| **Allow Pinning** | bool | false | Allow the user to pin this result |
| **Use Child Results** | bool | false | Show attached operations as expandable child results |
| **Auto Preview** | bool | false | Automatically show the preview panel when this result is selected |
| **Information Elements** | List | `[]` | Key-value pairs displayed below the result name |

---

## Outputs

| Output Type | Description |
|---|---|
| Object | The created `ISearchResult` |

### Output properties

| Property | Type | Description |
|---|---|---|
| `DisplayName` | string | The result's display name |
| `ResultType` | string | The result type label |
| `Context` | string | The context string |

---

## Tips

- Keep result names short and descriptive — put details in **Information Elements** or the preview panel.
- Use **variables in the name** to show computed values: `{city} Weather: {temperature}°`
- Connect [Custom operation](Custom%20operation.md) nodes after a Custom result to add action buttons.
- Connect [Get web image](Get%20web%20image.md) after a Custom result to auto-attach a preview image.
- Use [Set search result sound](Set%20search%20result%20sound.md) to add audio feedback when the result is selected.

# Parse JSON

**Type:** `Parse JSON` | **Category:** Scripting | **Icon:** 📄

Parses a JSON string into a dynamic object that you can access with bracket notation in downstream variable expressions. This is the recommended way to extract data from HTTP responses.

---

## Settings

| Setting | Type | Default | Description |
|---|---|---|---|
| **Property Name Case Insensitive** | bool | false | Enable case-insensitive property access |
| **JSON Content** | string (JSON editor) | `""` | JSON text to parse. Use `{{variableName}}` for variable substitution |

---

## Outputs

| Output Type | Description |
|---|---|
| Object | A `JsonNode` object |

### Default variable mappings

| Variable Name | Expression | Description |
|---|---|---|
| `json` | `result` | The parsed JSON object |

### Access patterns

| Expression | Description |
|---|---|
| `result["fieldName"]` | Access a JSON property |
| `result[0]` | Access array element by index |
| `result[0]["name"]` | Array indexing + property access |
| `result["data"]["items"][0]["title"]` | Nested access |

---

## Examples

### Parse an API response

1. HTTP Action → fetches `{"word": "hello", "definitions": [{"text": "A greeting"}]}`
2. **Parse JSON** with Content: `{{httpResponseContent}}`
3. Custom result with Name: `{json["word"]} — {json["definitions"][0]["text"]}`

---

## Tips

- Always use **double curly brackets** `{{variableName}}` for variable substitution in JSON content (to avoid conflicts with JSON's own curly brackets).
- Use this instead of complex C# regex parsing — it's cleaner and more maintainable.
- Enable **case-insensitive** mode when dealing with APIs that have inconsistent casing.

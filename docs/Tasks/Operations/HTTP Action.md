# HTTP Action

**Type:** `HTTP Action` | **Category:** Web | **Icon:** 🌐

Sends an HTTP request and returns the response body as a string. This is the primary way to fetch data from web APIs in Tasks.

---

## Settings

| Setting | Type | Default | Description |
|---|---|---|---|
| **Method** | `Get` / `Post` / `Put` / `Patch` / `Delete` | Get | HTTP method |
| **URI** | string | — | Request URL. Supports variable substitution (e.g., `https://api.example.com/search?q={searchText}`) |
| **Send JSON Body** | bool | false | Send the body as `application/json` content type |
| **Headers** | List of key-value pairs | `[]` | Request headers (e.g., `Authorization: Bearer {apiKey}`). Supports variable substitution |
| **Body** | string (JSON editor) | — | Request body text. Use `{{variableName}}` for variable substitution in JSON |

**Timeout:** 15 seconds per request.

---

## Outputs

| Output Type | Description |
|---|---|
| String | The response body text |

### Default variable mappings

| Variable Name | Expression | Description |
|---|---|---|
| `httpResponseContent` | `result` | The raw HTTP response body |

---

## Examples

### Dictionary lookup

```
URI: https://api.dictionaryapi.dev/api/v2/entries/en/{searchText}
Method: Get
```

Then use [Parse JSON](Parse%20JSON.md) to extract definitions.

### POST with JSON body

```
URI: https://api.example.com/translate
Method: Post
Send JSON Body: true
Body: {{"text": "{{searchText}}", "target": "es"}}
```

Note the double curly brackets — required to distinguish variable interpolation from JSON syntax.

---

## Tips

- Prefer APIs that don't require authentication. If you must use an API key, store it in a **Task project setting** and reference it as `{apiKey}`.
- Use a [Condition](../Triggers/Condition.md) to check `{httpResponseContent != null}` before processing.
- Chain with [Parse JSON](Parse%20JSON.md) to extract specific fields from JSON responses.
- For APIs that return HTML, use a [C# Script](C%23%20Script.md) to parse the response.

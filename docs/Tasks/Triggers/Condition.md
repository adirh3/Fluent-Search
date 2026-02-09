# Condition trigger

**Type:** `Condition` | **Category:** Trigger | **Icon:** ❓

The Condition trigger gates the flow based on a boolean expression. It can be used **mid-flow** (connected between operations) to conditionally continue or stop execution.

---

## Settings

| Setting | Type | Default | Description |
|---|---|---|---|
| **Value** | string | `""` | A boolean expression to evaluate. Supports variable substitution with `{variableName}` |
| **Continue If True** | bool | true | If true, the chain continues when the expression evaluates to true. Set to false to invert the logic |

---

## Outputs

The Condition trigger produces **no output** (OperationResultType.None).

---

## Expression examples

| Expression | Description |
|---|---|
| `{httpResponseContent != null}` | Continue if the HTTP response was received |
| `{searchText.Length > 3}` | Continue if the search text is longer than 3 characters |
| `{searchText.Contains("test")}` | Continue if the search text contains "test" |
| `{csharpScriptResult == "success"}` | Continue if a previous C# script returned "success" |
| `{json["status"].ToString() == "ok"}` | Continue if a parsed JSON field equals "ok" |

Expressions are evaluated as C# code with full access to the current variable dictionary.

---

## Examples

### Validate before HTTP call

Place a Condition between a Search trigger and an HTTP Action:

1. Search trigger → sets `searchText`
2. **Condition:** `{searchText.Length >= 2}` — skip very short queries
3. HTTP Action → proceeds only for meaningful queries

### Branch on result type

After a Result selector:

1. Result selector → sets `searchResult`
2. **Condition:** `{searchResult.ResultType == "File"}` with ContinueIfTrue = true → File-specific operations
3. Separate Condition with `{searchResult.ResultType == "Folder"}` → Folder-specific operations

---

## Tips

- Condition is especially useful for **validating inputs** before expensive operations (HTTP calls, scripts).
- Since expressions support full C# syntax, you can chain conditions: `{searchText != null && searchText.Length > 0}`
- Use **Continue If True = false** to create "skip if" logic without complex expression negation.

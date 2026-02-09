# Condition (operation)

**Type:** `Condition`

The Condition node gates the chain based on a boolean expression. It can be used mid-flow to conditionally continue or stop execution.

For full documentation, see the [Condition trigger](../Triggers/Condition.md) page.

---

## Settings

| Setting | Type | Default | Description |
|---|---|---|---|
| **Value** | string | `""` | Boolean expression with `{variable}` substitution |
| **Continue If True** | bool | true | Continue when expression is true (set false to invert) |

# Keep variable

**Type:** `Keep variable` | **Category:** Misc | **Icon:** 💾

Persists a variable's value in memory across trigger invocations within the same Task project. Normally, variables are reset on each trigger — Keep variable allows state to survive between runs.

---

## Settings

| Setting | Type | Default | Description |
|---|---|---|---|
| **Name** | string | — | Target variable name to persist |
| **Value** | string | — | Source variable name whose value to store |

---

## Outputs

None.

---

## How it works

Stored values are kept in a static dictionary (`TasksManager.States`). On the next trigger invocation in the same project, all kept variables are injected into the variables dictionary before execution begins.

---

## Tips

- Use this for counters, toggles, or cached values that should persist across searches.
- Values are lost when Fluent Search restarts — this is in-memory storage only.

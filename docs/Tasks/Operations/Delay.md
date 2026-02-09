# Delay

**Type:** `Delay` | **Category:** Misc | **Icon:** ⏱️

Pauses execution for a fixed number of milliseconds before continuing to the next operation.

---

## Settings

| Setting | Type | Default | Description |
|---|---|---|---|
| **Delay In MS** | int (1–30,000) | 50 | Delay in milliseconds |

---

## Outputs

None.

---

## Common use cases

- **After [Switch Process](Switch%20Process.md)** — give the target window time to become active (50–200ms)
- **Between [Press keys combo](Press%20keys%20combo.md) and [Type text](Type%20text.md)** — ensure the UI is ready for input
- **Between keystroke sequences** — prevent input from being swallowed by a slow UI

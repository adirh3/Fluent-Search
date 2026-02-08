# Show notification

**Type:** `Show notification` | **Category:** Misc | **Icon:** 🔔

Shows a Windows toast notification.

---

## Settings

| Setting | Type | Default | Description |
|---|---|---|---|
| **Title** | string | `"Fluent Search notification"` | Notification title. Supports variable substitution |
| **Content** | string | `""` | Notification body text. Supports variable substitution |
| **Sound** | `Default` / `Message` / `Mail` / `Reminder` / `SMS` / `Alarm` / `Call` | Default | Notification sound |
| **Silent** | bool | false | Show a silent notification (no sound) |

---

## Outputs

None.

---

## Tips

- Useful for background Tasks (Hotkey or Process switched triggers) where there's no Fluent Search UI to display results.
- Keep titles short and content informative.

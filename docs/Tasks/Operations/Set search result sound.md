# Set search result sound

**Type:** `Set search result sound` | **Category:** Sound | **Icon:** 🔉

Attaches a sound to the preceding search result in the chain. The sound plays when the user selects that result.

---

## Settings

| Setting | Type | Default | Description |
|---|---|---|---|
| **File Path** | string | `""` | Path to the audio file |
| **Cache Audio** | bool | false | Cache the audio stream for faster playback |

---

## Outputs

None.

---

## Tips

- Place this immediately after a [Custom result](Custom%20result.md) to attach the sound.
- Useful for accessibility or for Tasks that teach pronunciation, play alerts, etc.

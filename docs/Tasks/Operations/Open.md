# Open

**Type:** `Open` | **Category:** File | **Icon:** 📂

Opens a file, program, or executable with optional arguments and administrator elevation.

---

## Settings

| Setting | Type | Default | Description |
|---|---|---|---|
| **File Name** | string | `""` | File path or executable name. Supports environment variables and variable substitution |
| **Run As Admin** | bool | false | Run with elevated privileges |
| **Arguments** | string | `""` | Command-line arguments. Supports variable substitution |

---

## Outputs

None.

---

## Examples

- **Open a file:** `FileName = "{searchResult.Context}"`
- **Open in VS Code:** `FileName = "code"`, `Arguments = "{searchResult.Context}"`
- **Open a URL in a specific browser:** `FileName = "C:\Program Files\Google\Chrome\Application\chrome.exe"`, `Arguments = "{url}"`

---

## Tips

- When using `RunAsAdmin`, scope the trigger carefully — for example, use a Result selector that only matches `*.exe`, `*.bat`, or `*.cmd` files.
- Environment variables like `%appdata%` are expanded automatically.

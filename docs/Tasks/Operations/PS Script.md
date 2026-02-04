# PS Script

**Type:** `PS Script`

Runs a PowerShell script.

## Common settings

- **content**: Script content.
- **stopOnError**: Whether to stop the chain on error.
- **runAsAdmin**: Run with elevated permissions.
- **showWindow**: Show/hide the PowerShell window.

## Tips

- Default to `showWindow: false` for a smoother UX.
- Avoid interactive prompts; Tasks should be non-interactive.
- If a script changes system settings, keep the trigger strict (Exact match / explicit Result selector).

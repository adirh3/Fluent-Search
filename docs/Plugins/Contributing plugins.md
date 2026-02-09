## Contributing Plugins to Fluent Search

To have your plugin featured in the **Fluent Search Plugins window**, submit a pull request (PR) to the official [Fluent Search GitHub repository](https://github.com/adirh3/Fluent-Search). This involves adding an entry to the `plugins-manifest.json` file, which serves as the plugin catalog.

---

### Steps to submit your plugin

1. **Fork the repository**

   Go to the [Fluent Search GitHub repository](https://github.com/adirh3/Fluent-Search) and click **Fork**.

2. **Clone your fork**

   ```bash
   git clone https://github.com/your-username/Fluent-Search.git
   ```

3. **Create a branch**

   ```bash
   git checkout -b add-your-plugin
   ```

4. **Edit `plugins-manifest.json`**

   Add a new entry with this structure:

   ```json
   {
     "PluginType": "Dotnet",
     "Name": "YourPluginName",
     "DisplayName": "Your Plugin Display Name",
     "Description": "A brief description of what your plugin does",
     "PublisherName": "Your Name or Organization",
     "Version": "1.0.0.0",
     "MinimumFluentSearchVersion": null,
     "URL": "https://github.com/your-username/your-plugin-repo",
     "DownloadURL": "https://your-download-link.com/your-plugin.zip",
     "IconUrl": null,
     "IconGlyph": "",
     "IconBase64": null
   }
   ```

5. **Commit, push, and create a PR**

   ```bash
   git add plugins-manifest.json
   git commit -m "Add [Your Plugin Name] to plugins manifest"
   git push origin add-your-plugin
   ```

   Then create a pull request on GitHub.

---

### Manifest entry fields

| Field | Required | Description |
|---|---|---|
| **PluginType** | Yes | `"Dotnet"` for C# plugins, `"Task"` for YAML Task plugins |
| **Name** | Yes | Unique identifier for your plugin |
| **DisplayName** | Yes | Name shown in the Plugins window |
| **Description** | Yes | Brief explanation of what the plugin does |
| **PublisherName** | Yes | Your name or organization |
| **Version** | Yes | Current version (`major.minor.patch.build` format) |
| **MinimumFluentSearchVersion** | No | Minimum required Fluent Search version, or `null` |
| **URL** | Yes | Link to your plugin's repository or homepage |
| **DownloadURL** | Yes | Direct download link to the plugin file |
| **IconUrl** | No | URL to a plugin icon image |
| **IconGlyph** | No | Unicode character from [Segoe MDL2 Assets](https://learn.microsoft.com/windows/apps/design/style/segoe-ui-symbol-font) |
| **IconBase64** | No | Base64-encoded icon image data |

---

### Examples

**C# Plugin:**

```json
{
  "PluginType": "Dotnet",
  "Name": "Translator",
  "DisplayName": "Translator",
  "Description": "Use translator tag or specific language tag to translate text",
  "PublisherName": "Blast Apps",
  "Version": "1.4.0.0",
  "MinimumFluentSearchVersion": null,
  "URL": "https://github.com/adirh3/Translator.Fluent.Plugin",
  "DownloadURL": "https://download.fluentsearch.net/fluent-search-plugins/Translator.Fluent.Plugin.1.4.0.zip",
  "IconUrl": null,
  "IconGlyph": "",
  "IconBase64": null
}
```

**Task Plugin:**

```json
{
  "PluginType": "Task",
  "Name": "Change Windows Theme",
  "DisplayName": "Change Windows Theme",
  "Description": "Search 'wt' to change Windows theme",
  "PublisherName": "Blast Apps",
  "Version": "1.0.0.0",
  "MinimumFluentSearchVersion": null,
  "URL": "https://github.com/adirh3/Fluent-Search-Tasks/tree/main/Windows/Change%20Windows%20Theme",
  "DownloadURL": "https://raw.githubusercontent.com/adirh3/Fluent-Search-Tasks/main/Windows/Change%20Windows%20Theme/Change%20Windows%20Theme.yaml",
  "IconUrl": null,
  "IconGlyph": "",
  "IconBase64": null
}
```

---

### Guidelines by plugin type

#### C# plugins (`.zip` / `.dll`)

- Provide a **stable versioned download link** (zip file containing your DLL and dependencies)
- Document the supported Fluent Search version range
- Ensure the DLL file name ends with `Fluent.Plugin.dll`
- Test thoroughly before submitting

#### Task plugins (`.yaml`)

- Host on GitHub and use a **raw file URL** for `DownloadURL`
- Include a README explaining the trigger text/hotkey, what the Task does, and any dependencies
- Avoid destructive actions by default — clearly label scripts that modify the registry, system settings, or require admin
- Prefer small, focused Tasks over complex multi-purpose ones

---

### Before submitting

- **Test** your plugin with the latest Fluent Search version
- **Document** usage instructions and any configuration needed
- **Review** your manifest entry for accuracy
- For Task plugins, ensure the `.yaml` is readable and safe to import

For Task authoring details (triggers, operations, variables), see [Tasks overview](../Tasks/Overview.md).

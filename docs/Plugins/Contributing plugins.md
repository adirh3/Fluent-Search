## Contributing Plugins to Fluent Search

Fluent Search's extensibility is powered by a vibrant community of developers contributing plugins that enhance its functionality. To have your plugin featured in the Fluent Search Plugins window, you'll need to submit a pull request (PR) to the official [Fluent Search GitHub repository](https://github.com/adirh3/Fluent-Search). This involves adding a new entry to the `plugins-manifest.json` file, which serves as the catalog for available plugins.

### Steps to Submit Your Plugin

1. **Fork the Repository**: Navigate to the [Fluent Search GitHub repository](https://github.com/adirh3/Fluent-Search) and click on the "Fork" button to create a personal copy of the repository.

2. **Clone Your Fork**: Clone your forked repository to your local machine using:

   ```bash
   git clone https://github.com/your-username/Fluent-Search.git
   ```

3. **Create a New Branch**: It's good practice to create a new branch for your changes:

   ```bash
   git checkout -b add-your-plugin
   ```

4. **Modify `plugins-manifest.json`**: Locate the `plugins-manifest.json` file in the repository. Add a new entry for your plugin with the following structure:

   ```json
   {
     "PluginType": "Dotnet", // or "Task" for Tasks plugins
     "Name": "YourPluginName",
     "DisplayName": "Your Plugin Display Name",
     "Description": "A brief description of your plugin",
     "PublisherName": "Your Name or Organization",
     "Version": "1.0.0.0",
     "MinimumFluentSearchVersion": null, // or specify a version if applicable
     "URL": "https://github.com/your-username/your-plugin-repo",
     "DownloadURL": "https://your-download-link.com/your-plugin.zip",
     "IconUrl": null, // or provide a URL to your plugin's icon
     "IconGlyph": "", // Unicode character for the icon
     "IconBase64": null // or provide a base64-encoded icon
   }
   ```

   **Note**: Ensure that the `DownloadURL` points directly to the compiled plugin file (e.g., a `.zip` containing your `.dll` for C# plugins or a `.yaml` file for Tasks plugins).

5. **Commit Your Changes**: After editing the file, commit your changes:

   ```bash
   git add plugins-manifest.json
   git commit -m "Add [Your Plugin Name] to plugins manifest"
   ```

6. **Push to Your Fork**: Push the changes to your forked repository:

   ```bash
   git push origin add-your-plugin
   ```

7. **Create a Pull Request**: Go to your fork on GitHub, and you'll see a prompt to create a pull request. Click on it, provide a descriptive title and detailed description, and submit the pull request.

### Plugin Entry Details

When adding your plugin to the `plugins-manifest.json`, ensure the following fields are accurately filled:

- **PluginType**: Specify `"Dotnet"` for C# plugins or `"Task"` for Tasks plugins.

- **Name**: A unique identifier for your plugin.

- **DisplayName**: The name that will appear in the Plugins window.

- **Description**: A concise explanation of what your plugin does.

- **PublisherName**: Your name or the name of your organization.

- **Version**: The current version of your plugin, following the `major.minor.patch.build` format.

- **MinimumFluentSearchVersion**: Specify if your plugin requires a certain version of Fluent Search; otherwise, set to `null`.

- **URL**: Link to your plugin's repository or homepage.

- **DownloadURL**: Direct link to the plugin's downloadable file.

- **IconUrl**: (Optional) URL to an image representing your plugin.

- **IconGlyph**: (Optional) A Unicode character serving as the plugin's icon.

- **IconBase64**: (Optional) Base64-encoded image data for the icon.

**Example for a C# Plugin**:

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
  "IconGlyph": "",
  "IconBase64": null
}
```

**Example for a Tasks Plugin**:

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
  "IconGlyph": "",
  "IconBase64": null
}
```

### Additional Considerations

- **Testing**: Before submitting, thoroughly test your plugin to ensure compatibility and stability with the 
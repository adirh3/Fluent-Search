## Configuring Web Search in Fluent Search

<img alt="Fluent Search Search Tags Settings" src="/docs/images/GoogleWebSearchLight.png" width="600" height="auto">

Fluent Search enables users to perform web searches directly from its interface, streamlining the process of accessing information online. By configuring custom web search engines, you can tailor the search experience to your preferences, allowing for quick queries on platforms like Google, Bing, and others.

### Adding Custom Web Search Engines

To set up and manage web search engines in Fluent Search:

1. **Access Web Search Settings**:
    - Activate Fluent Search by pressing `Ctrl + Alt`.
    - Type `settings` and select the **Settings** option.
    - In the Settings window, navigate to `Apps` > `Web` > `Web Searches`.

2. **Add a New Search Engine**:
    - Click the `Add` button to create a new entry.
    - Provide a name for the search engine (e.g., "Google").
    - Enter the search URL, incorporating `%s` as a placeholder for the search term.

      **Example URLs**:
        - **Google**: `https://www.google.com/search?q=%s`
        - **Bing**: `https://www.bing.com/search?q=%s`
        - **DuckDuckGo**: `https://duckduckgo.com/?q=%s`

    - Save the new search engine configuration.

3. **Using the Configured Search Engines**:
    - Invoke Fluent Search (`Ctrl + Alt`).
    - Type your query followed by the name of the configured search engine.
    - Press `Enter` to execute the search; your default web browser will open with the search results.

### Executing Multiple Searches Simultaneously

Fluent Search allows the execution of multiple web searches at once:

- **Configure Multiple URLs**:
    - In the `Web Searches` settings, input multiple search URLs, each on a new line.
    - Ensure each URL contains the `%s` placeholder.

  **Example**:
  ```
  https://www.google.com/search?q=%s
  https://www.bing.com/search?q=%s
  ```

- **Performing the Search**:
    - Invoke Fluent Search and enter your search term.
    - Press `Enter`; each configured URL will open in a new tab, displaying the search results across multiple platforms.

### Additional Configuration Options

To enhance your web search experience:

- **Set Default Search Engine**:
    - In the `Web Searches` settings, designate a default search engine by selecting the desired entry and marking it as default.

- **Modify Existing Search Engines**:
    - Edit or remove existing search engine configurations as needed to keep your search options up to date.

By customizing web search settings in Fluent Search, you can efficiently access information from your preferred online sources directly through the application.

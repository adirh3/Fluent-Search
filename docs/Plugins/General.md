# Plugins in Fluent Search

Fluent Search is designed to be a versatile and extensible tool, allowing users to enhance its capabilities through a robust **plugin ecosystem**. Plugins enable the addition of new Search Apps, preview providers, and various other functionalities, tailoring Fluent Search to meet diverse user needs.

### Types of Plugins

Fluent Search supports two primary types of plugins:

1. **C# Plugins**: These are native plugins developed using the C# programming language. They integrate seamlessly with Fluent Search, offering high performance and efficient resource utilization.

2. **Task plugins (Tasks)**: A low-code automation system based on chaining triggers and operations. Task plugins are commonly shared as `.yaml` files and can be imported into the Fluent Search Tasks window.

See [Tasks.md](Tasks.md) for how to import, create, and share Tasks.

### Accessing and Managing Plugins

Plugins can be managed directly within Fluent Search:

- **Plugins Window**: Navigate to the Plugins window to browse, enable, or disable available plugins. The list of plugins is sourced from the `plugins-manifest.json` file located in the official [Fluent Search GitHub repository](https://github.com/adirh3/Fluent-Search).

### Examples of Available Plugins

The community has developed a variety of plugins to extend Fluent Search's functionality. Some notable examples include:

- **Wikipedia Preview**: Provides quick previews of Wikipedia articles directly within the search interface.

- **Clipboard Search**: Allows users to search through their clipboard history, enhancing productivity by keeping track of copied content.

- **Currency Converter**: Enables on-the-fly currency conversions within the search bar, facilitating quick financial calculations.

- **Translator**: Offers instant translation capabilities, allowing users to translate text snippets without leaving Fluent Search.

Task plugin examples include:

- **Change Windows Theme** (search `wt`)
- **Dictionary** (search `define <word>`)

By leveraging these plugins, users can customize Fluent Search to better align with their workflows and preferences, creating a more efficient and personalized search experience. 
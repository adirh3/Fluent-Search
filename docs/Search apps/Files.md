## File Search in Fluent Search

<img alt="Fluent Search Search Tags Settings" src="/docs/images/FileTagLight.webp" width="600" height="auto">

Fluent Search offers fast file and folder search. Under the hood, it can use different “indexers” so you can balance speed, system impact, and compatibility with your setup.

If you want reliable, instant results, spend a few minutes configuring which indexer you want and which locations should be included.

### Indexing Mechanisms

#### Native File Indexer

Fluent Search includes its own file indexer service designed for speed and minimal CPU usage.

To use the Fluent Search file indexer:

1. **Install the Indexer Service**:
    - Navigate to `Settings` > `Apps` > `Files` > `File Indexer`.
    - Select `Fluent Search` as your preferred indexer.
    - Follow the prompts to install and start the service.

*Note: Administrative privileges may be required to install the service.*

#### Windows Search Indexer

Fluent Search can integrate with Windows Search so it uses the same index Windows maintains.

1. **Enable Windows Search Integration**:
    - Go to `Settings` > `Apps` > `Files` > `File Indexer`.
    - Select `Windows Search` as the indexer.

2. **Configure Indexed Locations**:
    - Open `Control Panel` > `Indexing Options`.
    - Modify the indexed locations to include directories you want to search.

*Note: Disabling Windows Indexing may affect the functionality of Windows Search and other dependent features.*

#### Everything Indexer

Fluent Search also supports integration with the Everything search engine by Voidtools, known for its rapid indexing and minimal resource usage.

1. **Install Everything**:
    - Download and install [Everything](https://www.voidtools.com/).

2. **Enable Everything Integration in Fluent Search**:
    - Navigate to `Settings` > `Apps` > `Files` > `File Indexer`.
    - Select `Everything` as the indexer.

*Note: Ensure the Everything service is running for Fluent Search to access its index. If Everything client is running as admin, Fluent Search must run as admin as well.*

### Useful Search Tags

The Files Search App commonly supports tags such as:

- `Files` for general file searching
- `File` (files only)
- `Folder` / `Directory` (folders only)
- File extensions like `.pdf`, `.docx`, `.png`

Folder paths can also be used as tags: type a folder path and press `Tab` to search inside it.

### Configuring Indexed and Ignored Paths

Customizing which directories are indexed or ignored can optimize search performance and relevance.

#### Adding Indexed Paths

1. **Access File Indexer Settings**:
    - Go to `Settings` > `Apps` > `Files` > `Indexed Paths`.

2. **Add New Paths**:
    - Click `Add Path` and select the directories you want to include in the index.

#### Ignoring Specific Paths

1. **Access Ignored Paths Settings**:
    - Navigate to `Settings` > `Apps` > `Files` > `Ignored Paths`.

2. **Add Paths to Ignore**:
    - Click `Add Path` and choose the directories or files you want to exclude from the index.

*Note: Properly configuring ignored paths can prevent unnecessary files from appearing in search results and improve performance.*

### Troubleshooting Indexer Issues

If you encounter issues with the file indexer service:

1. **Verify Service Installation**:
    - Open `Services` (`services.msc`).
    - Locate `FluentSearch.FileIndexer`.
    - Ensure the service is running. If not, start it manually.

2. **Reinstall the Indexer Service**:
    - If problems persist, reinstall the service via `Settings` > `Apps` > `Files` > `File Indexer`.

3. **Rebuild the Index**:
    - If results are stale or missing after big changes (large moves, restores, new drive), rebuild the file indexer.

For further assistance, refer to the [Fluent Search GitHub Issues](https://github.com/adirh3/Fluent-Search/issues) page or join the community on [Discord](https://discord.com/invite/fluentsearch).

By understanding and configuring these indexing options, you can tailor Fluent Search to efficiently locate the files and directories most relevant to your needs. 
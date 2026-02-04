## Commands Search App in Fluent Search

<img alt="Fluent Search Window" src="/docs/images/PowerShellSearchLight.webp" width="600" height="auto">

The **Commands** Search App in Fluent Search lets you execute command-line instructions directly from the search interface.

It’s useful when you want “run a command” to be as fast as “open an app”: no window juggling, no hunting through terminal history.

### Executing Commands

To run commands using the Commands search app:

1. **Activate Fluent Search**:
    - Press `Ctrl + Alt` to open the Fluent Search interface.

2. **Enter the Command**:
    - Type your desired command as you would in a command prompt.
    - Press `Enter` to execute the command.

Fluent Search runs the command using your configured command-line interface (CLI).

### Accessing Command History

Fluent Search maintains a history of executed commands, allowing for quick recall and reuse.

1. **View Command History**:
    - In the Fluent Search interface, type a keyword related to a previously executed command.
    - Matching historical commands will appear in the search results.

2. **Execute a Previous Command**:
    - Select the desired command from the history.
    - Press `Enter` to run it again.

### Using the Run Tag

The `Run` tag emulates the Windows Run dialog. It can be used to quickly open apps, execute commands, or open paths.

1. **Invoke the Run Functionality**:
    - Type `Run:` followed by the application name or path.
        - For example: `Run: notepad.exe` or `Run: C:\Users\YourUsername\Documents`.

2. **Execute the Command**:
    - Press `Enter` to open the specified application or directory.

Tip: `Run` is also a great way to launch common tools like `cmd`, `powershell`, `wt` (Windows Terminal), or to open environment-variable paths like `%windir%`.

### Configuring Command-Line Interfaces

To customize which command-line interpreters are available in Fluent Search:

1. **Open Settings**:
    - Activate Fluent Search (`Ctrl + Alt`).
    - Type `settings` and select the **Settings** option.

2. **Navigate to Command-Line Interfaces**:
    - In the Settings window, go to `Apps` > `Commands` > `Command-Line Interfaces`.

3. **Add a New Interface**:
    - Click the `Add` button.
    - Provide the following details:
        - **Name**: A descriptive name for the CLI (e.g., "PowerShell", "Git Bash").
        - **Executable Path**: The full path to the CLI executable.
        - **Arguments**: Any default arguments to include when launching the CLI.

4. **Save the Configuration**:
    - Click `Save` to add the new CLI to Fluent Search.

You can add multiple command-line interfaces and select a default one for general use.

Common CLI choices:

- PowerShell
- Command Prompt
- Git Bash
- WSL distributions

### Setting a Favorite Command-Line Interface

Designating a favorite CLI allows Fluent Search to integrate it with other search apps, such as opening a folder in the command line:

1. **Access Command-Line Interfaces Settings**:
    - Go to `Settings` > `Apps` > `Commands` > `Command-Line Interfaces`.

2. **Set as Favorite**:
    - In the list of configured CLIs, click the star icon next to the one you prefer.

The favorite CLI will now be used for related operations across Fluent Search, enhancing consistency and efficiency in your workflow.

By leveraging the Commands search app and configuring your preferred command-line interfaces, Fluent Search becomes a powerful tool for executing commands and managing tasks directly from a unified interface. 
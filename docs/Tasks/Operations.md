# Operations

An **operation** is any action Fluent Search can perform as part of a Task chain. Operations run **sequentially** along the connections in the Task graph, passing variables from one to the next.

This page is an index of all available operation types, organized by category.

---

## Search

- [Custom result](Operations/Custom%20result.md) — Create a result row in the Fluent Search UI
- [Custom operation](Operations/Custom%20operation.md) — Create an action button on a result (also acts as a trigger)
- [Show and search](Operations/Show%20and%20search.md) — Show Fluent Search and run a search with predefined text/tags
- [Hide search window](Operations/Hide%20search%20window.md) — Instantly hide the search window
- [Invoke result](Operations/Invoke%20result.md) — Invoke a saved search result or return it to the UI

## Web

- [HTTP Action](Operations/HTTP%20Action.md) — Send an HTTP request (GET/POST/PUT/PATCH/DELETE)
- [Open URL](Operations/Open%20URL.md) — Open a URL in the default browser
- [Get web image](Operations/Get%20web%20image.md) — Download an image from a URL (auto-attaches to results)

## File

- [Open](Operations/Open.md) — Open a file or program with optional arguments and elevation
- [Open Parent Folder](Operations/Open%20Parent%20Folder.md) — Open the parent directory of a file path
- [Create file](Operations/Create%20file.md) — Create a text file with specified content
- [Read file text](Operations/Read%20file%20text.md) — Read all text from a file into a variable
- [Open file or folder dialog](Operations/Open%20file%20or%20folder%20dialog.md) — Show a dialog to select a file or folder
- [Get selected file in file manager](Operations/Get%20selected%20file%20in%20file%20manager.md) — Get the path of the selected item in File Explorer

## Processes

- [Switch Process](Operations/Switch%20Process.md) — Bring a process/window to the foreground
- [Invoke UI Element](Operations/Invoke%20UI%20Element.md) — Find and interact with UI elements inside a running app
- [Get context](Operations/Get%20context.md) — Get the folder path or URL of the focused application
- [Set context](Operations/Set%20context.md) — Set the folder path or URL of the focused application

## Inputs

- [Press keys combo](Operations/Press%20keys%20combo.md) — Send a keyboard shortcut to the active window
- [Type text](Operations/Type%20text.md) — Type text into the active window via clipboard paste

## Scripting

- [C# Script](Operations/C%23%20Script.md) — Run a C# snippet with access to all variables
- [PS Script](Operations/PS%20Script.md) — Run a PowerShell script
- [Parse JSON](Operations/Parse%20JSON.md) — Parse JSON text into a dynamic object for property access

## Sound

- [Play audio file](Operations/Play%20audio%20file.md) — Play a sound from a file
- [Set search result sound](Operations/Set%20search%20result%20sound.md) — Attach a sound to a search result
- [Text to speech](Operations/Text%20to%20speech.md) — Speak text aloud when speech mode is enabled

## Misc

- [Delay](Operations/Delay.md) — Wait a fixed number of milliseconds
- [Copy text](Operations/Copy%20text.md) — Copy text to the clipboard
- [Get clipboard text](Operations/Get%20clipboard%20text.md) — Read the current clipboard text into a variable
- [Keep variable](Operations/Keep%20variable.md) — Persist a variable's value across trigger invocations
- [Show window](Operations/Show%20window.md) — Open a Fluent Search window (Settings, Plugins, Tasks, etc.)
- [Show notification](Operations/Show%20notification.md) — Show a Windows toast notification

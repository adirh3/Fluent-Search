# Tasks

Tasks are Fluent Search's **visual, low-code automation system**. A Task project is a graph of **triggers** and **operations** that you wire together in a node-based editor to automate workflows on your computer.

- A **trigger** starts the chain (a matching search, a hotkey press, a result selector, a process switch, or a condition).
- An **operation** performs an action (open a URL, run a script, send an HTTP request, show a custom result, type text, press keys, and much more).
- **Variables** flow between operations — outputs from one operation become inputs for the next.

Tasks are commonly shared as `.yaml` files (often called **Task plugins**).

---

## Quick start

### Import a Task project (`.yaml`)

1. Download a Task's `.yaml` file.
2. Open the **Tasks** window in Fluent Search.
3. Drag-and-drop the `.yaml` into the Tasks window, or use the import button.

**Safety note:** If you didn't author the file, review it in a text editor first. Tasks can execute scripts, open programs, send keystrokes, and call external APIs.

### Create your own Task

1. Open the **Tasks** window in Fluent Search.
2. Create a new Task project.
3. Add a **Trigger** node (Search, Hotkey, Result selector, Process switched, etc.).
4. Add one or more **Operation** nodes and connect them in the order you want.
5. Configure each node's settings and define variable mappings.
6. Save, then test by performing the trigger action.

---

## The visual editor

The Task editor is a **node graph**. Each node represents a trigger or operation:

- **Drag** nodes to position them on the canvas.
- **Connect** nodes by dragging from one node's output to another node's input — this defines the execution order.
- **Click** a node to configure its settings, variable mappings, and comment.
- **Zoom and pan** with scroll wheel and drag on the canvas.

---

## Variables, inputs, and outputs

Every operation has **settings** (inputs you configure) and many operations produce an **output**.

### How variables work

1. When an operation completes, it may produce a result (a string, object, boolean, etc.).
2. You define **variable mappings** on each node — these are `Name = Expression` pairs.
3. The expression extracts a value from the result and stores it under the given variable name.
4. Downstream operations can reference that variable in their settings using `{variableName}` syntax.

### Variable expressions

| Expression | Description |
|---|---|
| `result` | The raw operation result |
| `result.SearchedText` | Access a property of the result object |
| `result["fieldName"]` | Access a dictionary key or JSON property |
| `result[0]["name"]` | Array indexing + property access |

Expressions are evaluated as C# code at runtime.

### Variable substitution in settings

All string settings automatically support variable interpolation:

- Use `{variableName}` to insert a variable's value — for example, `https://api.example.com/search?q={searchText}`
- For JSON content, use double curly brackets `{{variableName}}` to distinguish from JSON syntax
- Any valid C# expression works inside `{}` — for example, `{searchText.ToUpper()}` or `{searchText.Length > 5 ? "long" : "short"}`

### Special variable types

| Variable | Source | Description |
|---|---|---|
| **Project settings** | Task project settings | User-configurable values injected at trigger start |
| **Kept variables** | Keep variable operation | Values that persist across trigger invocations within the same project |
| **Trigger outputs** | Trigger nodes | Automatically exposed (e.g., `searchText`, `searchTag` from Search triggers) |

---

## Task project settings

Projects can expose **user-configurable settings** that appear in the Fluent Search Settings window:

| Property | Type | Description |
|---|---|---|
| **Variable Name** | string | Variable name accessible in operations |
| **Name** | string | Display label in Settings UI |
| **Group Name** | string | Group related settings together |
| **Category** | string | Collapsible category header |
| **Description** | string | Help text shown to the user |
| **Setting Type** | `Text`, `Number`, `Toggle`, `Hotkey` | Control type in Settings UI |
| **Default Value** | any | Pre-filled default |
| **Value Range** | min–max | For Number type, constrains the input |

When `ShowSettingPage` is enabled, a dedicated settings page appears under Settings for the Task project — making your Task feel like a first-class feature.

---

## YAML format

Task projects are serialized as `.yaml` files with this structure:

```yaml
name: My Task
author: Your Name
description: What the task does
enable: true
taskProjectSettings:
  showSettingPage: false
  settings: []
children:
  - id: 1
    type: Search          # Trigger/operation type name
    model:                # Settings for this node
      searchPrefix: "define"
      searchedText:
        text: ""
        matchType: Contains
    variables:            # Variable mappings
      - name: searchText
        value: result.SearchedText
    children:             # Connected downstream nodes
      - id: 2
        type: HTTP Action
        model:
          method: Get
          uRI: "https://api.example.com/?q={searchText}"
        variables:
          - name: httpResponseContent
            value: result
        children: []
```

Key fields: `type` is the operation name, `model` contains settings, `variables` are output mappings, and `children` are downstream connected nodes.

---

## Triggers

Triggers start a Task flow. See the [Triggers](Triggers.md) index for detailed documentation.

| Trigger | Description |
|---|---|
| [**Search**](Triggers/Search.md) | Fires when user input matches a configured pattern |
| [**Result selector**](Triggers/Result%20selector.md) | Fires when a matching search result appears — attach custom operations to existing results |
| [**Hotkey**](Triggers/Hotkey.md) | Fires when a configured hotkey is pressed |
| [**Process switched**](Triggers/Process%20switched.md) | Fires when the user switches between applications |
| [**Condition**](Triggers/Condition.md) | Gates the flow based on a boolean expression (inline trigger/operation) |
| [**For each**](Triggers/For%20each.md) | Iterates over an array, triggering child operations once per item |

---

## Operations

Operations perform actions. See the [Operations](Operations.md) index for detailed documentation.

| Category | Operations |
|---|---|
| **Search** | [Custom result](Operations/Custom%20result.md), [Custom operation](Operations/Custom%20operation.md), [Show and search](Operations/Show%20and%20search.md), [Hide search window](Operations/Hide%20search%20window.md), [Invoke result](Operations/Invoke%20result.md) |
| **Web** | [HTTP Action](Operations/HTTP%20Action.md), [Open URL](Operations/Open%20URL.md), [Get web image](Operations/Get%20web%20image.md) |
| **File** | [Open](Operations/Open.md), [Open Parent Folder](Operations/Open%20Parent%20Folder.md), [Create file](Operations/Create%20file.md), [Read file text](Operations/Read%20file%20text.md), [Open file or folder dialog](Operations/Open%20file%20or%20folder%20dialog.md), [Get selected file in file manager](Operations/Get%20selected%20file%20in%20file%20manager.md) |
| **Processes** | [Switch Process](Operations/Switch%20Process.md), [Invoke UI Element](Operations/Invoke%20UI%20Element.md), [Get context](Operations/Get%20context.md), [Set context](Operations/Set%20context.md) |
| **Inputs** | [Press keys combo](Operations/Press%20keys%20combo.md), [Type text](Operations/Type%20text.md) |
| **Scripting** | [C# Script](Operations/C%23%20Script.md), [PS Script](Operations/PS%20Script.md), [Parse JSON](Operations/Parse%20JSON.md) |
| **Sound** | [Play audio file](Operations/Play%20audio%20file.md), [Set search result sound](Operations/Set%20search%20result%20sound.md), [Text to speech](Operations/Text%20to%20speech.md) |
| **Misc** | [Delay](Operations/Delay.md), [Copy text](Operations/Copy%20text.md), [Get clipboard text](Operations/Get%20clipboard%20text.md), [Keep variable](Operations/Keep%20variable.md), [Show window](Operations/Show%20window.md), [Show notification](Operations/Show%20notification.md) |

---

## Tips for building reliable Tasks

- **Use a prefix** (for example `define `, `wt `, `fs `) in Search triggers so your Task doesn't trigger accidentally on normal searches.
- **Add small Delays** (50–200ms) after switching focus with Switch Process — the target window needs time to become active.
- **Use Hide search window** before sending keystrokes or typing text, so input goes to the target app instead of Fluent Search.
- **Validate before acting** — use a Condition node to check variable values before making HTTP calls, running scripts, or simulating input.
- **Keep scripts fast and deterministic** — avoid interactive prompts in PowerShell scripts. Use `StopOnError` to handle failures.
- **Use Parse JSON** to extract fields from HTTP responses instead of complex regex or C# script parsing.
- **Use project settings** to let users customize API keys, preferences, or behavior — avoid hardcoding values.

---

## Safety notes

Tasks can automate your system. Before importing a Task from the internet, review the `.yaml` file, especially operations that:

- Run PowerShell or C# scripts
- Open programs (optionally as administrator)
- Send keystrokes or type text
- Call external web APIs (check URLs and headers)
- Modify files or system settings

---

## Community Task projects

Browse community Task projects and get inspiration:

- **GitHub:** https://github.com/adirh3/Fluent-Search-Tasks

Popular community Tasks include:
- **Dictionary** — type `define <word>` for instant definitions
- **Change Windows Theme** — type `wt` to switch light/dark theme
- **Currency Converter** — type `12 USD in EUR` for live conversion
- **Color Preview** — type `#FF5733` to preview a color
- **C# City** — run C# expressions like `{DateTime.Now}`
- **Open in VS Code** — open files/folders in Visual Studio Code
- **Lorem Ipsum Generator** — generate placeholder text

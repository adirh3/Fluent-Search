# Tasks

Tasks are Fluent Search’s low-code automation system.

A **Task project** is a graph (chain) of **triggers** and **operations**:

- A **trigger** starts the chain (for example: a matching search, a hotkey, or a “result selector” action).
- An **operation** performs an action (show a result, run a script, open a URL, send keystrokes, etc.).

Tasks are commonly shared as `.yaml` files (often called **Tasks plugins**).

## Quick start

### Import a Task project (`.yaml`)

1. Download a Task’s `.yaml` file.
2. Drag-and-drop the `.yaml` into the **Fluent Search Tasks** window.

Tip: If you didn’t author the file, review it in a text editor first. Tasks can execute scripts, open programs, and call external APIs.

### Create your own Task

1. Open **Tasks** in Fluent Search.
2. Create a new Task project.
3. Add a **Trigger**.
4. Add one or more **Operations**, then connect them in the order you want.
5. Save, then test the trigger.

## Variables, inputs, outputs (the mental model)

Every operation has an editor with **inputs** (settings). Some operations also produce an **output**.

You can map outputs into **variables**, and reference those variables later in the chain.

- Variables and templating use **C#-style expressions**.
- You’ll often see `{variableName}` placeholders inside URLs, result titles, scripts, and operation settings.

Example patterns you’ll see in community Tasks:

- Search triggers map `result.SearchedText` into a variable named `searchText`.
- HTTP calls parse JSON and map fields into variables (then show them in a Custom result).

## Tips for building reliable Tasks

- Prefer a **prefix** (for example `define `, `fs `) so your Task doesn’t trigger accidentally.
- When simulating UI input, add small **Delay** operations and use **Switch Process** before sending keys.
- Use **Hide search window** after launching/switching, so keystrokes don’t go to Fluent Search.
- Keep scripts deterministic and fast; stop on error where available.

## Safety notes

Tasks can automate your system.

Before importing a Task from the internet, review the `.yaml`, especially operations that:

- run PowerShell or C# scripts
- open programs (optionally as admin)
- send keystrokes / type text
- call external web APIs

## Community Task projects

Browse community projects here:

- https://github.com/adirh3/Fluent-Search-Tasks

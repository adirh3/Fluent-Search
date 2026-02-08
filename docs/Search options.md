## Customizing Search Options in Fluent Search

<img alt="Fluent Search Window" src="/docs/images/SearchSettingsLight.webp" width="700" height="auto">

Fluent Search offers a highly customizable search experience, giving you control over how searches behave, how results are displayed and grouped, and how the app responds to your interactions. These settings are found under **Settings → Search**.

---

### Search experience

#### Fuzzy Search

Fuzzy search is enabled by default and allows Fluent Search to find results even when your typing contains small typos, missing characters, or abbreviations. For example, typing `mcd` can match "My Cool Document."

When fuzzy search is disabled, Fluent Search uses stricter word-based matching that requires full words to match.

To toggle fuzzy search: **Settings → Search → Experience**.

#### Pinyin Search

For Chinese language users, Fluent Search supports Pinyin romanization search. When enabled, you can type Pinyin to find results with Chinese characters. Enabling this requires rebuilding the file index if you use the Fluent Search indexer.

To enable: **Settings → Search → Experience**.

#### Search Delay

Control how quickly Fluent Search begins searching after you stop typing:

| Option | Behavior |
|---|---|
| **No Delay** | Results appear as you type every character |
| **Low** | Almost immediate — very short pause |
| **Medium** | Moderate delay after typing stops |
| **High** | Waits until you clearly finish typing |
| **Auto** | Fluent Search picks the best delay automatically |

There is also a **Zero Latency Mode** (available in advanced settings) that pushes results even faster at the cost of higher CPU usage. This mode may cause instability on lower-end systems.

#### Search Shortcuts (Text Mappings)

Search shortcuts let you map short input text to longer, predefined queries — reducing typing effort for frequent searches.

**Example:** Typing `mcd` can be automatically expanded to `my cool document`.

To configure:
1. Go to **Settings → Search → Experience → Search mappings**.
2. Enable the mappings feature.
3. Add your custom input → output text pairs.

You can also enable **Auto-create mappings** to let Fluent Search automatically generate shortcuts from your most popular searches.

---

### Search results

<img alt="Fluent Search Window" src="/docs/images/SearchGroupsLight.webp" width="600" height="auto">

#### Results Grouping

Group your results to make them easier to scan:

| Grouping Mode | Description |
|---|---|
| **Disabled** | No grouping — all results in a flat list (default) |
| **By Related App** | Groups results by which Search App produced them |
| **By Result Type** | Groups results by their content type (apps, files, web, etc.) |
| **Smart Grouping** | Uses an intelligent algorithm to organize results contextually |

You can also control when groups are expanded:

| Expand Mode | Description |
|---|---|
| **Disabled** | Groups stay collapsed — click to expand |
| **When Using a Tag** | Groups auto-expand when you're using a search tag (default) |
| **Always** | Groups are always expanded |

To configure: **Settings → Search → Results → Group search results**.

#### Maximum Results

- **Max search results** — The maximum number of results shown (default: 30, range: 1–200)
- **Max results per group** — When grouping is enabled, the max results within each group (default: 6, range: 1–99)

#### Delete Features

By default, Fluent Search allows deleting files and other items directly from search results (using `Delete` or `Shift + Delete`). If you prefer a safer experience, you can disable deletion features in **Settings → Search → Results**.

#### Result Display

- **Show result type labels** — Always display what type each result is (file, app, bookmark, etc.)
- **Minimalistic UI** — Hide extra text and result type information for a cleaner look
- **Show progress bar** — Display a progress indicator while search is running
- **Show operation shortcuts** — Display the keyboard shortcut next to each result action
- **Show result order icon** — Display a button to re-sort results on demand

---

### Search interactions

Control how the Fluent Search window behaves during and after searches:

| Setting | Description | Default |
|---|---|---|
| **Hide on losing focus** | Close the window when you click elsewhere | On |
| **Hide on search hotkey** | Close the window when pressing the search hotkey again | On |
| **Clear text on Escape** | Pressing Esc clears the search text instead of closing the window (when text is present) | Off |
| **Reset search when hidden** | Clear the search text and/or tags after the window has been hidden | Text and Tags |
| **Reset after seconds** | Time (in seconds) before an inactive search is automatically cleared | 30 |
| **Search copied text** | When opening Fluent Search, automatically search text that was recently copied to clipboard | On |
| **Single click to open** | Open results with a single click instead of double-click | Off |
| **Focus interaction** | Interact with results as you navigate them (for example, preview tabs as you arrow through them) | Off |

---

### Searching inside open apps

If you want to search inside open windows — for example, finding specific browser tabs, buttons, or links — enable **Search in app content** in the Windows Search App settings.

See [Search apps / Windows](Search%20apps/Windows.md) for details.

---

### Prioritizing search results

<img alt="Fluent Search Window" src="/docs/images/PrioritizationSettingsLight.webp" width="700" height="auto">

Fluent Search supports intelligent result ranking so the most relevant results appear first.

#### Machine Learning prioritization

By default, Fluent Search learns from your usage patterns and automatically promotes results you use frequently. This works across all Search Apps and requires no configuration.

To reset the learning data or disable ML-based prioritization: **Settings → Search → Prioritization**.

#### Custom prioritization rules

You can create manual rules to control result ordering:

- **By name** — Results matching specific names or patterns appear first
- **By context** — Prefer results from a specific folder or source
- **By search tag** — Prioritize results associated with certain tags
- **By Search App** — Prefer results from one Search App over another

Rules support wildcards, "starts with," and exact matching for flexible control.

#### Focused window prioritization

Enable **Prioritize results from focused window** to automatically boost results that are relevant to whatever application you're currently working in.

To configure: **Settings → Search → Prioritization**.

---

By fine-tuning these search options, you can make Fluent Search fit your exact workflow — fast, focused, and free of noise.

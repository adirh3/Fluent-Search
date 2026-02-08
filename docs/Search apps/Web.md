## Web Search App

<img alt="Fluent Search Search Tags Settings" src="/docs/images/GoogleWebSearchLight.webp" width="600" height="auto">

The **Web** Search App lets you perform web searches directly from Fluent Search and open the results in your browser. You can configure multiple search engines, create shortcuts for internal tools, and even preview web pages inline — turning quick lookups into a seamless part of your workflow.

---

### What it does

- **Search any web engine** — Google, Bing, DuckDuckGo, or any custom URL you configure
- **Open URLs directly** — type or paste a URL and Fluent Search recognizes it automatically
- **Preview web pages inline** — see a live web page preview right inside Fluent Search
- **Multiple simultaneous searches** — open results across several search engines at once
- **Web suggestions** — get auto-complete suggestions as you type from Google, Bing, DuckDuckGo, or a custom provider
- **ChatGPT integration** — send prompts to ChatGPT directly from Fluent Search

---

### Search Tags

| Tag | Description |
|---|---|
| `google` | Search Google (built-in) |
| `bing` | Search Bing (built-in) |
| `translate` | Google Translate (built-in) |
| `chatgpt` | Send a message to ChatGPT |
| `http` | Open a URL directly |
| *(custom search engines)* | Any search engines you add |
| *(browser search engines)* | Search engines imported from your browser profile (for example, YouTube, Wikipedia, Amazon) |

**To use:** Type the tag name → press **`Tab`** → type your query → press **`Enter`**.

**Example:** `google` + `Tab` → `best mechanical keyboards` → `Enter` opens the results in your browser.

---

### Adding custom search engines

1. Go to **Settings → Apps → Web → Web Searches**
2. Click **Add**
3. Provide:
   - **Name** — A label for the search engine (this also becomes the search tag)
   - **URL** — The search URL, using `%s` as a placeholder for your query

**Example URLs:**

| Engine | URL |
|---|---|
| Google | `https://www.google.com/search?q=%s` |
| DuckDuckGo | `https://duckduckgo.com/?q=%s` |
| GitHub | `https://github.com/search?q=%s` |
| Stack Overflow | `https://stackoverflow.com/search?q=%s` |
| Internal Wiki | `https://wiki.yourcompany.com/search?q=%s` |

**Tip:** Create search engines for your internal tools — wiki, issue tracker, documentation site, Jira, Confluence — so searching them becomes as fast as searching Google.

---

### Searching multiple engines at once

A single web search tag can open **multiple URLs simultaneously**:

1. In the search engine settings, enter multiple URLs separated by new lines
2. Each URL must contain the `%s` placeholder
3. When you use that tag and press `Enter`, all URLs open in separate browser tabs

**Example:** A "Compare prices" tag could open Google Shopping, Amazon, and eBay at the same time.

---

### Suggested search engines

Fluent Search provides quick-add templates for popular search engines:

- YouTube
- Amazon
- DuckDuckGo
- Google Images

You can add these with a single click from the Web Search settings page.

---

### Web suggestions

As you type, Fluent Search can show **auto-complete suggestions** from a web suggestion provider. Results update in real time.

Supported providers:
- **Google** (default)
- **Bing**
- **DuckDuckGo**
- **Custom URL** — provide a suggestion API endpoint using `%s` for the query

To configure: **Settings → Apps → Web → Default suggestion provider**.

---

### Web Preview

When a web search result or URL is selected, you can preview the page directly inside Fluent Search:

- Toggle inline preview with **`Alt + P`**
- Open in a separate preview window with **`Shift + Enter`**

Web preview configuration:

| Setting | Description | Default |
|---|---|---|
| **Automatically show preview** | Preview web results while searching | Off |
| **Show mobile websites** | Request mobile-optimized versions for a better preview experience | On |
| **Improve performance** | Use more memory for smoother web rendering | Off |
| **Open links in browser** | Clicked links open in your default browser | Off |
| **Default zoom** | Zoom level for the web preview (0.15× to 3×) | 1.0 |
| **Browser extensions** | Load unpacked browser extensions (like ad blockers) into the web preview | — |

---

### Result actions

| Action | Shortcut | Description |
|---|---|---|
| **Search** | `Enter` | Opens the search URL in your default browser |

---

### Settings

| Setting | Description | Default |
|---|---|---|
| **Web search tags** | Configure search engines with `%s` placeholder for query | Google, Bing, Translate |
| **Default suggestion provider** | Web auto-complete source | Google |
| **Custom suggestion provider URL** | Custom endpoint for suggestions | Empty |

To access: **Settings → Apps → Web**.

---

### Tips

- Keep 1–2 search engines "always on" (no tag required) and set others to tag-only to avoid cluttering results
- Create engines for your internal work tools so you can search them as fast as you search the public web
- The `chatgpt` tag lets you type a question and send it to ChatGPT without opening a browser tab
- If you frequently paste URLs into Fluent Search, it will automatically recognize them and offer to open them
- The web preview is great for quick lookups — preview a documentation page or article without switching to your browser

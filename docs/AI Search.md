# AI Search

Fluent Search includes a local **AI-powered semantic search** engine. When enabled, search results are ranked not just by keyword matching, but by **meaning** — so a search for "picture editor" can find "Photoshop," and "messaging app" can find "Discord."

All AI processing runs **locally on your device**. No data is sent to external servers.

---

## Setup

### Download the AI model

1. Go to **Settings → AI Settings**.
2. Click **Manage AI components** → **Download model**.
3. Choose a model:

| Model | Size | Languages |
|---|---|---|
| **English Only** | ~32 MB | English |
| **Multi Language** | ~117 MB | 100+ languages (Chinese, Japanese, Arabic, Hindi, European languages, and more) |

The download includes both the language model and the ONNX runtime. Files are stored in `%AppData%\Blast\AI\Embeddings\`.

After downloading, the model loads automatically. You can delete it later from the same button to free disk space.

---

## How it works

### Passive mode (default)

When AI search is enabled but the **AI search tag is not active**, Fluent Search operates in **cached-only mode**:

- Results that have been previously embedded (cached) get AI-boosted ranking
- No new AI inference runs during search — this keeps search instant
- The cache is pre-warmed with search tag names on startup

### Active mode (AI tag)

When you activate the **AI** search tag (type `AI` → `Tab`), Fluent Search switches to **full AI mode**:

- Embeddings are generated on-the-fly for all results
- Search delay is slightly increased to allow inference to complete
- Results are ranked by **semantic similarity** to your query

### Scoring

AI similarity scoring uses cosine similarity between your query and each result's text:

- AI scores are always **below** perfect text-match scores — exact keyword matches still rank highest
- A minimum similarity threshold (default 0.6) filters out weak matches
- This means AI enhances results without overriding strong text matches

---

## Summarize

When the AI model is loaded, a **Summarize** operation (✨) appears on file and browser tab results.

**How it works:**

1. Select a file or browser tab result
2. Click the **Summarize** operation
3. Fluent Search extracts the text content:
   - **Files:** Reads text from documents (supports Office, PDF, plain text via Windows IFilter)
   - **Web pages:** Downloads and extracts the article text
4. The AI selects the **6 most representative sentences** using Maximal Marginal Relevance
5. A summary panel appears with bullet-pointed key sentences

Summarization is **extractive** — it selects existing sentences rather than generating new text, so summaries are always faithful to the source.

---

## GPU acceleration

By default, AI inference runs on your **CPU**. You can enable **GPU acceleration** in Settings:

| Setting | Description |
|---|---|
| **Use GPU** | Uses DirectML (works on any DirectX 12 GPU — NVIDIA, AMD, Intel) |

GPU performance varies by hardware. On some systems it's faster; on others, CPU may be better. If GPU inference fails, Fluent Search automatically falls back to CPU.

The AI model runs in a **separate process** to isolate it from the main application — GPU driver issues won't crash Fluent Search.

---

## Settings

| Setting | Default | Description |
|---|---|---|
| **Disable all AI features** | Off | Completely turns off AI and hides the AI search tag |
| **Enable AI search** | On | Use AI for semantic result ranking |
| **Use GPU** | Off | Run inference on GPU instead of CPU |
| **Manage AI components** | — | Download, update, or delete the AI model |

---

## Resource usage

- **Memory:** The model increases memory usage while loaded. The English model uses less memory than the Multi Language model.
- **Disk:** 32 MB (English) or 117 MB (Multi Language) in `%AppData%\Blast\AI\Embeddings\`
- **CPU/GPU:** Brief spikes during inference. In cached-only mode (no AI tag active), there is minimal overhead.
- **Startup:** The model loads asynchronously on startup. A brief warm-up indexes common search tags.

---

## Tips

- **Start with cached mode** — leave the AI tag off for everyday use. You'll still benefit from AI-boosted ranking on previously seen results.
- **Use the AI tag** when searching by concept — for example, searching for "presentation software" to find PowerPoint.
- **English model** is smaller and faster. Use Multi Language only if you search in multiple languages.
- **GPU** is worth trying if you have a dedicated graphics card, but CPU works well for the small models Fluent Search uses.

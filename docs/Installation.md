## Installation and downloads

This page explains the available Fluent Search builds and package types, and how to install or switch between them.

---

## Choose your build

### Stable (recommended)

Stable builds are the default release channel.

- Download from the official website: https://fluentsearch.net (use the **Download** button)
- Or install from the Microsoft Store: https://www.microsoft.com/en-us/p/fluent-search/9nk1hlwhnp8s

### Nightly (previously called Alpha)

Nightly builds are updated frequently and are more likely to contain bugs. Use Nightly if you want early access to new features and you’re comfortable with occasional regressions.

#### Switch an existing install to Nightly

- Go to `Settings` > `System` > `Updates` > `Release feed` and select **Nightly**.

#### Download Nightly directly (without switching from Stable)

These links are the same as in the repo README:

| Package | x64 | ARM64 |
|---|---|---|
| **Windows Installer** | https://download.fluentsearch.net/fluent-search-daily/x64/Fluent-Search.exe | https://download.fluentsearch.net/fluent-search-daily/arm64/Fluent-Search.exe |
| **Windows APPX** | https://download.fluentsearch.net/fluent-search-daily/x64/FluentSearch.appx | https://download.fluentsearch.net/fluent-search-daily/arm64/FluentSearch.appx |
| **Portable** | https://download.fluentsearch.net/fluent-search-daily/x64/fluent-search-portable.zip | https://download.fluentsearch.net/fluent-search-daily/arm64/fluent-search-portable.zip |

---

## Choose your package type

### Windows Installer (.exe)

Best for most users.

- Installs like a normal Windows app
- Typically offers the smoothest integration and updating experience

### Windows APPX

A packaged install (often used for Store-style installs). Useful if you prefer that deployment model.

### Portable (.zip)

No install; runs from a folder.

- Good for trying Fluent Search quickly
- Settings/data live next to the executable (portable-style)

---

## Notes

- If you’re not sure which to pick: use **Stable + Installer**.
- Downgrading from Nightly back to Stable isn’t currently supported via the release feed. To go back to Stable, reinstall a Stable build (for example, from https://fluentsearch.net).

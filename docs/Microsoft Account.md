# Microsoft Account

Some Fluent Search features require signing in with a **Microsoft account**. This page explains which features need it, how to sign in, and what permissions are requested.

---

## Features that require a Microsoft account

| Feature | Permission | Description |
|---|---|---|
| [Microsoft To Do](Search%20apps/To%20Do.md) | `Tasks.ReadWrite` | Search, create, complete, and rename tasks |
| [Settings Sync](Settings%20Sync.md) | `Files.ReadWrite.AppFolder` | Sync settings and Tasks to OneDrive |
| Profile display | `user.read` | Show your name and profile photo in Settings |

---

## Sign in

You can sign in from any of these locations:

1. **Settings → System** — the Microsoft account control appears at the top of the settings page
2. **Settings → Sync** — the login button appears on the Sync settings page
3. **Settings → To Do** — the login button appears on the To Do settings page
4. **In search results** — when you search with the `todo` tag while not signed in, a "Login to Microsoft Account" result appears

Clicking sign in opens your **default browser** for the Microsoft OAuth login flow. After signing in, the browser returns you to Fluent Search.

---

## Sign out

Click **Sign Out** in **Settings → System** (next to your profile name). This removes all stored tokens and signs you out of all Microsoft-connected features.

---

## Token storage

Your authentication token is cached locally so you don't need to sign in every time Fluent Search launches. The token cache is stored in your app data directory and does not sync between devices — you'll need to sign in on each device separately.

---

## Privacy

- Fluent Search uses standard **Microsoft OAuth 2.0** authentication.
- Only the permissions listed above are requested — no access to email, calendar, contacts, or other Microsoft services.
- The `Files.ReadWrite.AppFolder` scope limits OneDrive access to Fluent Search's own app folder (`.Fluent_Search_Settings`) — it cannot read or modify your other OneDrive files.
- No data is sent to Fluent Search servers. All communication is directly between your device and Microsoft's APIs.

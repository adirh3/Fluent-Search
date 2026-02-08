## Calculator Search App

The **Calculator** Search App lets you perform quick calculations directly from Fluent Search. It's designed for lightweight math during your workflow — arithmetic, percentages, hexadecimal and binary conversions, and more — without opening a separate calculator application.

---

### What it does

Type a math expression into Fluent Search and the Calculator instantly evaluates it, showing the result directly in the search results list.

### Supported operations

| Feature | Example | Notes |
|---|---|---|
| **Basic arithmetic** | `1024 * 768`, `12.5 / 3` | Addition, subtraction, multiplication, division |
| **Percentages** | `15% of 2499`, `20% * 500` | Percentage calculations |
| **Parentheses** | `(100 + 50) * 2` | Grouping with parentheses |
| **Exponents** | `2^10` | Power operations |
| **Logarithms** | `log(100)` = 2, `ln(100)` ≈ 4.605 | `log()` is base-10, `ln()` is natural log (compatible with Windows Calculator) |
| **Trigonometry** | `sin(45)`, `cos(90)`, `tan(30)` | Standard trig functions |
| **Square root** | `sqrt(144)` | Square root |
| **Hexadecimal input** | `0xFF * 2` | Numbers prefixed with `0x` are parsed as hexadecimal |
| **Binary input** | `0b1010 + 5` | Numbers prefixed with `0b` are parsed as binary |
| **Hex/Binary output** | Any integer result | Results automatically show hex (`0x...`) and binary (`0b...`) equivalents |
| **The `x` operator** | `5 x 3` | The letter `x` is treated as multiplication |
| **Currency symbols** | `$100 + $50` | Currency characters are stripped before evaluation |
| **Locale-aware** | `1.000,50` or `1,000.50` | Handles both comma and period as decimal separators |

---

### Search Tags

| Tag | Description |
|---|---|
| `Calculator` | Activates calculator mode |

---

### Result actions

| Action | Description |
|---|---|
| **Calculate** | Evaluate the expression (copies result to clipboard) |
| **Copy** | Copy the result value |
| **Paste** | Paste from clipboard into the expression |

---

### Tips

- If you don't want calculations appearing in general search results, set Calculator to **Search Tag Only**. Then use `Calculator` + `Tab` when you need it.
- The hex and binary display is great for developers — type `0xFF` and instantly see its decimal equivalent, or type a decimal number and see the hex/binary forms in the result.
- Fluent Search uses the same logarithm convention as the Windows Calculator app: `log(x)` is log base 10, `ln(x)` is the natural logarithm.

### FormatDuration

Returns the human readable format of the given number of milliseconds.

---

- Divide `ms` with he appropriate values to obtain the values for `day`, `hour`, `minute`, `second` and `millisecond`, in a dictionary.
- Use Linq `Where`  to keep only non-zero values.
- Use Linq `Select` and `string.Format()` to create the string for each value, pluralizing appropriately.
- Use `string.Join(", ")` to combine the values into a string.

### C#

```csharp
 public static string FormatDuration(long ms)
        {
            if (ms < 0)
            {
                ms = -ms;
            }

            Dictionary<string, long> time = new()
            {
                { "day", (long)Math.Floor(ms / 86400000d) },
                { "hour", (long)Math.Floor(ms / 3600000d) % 24 },
                { "minute", (long)Math.Floor(ms / 60000d) % 60 },
                { "second", (long)Math.Floor(ms / 1000d) % 60 },
                { "millisecond", (long)Math.Floor((double)ms % 1000) }
            };

            return string.Join(", ",
                time
                .Where(val => val.Value != 0)
                .Select(val => string.Format("{0} {1}{2}", val.Value, val.Key, (val.Value != 1 ? "s" : "")))
                .ToArray());
        }
```

### Examples

```csharp
FormatDuration(1001);
//=> 1 second, 1 millisecond

FormatDuration(34325055574);
//=> 397 days, 6 hours, 44 minutes, 15 seconds, 574 milliseconds

FormatDuration(-894345);
//=> 14 minutes, 54 seconds, 345 milliseconds
```
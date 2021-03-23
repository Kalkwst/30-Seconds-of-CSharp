## GetColonTimeFromDate

Returns a string of the form `HH:mm:ss` from a `DateTime` object.

- Use the `ToString()` function using the `HH:mm:ss` pattern to get the time component.

### C#

```csharp
public static string GetColonTimeFromDate(DateTime time)
{
    return time.ToString("HH:mm:ss");
}
```

### Examples

```csharp
GetColonTimeFromDate(new DateTime(2020, 03, 15, 16, 32, 0));
//=> 16:32:00
```
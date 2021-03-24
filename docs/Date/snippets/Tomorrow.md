## Tomorrow

Return a string representation of tomorrow's date.

- Use `DateTime.Now` to get the current date.
- Increment it by one using `DateTime.AddDays` to get the next day.
- Use `DateTime.ToString()` to return a string in `yyyy-MM-dd` format.

### C#

```csharp
public static string Tommorow()
{
    return DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");
}
```

### Examples

```csharp
Tomorrow();
//=> 2020-03-24 (if current date is 2020-03-23)
```
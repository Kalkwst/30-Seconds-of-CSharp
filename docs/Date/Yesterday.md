## Yesterday

Return a string representation of yesterday's date.

- Use `DateTime.Now` to get the current date.
- Decrement it by one using `DateTime.AddDays` to get the previous day.
- Use `DateTime.ToString()` to return a string in `yyyy-MM-dd` format.

### C#

```csharp
public static string Yesterday()
{
    return DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd");
}
```

### Examples

```csharp
Yesterday();
//=> 2020-03-22 (if current date is 2020-03-23)
```
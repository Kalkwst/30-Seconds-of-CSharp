## IsAfterDate

Checks if a date is after another date.

- Use the greater than operator (`>`) to check if the first date comes before the second one.

### C#

```csharp
public static bool IsAfterDate(DateTime dateA, DateTime dateB)
{
    return dateA > dateB;
}
```

### Examples

```csharp
IsAfterDate(new DateTime(2012, 11, 21), new DateTime(2012, 11, 22));
//=> false

IsAfterDate(new DateTime(2021, 2, 12), new DateTime(1997, 12, 23));
//=> true
```
## IsBeforeDate

Checks if a date is before another date.

- Use the less than operator (`<`) to check if the first date comes before the second one.

### C#

```csharp
public static bool IsBeforeDate(DateTime dateA, DateTime dateB)
{
    return dateA < dateB;
}
```

### Examples

```csharp
IsBeforeDate(new DateTime(2012, 11, 21), new DateTime(2012, 11, 22));
//=> true

IsBeforeDate(new DateTime(2021, 2, 12), new DateTime(1997, 12, 23));
//=> false
```
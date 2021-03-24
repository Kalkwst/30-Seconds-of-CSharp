## IsBetweenDates

Checks if a date is between two other dates.

- Use the greater than (`>`) and less than (`<`) operators to check if the `date` is between
`dateStart` and `dateEnd`.

### C#

```csharp
public static bool IsBetweenDate(DateTime dateStart, DateTime dateEnd, DateTime date)
{
    return date > dateStart && date < dateEnd;
}
```

### Examples

```csharp
IsBetweenDate(
                new DateTime(2010, 11, 20),
                new DateTime(2010, 11, 30),
                new DateTime(2010, 11, 25));
//=> true

IsBetweenDate(
                new DateTime(2010, 11, 20),
                new DateTime(2010, 11, 30),
                new DateTime(2010, 11, 19));
//=> false
```
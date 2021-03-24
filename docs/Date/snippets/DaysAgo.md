## DaysAgo

Calculates the date of `n` days ago from today as a string representation.

- Use `Math.Abs()` to get the number of days to go back in time.
- In a `for` loop, use `DateTime.AddDays()` to remove a day from the provided `DateTime` object.

### C#

```csharp
public static DateTime DaysAgo(DateTime current, int count)
{
    int days = Math.Abs(count);

    for(int i = 0; i < days; i++)
    {
        current = current.AddDays(-1);
    }

    return current;
}
```

### Examples

```csharp
DaysAgo(new DateTime(2020, 03, 15), 5);
//=> 10/3/2020 12:00:00 am

DaysAgo(new DateTime(2020, 03, 15), 6);
//=> 09/3/2020 12:00:00 am
```
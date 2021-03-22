## AddWeekDays

Calculate the date after adding the given number of business days.

- Use a `for` loop to add the number of days in the current `DateTime` object
- Use a nested `do...while` loop to ignore `DayOfWeek.Saturday`, `DayOfWeek.Sunday` or provided holidays, by keep adding a day for each occurrence.

- **NOTE**: Does not work for negative number of days.

### C#

```csharp
public static DateTime AddWeekDays(DateTime startingDate, int count, IEnumerable<DateTime> holidays = null)
{
    var days = Math.Abs(count);

    for (int i = 0; i < days; i++)
    {
        do
        {
            startingDate = startingDate.AddDays(1);
        } while (
            startingDate.DayOfWeek == DayOfWeek.Saturday
            || startingDate.DayOfWeek == DayOfWeek.Sunday
            || holidays != null && holidays.Contains(startingDate.Date));
        }

        return startingDate;
    }
}
```

### Examples

```csharp
AddWeekDays(new DateTime(2021, 03, 01), 4);
//=> 5/3/2021 12:00:00 am

AddWeekDays(new DateTime(2021, 03, 01), 5);
//=> 8/3/2021 12:00:00 am

AddWeekDays(new DateTime(2021, 03, 01), 18, new List<DateTime>() { new DateTime(2021, 03, 25) });
//=> 26/3/2021 12:00:00 am
```
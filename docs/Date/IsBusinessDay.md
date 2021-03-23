## IsBusinessDay

Checks if the given date is a business day

- Check id the date is `DayOfWeek.Saturday`, `DayOfWeek.Sunday` or a provided holiday.

### C#

```csharp
public static bool IsBusinessDay(DateTime targetDate, IEnumerable<DateTime> holidays = null)
{
    return !(
           targetDate.DayOfWeek == DayOfWeek.Saturday
        || targetDate.DayOfWeek == DayOfWeek.Sunday
        || holidays != null && holidays.Contains(targetDate.Date));
}
```

### Examples

```csharp
IsBusinessDay(new DateTime(2019, 07, 19));
//=> true

IsBusinessDay(new DateTime(2021, 03, 06));
//=> false
```
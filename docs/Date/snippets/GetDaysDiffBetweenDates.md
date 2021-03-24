## GetDaysDiffBetweenDates

Calculates the difference (in days) between two dates.

- Subtract the two `DateTime` objects, and get the `TotalMilliseconds` component of the `TimeSpan`.
- Divide the `TotalMilliseconds` by the number of milliseconds in a day to get the difference (in days) between them.

### C#

```csharp
public static int GetDaysDiffBetweenDates(DateTime dateInitial, DateTime dateFinal)
{
    return (int)((long)(dateFinal - dateInitial).TotalMilliseconds / (1000 * 3600 * 24)); 
}
```

### Examples

```csharp
GetDaysDiffBetweenDates(new DateTime(2017, 12, 13), new DateTime(2017, 12, 22));
//=> 9
```
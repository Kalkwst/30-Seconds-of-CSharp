## Average

Calculates the average of two or more numbers.

- Use a `for` loop to add the result of `array[i]/array.Length` to an `avg` variable.
- Return the variable

### C#

```csharp
public static double Average(params int[] array)
{
    double avg = 0
    for(int i = 0; i < array.Length; i++)
    {
        avg += (double)array[i] / array.Length;
    
    return avg;
}
```

```csharp
public static double Average(params long[] array)
{
    double avg = 0;

    for(int i = 0; i < array.Length; i++)
    {
        avg += (double)array[i] / array.Length;
    }

    return avg;
}
``` 

```csharp
public static decimal Average(params decimal[] array)
{
    decimal avg = 0;
    for (int i = 0; i < array.Length; i++)
    {
        avg += array[i] / array.Length;
    
    return avg;
}
```

```csharp
public static double Average(params double[] array)
{
    double avg = 0;
    for (int i = 0; i < array.Length; i++)
    {
        avg += array[i] / array.Length;
    
    return avg;
}
```

### Examples

```csharp
MathUtils.Average(0);
//=> 0

MathUtils.Average(1, 2, 3, 4, 5);
//=> 3.0

MathUtils.Average(-1, -2, -3);
//=> 2.0
```

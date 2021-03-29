## Arithmetic Progression

Creates an array of numbers in the arithmetic progression, starting with a given positive integer
and up to the specified limit.

- Use `(int)Math.Ceiling((double)lim / n)` to calculate the size of the array.
- Use a `for` loop and append the result of `i * n` in the array.

### C#

```csharp
public static int[] ArithmeticProgression(int n, int lim)
{
    int[] array = new int[(int)Math.Ceiling((double)lim / n)];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = (i + 1) * n;
    }
    return array;
}
```

```csharp
public static long[] ArithmeticProgression(long n, long lim)
{
    long[] array = new long[(long)Math.Ceiling((double)lim / n)];
    for (long i = 0; i < array.Length; i++)
    {
        array[i] = (i + 1) * n;
    }
    return array;
}
```

```csharp
public static decimal[] ArithmeticProgression(decimal n, decimal lim)
{
    decimal[] array = new decimal[(int)Math.Ceiling(lim / n)];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = (i + 1) * n;
    }
    return array;
}
```

```csharp
public static double[] ArithmeticProgression(double n, double lim)
{
    double[] array = new double[(int)Math.Ceiling(lim / n)];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = (i + 1) * n;
    }
    return array;
}
```

### Examples

```csharp
ArithmeticProgression(5, 25);
//=> [5, 10, 15, 20, 25]
```
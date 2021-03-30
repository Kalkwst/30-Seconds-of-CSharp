## BinomialCoefficient

Calculates the number of ways to choose `k` items from `n` items without repetition and
without order.

- Check if `k` is less than `0`, greater than or equal to `n`, equal to `1` or `n-1` and return
the appropriate result.
- Check if `n-k` is less than `k` and switch ther values accordingly.
- Loop from `2` to `k` and calculate the binomial coefficient.
- Use `Math.Round()` to account for rounding errors in the calculation.

### C#

```csharp
public static int BinomialCoefficient(int n, int k)
{
    if (k < 0 || k > n)
        return 0;
    if (k == 0 || k == n)
        return 1;
    if (k == 1 || k == n - 1)
        return n;
    if (n - k < k)
        k = n - k;
    double res = (double)n;
    for (int i = 2; i <= k; i++)
        res *= (double)(n - i + 1) / i;
    return (int)Math.Round(res);
}
```

### Examples

```csharp
BinomialCoefficient(32, 7);
//=> 3365856
```
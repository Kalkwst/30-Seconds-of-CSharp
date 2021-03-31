## ClampNumber

Clamps `num` within the inclusive range specified by the boundary values `lower` and `upper`.

- Use `Math.Min()` and `Math.Max()` to determine if `num` falls within range.
- If `num` falls within range, return `num`.
- Otherwise, return the nearest number in the range.

### C#

```csharp
public static int ClampNumber(int num, int lower, int upper)
{
    return Math.Max(Math.Min(num, Math.Max(lower, upper)), Math.Min(lower, upper));
}
```

```csharp
public static long ClampNumber(long num, long lower, long upper)
{
    return Math.Max(Math.Min(num, Math.Max(lower, upper)), Math.Min(lower, upper));
}
```

```csharp
public static float ClampNumber(float num, float lower, float upper)
{
    return Math.Max(Math.Min(num, Math.Max(lower, upper)), Math.Min(lower, upper));
}
```

```csharp
public static double ClampNumber(double num, double lower, double upper)
{
    return Math.Max(Math.Min(num, Math.Max(lower, upper)), Math.Min(lower, upper));
}
```

```csharp
public static decimal ClampNumber(decimal num, decimal lower, decimal upper)
{
    return Math.Max(Math.Min(num, Math.Max(lower, upper)), Math.Min(lower, upper));
}
```

### Examples

```csharp
ClampNumber(2, 3, 5);
//=> 3

ClampNumber(1, -1, -5);
//=> -1
```
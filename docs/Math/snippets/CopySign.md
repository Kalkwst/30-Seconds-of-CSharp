## CopySign

Returns the absolute value of the first number, but the sign of the second.

- Use `Math.Sign()` to check if the two numbers have the same sign.
- Return `x` if they do, `-x` otherwise.

### C#

```csharp
public static int CopySign(int x, int y)
{
    return Math.Sign(x) == Math.Sign(y) ? x : -x;
}
```

```csharp
public static long CopySign(long x, long y)
{
    return Math.Sign(x) == Math.Sign(y) ? x : -x;
}
```

```csharp
public static float CopySign(float x, float y)
{
    return Math.Sign(x) == Math.Sign(y) ? x : -x;
}
```

```csharp
public static double CopySign(double x, double y)
{
    return Math.Sign(x) == Math.Sign(y) ? x : -x;
}
```

```csharp
public static decimal CopySign(decimal x, decimal y)
{
    return Math.Sign(x) == Math.Sign(y) ? x : -x;
}
```

### Examples

```csharp
CopySign(2, 3);
//=> 2

CopySign(2, -3);
//=> -2

CopySign(-2, 3);
//=> 2

CopySign(-2, -3);
//=> -2
```
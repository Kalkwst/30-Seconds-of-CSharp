## Distance

Calculates the distance between two points in a 2D plane.

- Use `Math.Pow()` and `Math.Sqrt()` to calculate the Euclidean distance between two points.

### C#

```csharp
public static double Distance(double x0, double y0, double x1, double y1)
{
    return Math.Sqrt(Math.Pow((x0 - x1), 2) + Math.Pow((y0 - y1), 2));
}
```

### Example

```csharp
MathUtils.Distance(1, 1, 2, 3);
//=> ~2.2361
```
## DegreesToRads

Converts an angle from degrees to radians.

- Use `Math.PI` and the degree to radian formula to convert the angle from degrees to
radians.

### C#

```csharp
public static double DegreesToRads(double degrees)
{
    return (degrees * Math.PI) / 180.0;
}
```

### Examples

```csharp
DegreesToRads(0);
//=> 0

DegreesToRads(90);
//=> ~1.570

DegreesToRads(180);
//=> ~3.1415

DegreesToRads(360);
//=> ~6.283
```
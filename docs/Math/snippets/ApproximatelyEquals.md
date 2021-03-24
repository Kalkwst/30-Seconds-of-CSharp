## ApproximatelyEquals

Checks if two numbers are approximately equal to each other.

- Use `Math.Abs()` to compare the absolute difference of the two values to `epsilon`.
- Omit the third argument, `epsilon`, to use a default value of `0.001`.

### C#

```csharp
public static bool ApproximatelyEqual(double num1, double num2, double epsilon = 0.001)
{
    return Math.Abs(num1 - num2) < epsilon;
}
```

### Examples

```csharp
ApproximatelyEqual(Math.PI / 2.0, 1.5708);
//=> true
```
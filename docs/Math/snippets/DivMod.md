## DivMod

Returns an array consisting of the quotient and remainder of the given
numbers.

- Use `Math.Floor()` to get the quotient of the division `x / y`.
- Use the modulo operator (`%`) to get the remainder of the division `x / y`.

### C#

```csharp
public static int[] DivMod(int x, int y)
{
    return new int[] { (int)Math.Floor((double)x / (double)y), x % y };
}
```

### Examples

```csharp
DivMod(8, 3);
//=> [2, 2]

DivMod(2, 8);
//=> [0, 3]

DivMod(5, 5);
//=> [1, 0]
```
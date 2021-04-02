## Factorial

Calculates the factorial of a number.

- If `n` is less than or equal to `1`, return `1`.
- Otherwise, return the product of `n` and the factorial of `n-1` recursively.
- Throw an `ArgumentException` if `n` is a negative number.

### C#

```csharp
public static long Factorial(int number)
{
    return number < 0
        ? throw new ArgumentException("Negative numbers are not allowed")
        : number <= 1
        ? 1
        : number * Factorial(number - 1);
}
```

### Examples

```csharp
Factorial(6);
//=> 720
```
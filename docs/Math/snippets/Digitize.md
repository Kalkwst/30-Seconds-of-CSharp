## Digitize

Converts a number to an array of digits, removing its sign if necessary.

- Use `Math.Abs()` to strip the number's sign.
- Convert the number to an array of strings using `ToString()`, `ToCharArray()` and `Linq.Select()`.
- Use a `for` loop and transform each digit from string to int, with `Int32.Parse()`.

### C#

```csharp
public static int[] Digitize(int number)
{
    string[] digits = Math.Abs(number).ToString().ToCharArray().Select(c => c.ToString()).ToArray();
    int[] result = new int[digits.Length];

    for(int i = 0; i < digits.Length; i++)
    {
        result[i] = Int32.Parse(digits[i]);
    }

    return result;
}
```

### Examples

```csharp
Digitize(123);
//=> [1, 2, 3]

Digitize(-123);
//=> [1, 2, 3]
```
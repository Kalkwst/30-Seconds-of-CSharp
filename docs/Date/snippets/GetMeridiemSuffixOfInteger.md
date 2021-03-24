## GetMeridiemSuffixOfInteger

Converts an integer to a suffixed string, adding `am` or `pm` based on its value.

- Use the modulo operator (`%`) and conditional checks to transform an integer to a stringified 12-hour format with meridiem suffix.

### C#

```csharp
public static string GetMeridiemSuffixOfInteger(int num)
{
    return num == 0 || num == 24
        ? 12 + " am"
        : num == 12
        ? 12 + " pm"
        : num < 12
        ? (num % 12) + " am"
        : (num % 12) + " pm";
}
```

### Examples

```csharp
GetMeridiemSuffixOfInteger(0);
//=> 12 am

GetMeridiemSuffixOfInteger(11);
//=> 11 am

GetMeridiemSuffixOfInteger(13);
//=> 1 pm

GetMeridiemSuffixOfInteger(25);
//=> 1 pm
```
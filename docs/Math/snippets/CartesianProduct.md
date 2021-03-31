## CartesianProduct

Calculates the cartesian product of two given arrays.

- Create a `List` that will contain each element pairs from the two arrays.
- Use two `for` loops to loop through each element of each array and generate an element pair.

### C#

```csharp
public static List<T[]> CartesianProduct<T>(T[] a, T[] b)
{
    List<T[]> product = new();
    for(int i = 0; i < a.Length; i++)
    {
        for(int j = 0; j < b.Length; j++)
        {
            T[] tmp = { a[i], b[j] };
            product.Add(tmp);
        }
    }
    return product;
}
```

### Examples

```csharp
CartesianProduct([1, 2, 3],[1, 2, 3]);
//=> [[1, 1], [1, 2], [1, 3], [2, 1], [2, 2], [2,3], [3, 1], [3, 2], [3, 3]]
```
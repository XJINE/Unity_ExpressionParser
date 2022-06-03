# Unity_ExpressionParser

ExpressionParser is simple implementation to parse expression into float value with ``DataTable``.

```csharp
public static class ExpressionParser
{
    private static readonly DataTable DataTable = new ();

    public static (bool success, float value) Parse(string expression)
    {
        try   { return (true, Convert.ToSingle(DataTable.Compute(expression, ""))); }
        catch { return (false, float.NaN); }
    }
}
```

## Importing

You can use Package Manager or import it directly.

```
https://github.com/XJINE/Unity_ExpressionParser.git?path=Assets/Packages/ExpressionParser
```
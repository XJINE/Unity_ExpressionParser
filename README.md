# Unity_ExpressionParser

ExpressionParser is simple implemantation to parse expression into float value with ``DataTable``.

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

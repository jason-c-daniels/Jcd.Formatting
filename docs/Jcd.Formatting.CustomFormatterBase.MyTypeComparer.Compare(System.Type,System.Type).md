### [Jcd.Formatting](Jcd.Formatting.md 'Jcd.Formatting').[CustomFormatterBase](Jcd.Formatting.CustomFormatterBase.md 'Jcd.Formatting.CustomFormatterBase').[MyTypeComparer](Jcd.Formatting.CustomFormatterBase.MyTypeComparer.md 'Jcd.Formatting.CustomFormatterBase.MyTypeComparer')

## CustomFormatterBase.MyTypeComparer.Compare(Type, Type) Method

Performs a comparison between two types.

```csharp
public int Compare(System.Type x, System.Type y);
```
#### Parameters

<a name='Jcd.Formatting.CustomFormatterBase.MyTypeComparer.Compare(System.Type,System.Type).x'></a>

`x` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

the left side of the comparison

<a name='Jcd.Formatting.CustomFormatterBase.MyTypeComparer.Compare(System.Type,System.Type).y'></a>

`y` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

the right ride of the comparison

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
-1 if x is less than y, 1 if x is greater than y, 0 if equal.
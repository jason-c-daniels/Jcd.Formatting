### [Jcd.Formatting](Jcd_Formatting.md 'Jcd.Formatting').[CustomFormatterBase](Jcd_Formatting_CustomFormatterBase.md 'Jcd.Formatting.CustomFormatterBase').[MyTypeComparer](Jcd_Formatting_CustomFormatterBase_MyTypeComparer.md 'Jcd.Formatting.CustomFormatterBase.MyTypeComparer')
## CustomFormatterBase.MyTypeComparer.Compare(Type, Type) Method
Performs a comparison between two types.  
```csharp
public int Compare(System.Type x, System.Type y);
```
#### Parameters
<a name='Jcd_Formatting_CustomFormatterBase_MyTypeComparer_Compare(System_Type_System_Type)_x'></a>
`x` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
the elft side of the comparison
  
<a name='Jcd_Formatting_CustomFormatterBase_MyTypeComparer_Compare(System_Type_System_Type)_y'></a>
`y` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
the right ride of the comparison
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
-1 if x is less than y, 1 if x is greater than y, 0 if equal.

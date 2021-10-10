### [Jcd.Formatting](Jcd_Formatting.md 'Jcd.Formatting').[CustomFormatterBase](Jcd_Formatting_CustomFormatterBase.md 'Jcd.Formatting.CustomFormatterBase')
## CustomFormatterBase.GetFormat(Type) Method
Returns an object that provides formatting services for the specified type.
```csharp
public virtual object GetFormat(System.Type formatType);
```
#### Parameters
<a name='Jcd_Formatting_CustomFormatterBase_GetFormat(System_Type)_formatType'></a>
`formatType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
An object that specifies the type of format object to return. 
  
#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
An instance of the object specified by [formatType](Jcd_Formatting_CustomFormatterBase_GetFormat(System_Type).md#Jcd_Formatting_CustomFormatterBase_GetFormat(System_Type)_formatType 'Jcd.Formatting.CustomFormatterBase.GetFormat(System.Type).formatType'), if the [System.IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IFormatProvider 'System.IFormatProvider') implementation can supply that type of object; otherwise, null.

Implements [GetFormat(Type?)](https://docs.microsoft.com/en-us/dotnet/api/System.IFormatProvider.GetFormat#System_IFormatProvider_GetFormat_System_Type_ 'System.IFormatProvider.GetFormat(System.Type)')  

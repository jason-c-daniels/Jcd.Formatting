### [Jcd.Formatting](Jcd_Formatting.md 'Jcd.Formatting').[CustomFormatterBase](Jcd_Formatting_CustomFormatterBase.md 'Jcd.Formatting.CustomFormatterBase')
## CustomFormatterBase.CustomFormattingFunction(ICustomFormatter, string, object, IFormatProvider) Delegate
This is the signature which custom formatting functions must abide by.  
```csharp
public delegate string CustomFormatterBase.CustomFormattingFunction(System.ICustomFormatter customFormatter, string formatString, object argToFormat, System.IFormatProvider formatProvider);
```
#### Parameters
<a name='Jcd_Formatting_CustomFormatterBase_CustomFormattingFunction(System_ICustomFormatter_string_object_System_IFormatProvider)_customFormatter'></a>
`customFormatter` [System.ICustomFormatter](https://docs.microsoft.com/en-us/dotnet/api/System.ICustomFormatter 'System.ICustomFormatter')  
The custom formatter object.
  
<a name='Jcd_Formatting_CustomFormatterBase_CustomFormattingFunction(System_ICustomFormatter_string_object_System_IFormatProvider)_formatString'></a>
`formatString` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
the format string.
  
<a name='Jcd_Formatting_CustomFormatterBase_CustomFormattingFunction(System_ICustomFormatter_string_object_System_IFormatProvider)_argToFormat'></a>
`argToFormat` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The item to format.
  
<a name='Jcd_Formatting_CustomFormatterBase_CustomFormattingFunction(System_ICustomFormatter_string_object_System_IFormatProvider)_formatProvider'></a>
`formatProvider` [System.IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IFormatProvider 'System.IFormatProvider')  
The format provider.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  

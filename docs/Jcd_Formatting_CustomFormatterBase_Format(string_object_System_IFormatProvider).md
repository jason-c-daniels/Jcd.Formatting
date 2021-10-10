### [Jcd.Formatting](Jcd_Formatting.md 'Jcd.Formatting').[CustomFormatterBase](Jcd_Formatting_CustomFormatterBase.md 'Jcd.Formatting.CustomFormatterBase')
## CustomFormatterBase.Format(string, object, IFormatProvider) Method
Converts the value of a specified object to an equivalent string representation using specified format and culture-specific formatting information.
```csharp
public virtual string Format(string fmt, object arg, System.IFormatProvider formatProvider);
```
#### Parameters
<a name='Jcd_Formatting_CustomFormatterBase_Format(string_object_System_IFormatProvider)_fmt'></a>
`fmt` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
  
<a name='Jcd_Formatting_CustomFormatterBase_Format(string_object_System_IFormatProvider)_arg'></a>
`arg` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
An object to format. 
  
<a name='Jcd_Formatting_CustomFormatterBase_Format(string_object_System_IFormatProvider)_formatProvider'></a>
`formatProvider` [System.IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IFormatProvider 'System.IFormatProvider')  
An object that supplies format information about the current instance. 
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The string representation of the value of [arg](Jcd_Formatting_CustomFormatterBase_Format(string_object_System_IFormatProvider).md#Jcd_Formatting_CustomFormatterBase_Format(string_object_System_IFormatProvider)_arg 'Jcd.Formatting.CustomFormatterBase.Format(string, object, System.IFormatProvider).arg'), formatted as specified by format and [formatProvider](Jcd_Formatting_CustomFormatterBase_Format(string_object_System_IFormatProvider).md#Jcd_Formatting_CustomFormatterBase_Format(string_object_System_IFormatProvider)_formatProvider 'Jcd.Formatting.CustomFormatterBase.Format(string, object, System.IFormatProvider).formatProvider').

Implements [Format(string?, object?, IFormatProvider?)](https://docs.microsoft.com/en-us/dotnet/api/System.ICustomFormatter.Format#System_ICustomFormatter_Format_System_String,System_Object,System_IFormatProvider_ 'System.ICustomFormatter.Format(System.String,System.Object,System.IFormatProvider)')  

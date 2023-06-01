### [Jcd.Formatting](Jcd_Formatting.md 'Jcd.Formatting').[CustomFormatterBase](Jcd_Formatting_CustomFormatterBase.md 'Jcd.Formatting.CustomFormatterBase')
## CustomFormatterBase.CustomFormatterBase(IEnumerable&lt;Type&gt;, Func&lt;ICustomFormatter,string,object,IFormatProvider,string&gt;) Constructor
Constructs a custom formatter, and enforces some common rules.  
```csharp
protected CustomFormatterBase(System.Collections.Generic.IEnumerable<System.Type> handledTypes, System.Func<System.ICustomFormatter,string,object,System.IFormatProvider,string> formatFunction);
```
#### Parameters
<a name='Jcd_Formatting_CustomFormatterBase_CustomFormatterBase(System_Collections_Generic_IEnumerable_System_Type__System_Func_System_ICustomFormatter_string_object_System_IFormatProvider_string_)_handledTypes'></a>
`handledTypes` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The data types the derived type will handle.
  
<a name='Jcd_Formatting_CustomFormatterBase_CustomFormatterBase(System_Collections_Generic_IEnumerable_System_Type__System_Func_System_ICustomFormatter_string_object_System_IFormatProvider_string_)_formatFunction'></a>
`formatFunction` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.ICustomFormatter](https://docs.microsoft.com/en-us/dotnet/api/System.ICustomFormatter 'System.ICustomFormatter')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IFormatProvider 'System.IFormatProvider')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')  
The formatting function, provided by the derived type, abiding by the  
CustomFormattingFunction signature  
  

### [Jcd.Formatting](Jcd.Formatting.md 'Jcd.Formatting').[CustomFormatterBase](Jcd.Formatting.CustomFormatterBase.md 'Jcd.Formatting.CustomFormatterBase')

## CustomFormatterBase(IEnumerable<Type>, Func<ICustomFormatter,string,object,IFormatProvider,string>) Constructor

Constructs a custom formatter, and enforces some common rules.

```csharp
protected CustomFormatterBase(System.Collections.Generic.IEnumerable<System.Type> handledTypes, System.Func<System.ICustomFormatter,string,object,System.IFormatProvider,string> formatFunction);
```
#### Parameters

<a name='Jcd.Formatting.CustomFormatterBase.CustomFormatterBase(System.Collections.Generic.IEnumerable_System.Type_,System.Func_System.ICustomFormatter,string,object,System.IFormatProvider,string_).handledTypes'></a>

`handledTypes` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The data types the derived type will handle.

<a name='Jcd.Formatting.CustomFormatterBase.CustomFormatterBase(System.Collections.Generic.IEnumerable_System.Type_,System.Func_System.ICustomFormatter,string,object,System.IFormatProvider,string_).formatFunction'></a>

`formatFunction` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.ICustomFormatter](https://docs.microsoft.com/en-us/dotnet/api/System.ICustomFormatter 'System.ICustomFormatter')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IFormatProvider 'System.IFormatProvider')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')

The formatting function, provided by the derived type, abiding by the
CustomFormattingFunction signature
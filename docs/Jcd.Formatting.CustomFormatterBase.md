### [Jcd.Formatting](Jcd.Formatting.md 'Jcd.Formatting')

## CustomFormatterBase Class

```csharp
public abstract class CustomFormatterBase :
System.IFormatProvider,
System.ICustomFormatter
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; CustomFormatterBase

Derived
&#8627; [IntegerEncoder](Jcd.Formatting.IntegerEncoder.md 'Jcd.Formatting.IntegerEncoder')

Implements [System.IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IFormatProvider 'System.IFormatProvider'), [System.ICustomFormatter](https://docs.microsoft.com/en-us/dotnet/api/System.ICustomFormatter 'System.ICustomFormatter')

| Constructors | |
| :--- | :--- |
| [CustomFormatterBase(IEnumerable&lt;Type&gt;, Func&lt;ICustomFormatter,string,object,IFormatProvider,string&gt;)](Jcd.Formatting.CustomFormatterBase.CustomFormatterBase(System.Collections.Generic.IEnumerable_System.Type_,System.Func_System.ICustomFormatter,string,object,System.IFormatProvider,string_).md 'Jcd.Formatting.CustomFormatterBase.CustomFormatterBase(System.Collections.Generic.IEnumerable<System.Type>, System.Func<System.ICustomFormatter,string,object,System.IFormatProvider,string>)') | Constructs a custom formatter, and enforces some common rules. |

| Fields | |
| :--- | :--- |
| [TypeComparer](Jcd.Formatting.CustomFormatterBase.TypeComparer.md 'Jcd.Formatting.CustomFormatterBase.TypeComparer') | Default type comparison |

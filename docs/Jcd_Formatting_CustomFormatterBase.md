### [Jcd.Formatting](Jcd_Formatting.md 'Jcd.Formatting')
## CustomFormatterBase Class
Provides a mechanism for retrieving an object to control formatting.
```csharp
public abstract class CustomFormatterBase :
System.IFormatProvider,
System.ICustomFormatter
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; CustomFormatterBase  

Derived  
&#8627; [IntegerEncoder](Jcd_Formatting_IntegerEncoder.md 'Jcd.Formatting.IntegerEncoder')  

Implements [System.IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IFormatProvider 'System.IFormatProvider'), [System.ICustomFormatter](https://docs.microsoft.com/en-us/dotnet/api/System.ICustomFormatter 'System.ICustomFormatter')  

| Constructors | |
| :--- | :--- |
| [CustomFormatterBase(IEnumerable&lt;Type&gt;, Func&lt;ICustomFormatter,string,object,IFormatProvider,string&gt;)](Jcd_Formatting_CustomFormatterBase_CustomFormatterBase(System_Collections_Generic_IEnumerable_System_Type__System_Func_System_ICustomFormatter_string_object_System_IFormatProvider_string_).md 'Jcd.Formatting.CustomFormatterBase.CustomFormatterBase(System.Collections.Generic.IEnumerable&lt;System.Type&gt;, System.Func&lt;System.ICustomFormatter,string,object,System.IFormatProvider,string&gt;)') | Constructs a custom formatter, and enforces some common rules.<br/> |

| Fields | |
| :--- | :--- |
| [TypeComparer](Jcd_Formatting_CustomFormatterBase_TypeComparer.md 'Jcd.Formatting.CustomFormatterBase.TypeComparer') | Default type comparison<br/> |

| Methods | |
| :--- | :--- |
| [Format(string, object, IFormatProvider)](Jcd_Formatting_CustomFormatterBase_Format(string_object_System_IFormatProvider).md 'Jcd.Formatting.CustomFormatterBase.Format(string, object, System.IFormatProvider)') | Converts the value of a specified object to an equivalent string representation using specified format and culture-specific formatting information. |
| [GetFormat(Type)](Jcd_Formatting_CustomFormatterBase_GetFormat(System_Type).md 'Jcd.Formatting.CustomFormatterBase.GetFormat(System.Type)') | Returns an object that provides formatting services for the specified type. |

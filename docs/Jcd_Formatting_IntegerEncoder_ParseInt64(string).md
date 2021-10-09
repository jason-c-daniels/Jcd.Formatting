### [Jcd.Formatting](Jcd_Formatting.md 'Jcd.Formatting').[IntegerEncoder](Jcd_Formatting_IntegerEncoder.md 'Jcd.Formatting.IntegerEncoder')
## IntegerEncoder.ParseInt64(string) Method
Parses a string as an Int64  
```csharp
public long ParseInt64(string value);
```
#### Parameters
<a name='Jcd_Formatting_IntegerEncoder_ParseInt64(string)_value'></a>
`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The text to decode
  
#### Returns
[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')  
the decoded value
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
If the value parameter was null
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
If the text is empty or whitespace.  
[System.OverflowException](https://docs.microsoft.com/en-us/dotnet/api/System.OverflowException 'System.OverflowException')  
If the text cannot be parse because the resultant value can't be stored in an Int64  
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
If the provided characters cannot be decoded per the current encoding..  

Implements [ParseInt64(string)](Jcd_Formatting_IIntegerParser_ParseInt64(string).md 'Jcd.Formatting.IIntegerParser.ParseInt64(string)')  

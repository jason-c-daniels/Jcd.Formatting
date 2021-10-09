### [Jcd.Formatting](Jcd_Formatting.md 'Jcd.Formatting').[IntegerEncoder](Jcd_Formatting_IntegerEncoder.md 'Jcd.Formatting.IntegerEncoder')
## IntegerEncoder.ParseByte(string) Method
Parses a string as a Byte  
```csharp
public byte ParseByte(string value);
```
#### Parameters
<a name='Jcd_Formatting_IntegerEncoder_ParseByte(string)_value'></a>
`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The text to decode
  
#### Returns
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')  
the decoded value
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
If the value parameter was null
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
If the text is empty or whitespace.  
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
If the provided characters cannot be decoded per the current encoding..  
[System.OverflowException](https://docs.microsoft.com/en-us/dotnet/api/System.OverflowException 'System.OverflowException')  
If the text cannot be parse because the resultant value can't be stored in a Byte  

Implements [ParseByte(string)](Jcd_Formatting_IIntegerParser_ParseByte(string).md 'Jcd.Formatting.IIntegerParser.ParseByte(string)')  

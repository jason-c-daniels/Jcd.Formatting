### [Jcd.Formatting](Jcd_Formatting.md 'Jcd.Formatting').[IntegerEncoder](Jcd_Formatting_IntegerEncoder.md 'Jcd.Formatting.IntegerEncoder')
## IntegerEncoder.TryParseBigInteger(string, BigInteger) Method
Tries to parse a BigInteger from the provided text.  
```csharp
public bool TryParseBigInteger(string value, out System.Numerics.BigInteger result);
```
#### Parameters
<a name='Jcd_Formatting_IntegerEncoder_TryParseBigInteger(string_System_Numerics_BigInteger)_value'></a>
`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
the text to parse
  
<a name='Jcd_Formatting_IntegerEncoder_TryParseBigInteger(string_System_Numerics_BigInteger)_result'></a>
`result` [System.Numerics.BigInteger](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.BigInteger 'System.Numerics.BigInteger')  
the resultant value
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
true if successfully parsed, false otherwise

Implements [TryParseBigInteger(string, BigInteger)](Jcd_Formatting_IIntegerParser_TryParseBigInteger(string_System_Numerics_BigInteger).md 'Jcd.Formatting.IIntegerParser.TryParseBigInteger(string, System.Numerics.BigInteger)')  

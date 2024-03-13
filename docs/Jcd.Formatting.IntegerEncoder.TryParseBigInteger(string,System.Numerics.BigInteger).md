### [Jcd.Formatting](Jcd.Formatting.md 'Jcd.Formatting').[IntegerEncoder](Jcd.Formatting.IntegerEncoder.md 'Jcd.Formatting.IntegerEncoder')

## IntegerEncoder.TryParseBigInteger(string, BigInteger) Method

Tries to parse a BigInteger from the provided text.

```csharp
public bool TryParseBigInteger(string value, out System.Numerics.BigInteger result);
```
#### Parameters

<a name='Jcd.Formatting.IntegerEncoder.TryParseBigInteger(string,System.Numerics.BigInteger).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the text to parse

<a name='Jcd.Formatting.IntegerEncoder.TryParseBigInteger(string,System.Numerics.BigInteger).result'></a>

`result` [System.Numerics.BigInteger](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.BigInteger 'System.Numerics.BigInteger')

the resultant value

Implements [TryParseBigInteger(string, BigInteger)](Jcd.Formatting.IIntegerParser.TryParseBigInteger(string,System.Numerics.BigInteger).md 'Jcd.Formatting.IIntegerParser.TryParseBigInteger(string, System.Numerics.BigInteger)')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
true if successfully parsed, false otherwise
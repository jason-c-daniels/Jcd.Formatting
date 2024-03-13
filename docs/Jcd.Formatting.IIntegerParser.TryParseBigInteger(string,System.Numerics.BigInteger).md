### [Jcd.Formatting](Jcd.Formatting.md 'Jcd.Formatting').[IIntegerParser](Jcd.Formatting.IIntegerParser.md 'Jcd.Formatting.IIntegerParser')

## IIntegerParser.TryParseBigInteger(string, BigInteger) Method

Tries to parse a BigInteger from the provided text.

```csharp
bool TryParseBigInteger(string value, out System.Numerics.BigInteger result);
```
#### Parameters

<a name='Jcd.Formatting.IIntegerParser.TryParseBigInteger(string,System.Numerics.BigInteger).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the text to parse

<a name='Jcd.Formatting.IIntegerParser.TryParseBigInteger(string,System.Numerics.BigInteger).result'></a>

`result` [System.Numerics.BigInteger](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.BigInteger 'System.Numerics.BigInteger')

the resultant value

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
true if successfully parsed, false otherwise
### [Jcd.Formatting](Jcd.Formatting.md 'Jcd.Formatting').[IntegerEncoder](Jcd.Formatting.IntegerEncoder.md 'Jcd.Formatting.IntegerEncoder')

## IntegerEncoder.TryParseSByte(string, sbyte) Method

Tries to parse a SByte from the provided text.

```csharp
public bool TryParseSByte(string value, out sbyte result);
```
#### Parameters

<a name='Jcd.Formatting.IntegerEncoder.TryParseSByte(string,sbyte).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the text to parse

<a name='Jcd.Formatting.IntegerEncoder.TryParseSByte(string,sbyte).result'></a>

`result` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

the resultant value

Implements [TryParseSByte(string, sbyte)](Jcd.Formatting.IIntegerParser.TryParseSByte(string,sbyte).md 'Jcd.Formatting.IIntegerParser.TryParseSByte(string, sbyte)')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
true if successfully parsed, false otherwise
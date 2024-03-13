### [Jcd.Formatting](Jcd.Formatting.md 'Jcd.Formatting').[IntegerEncoder](Jcd.Formatting.IntegerEncoder.md 'Jcd.Formatting.IntegerEncoder')

## IntegerEncoder.TryParseByte(string, byte) Method

Tries to parse a Byte from the provided text.

```csharp
public bool TryParseByte(string value, out byte result);
```
#### Parameters

<a name='Jcd.Formatting.IntegerEncoder.TryParseByte(string,byte).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the text to parse

<a name='Jcd.Formatting.IntegerEncoder.TryParseByte(string,byte).result'></a>

`result` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

the resultant value

Implements [TryParseByte(string, byte)](Jcd.Formatting.IIntegerParser.TryParseByte(string,byte).md 'Jcd.Formatting.IIntegerParser.TryParseByte(string, byte)')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
true if successfully parsed, false otherwise
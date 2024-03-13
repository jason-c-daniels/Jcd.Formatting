### [Jcd.Formatting](Jcd.Formatting.md 'Jcd.Formatting').[IntegerEncoder](Jcd.Formatting.IntegerEncoder.md 'Jcd.Formatting.IntegerEncoder')

## IntegerEncoder.TryParseUInt16(string, ushort) Method

Tries to parse a UInt16 from the provided text.

```csharp
public bool TryParseUInt16(string value, out ushort result);
```
#### Parameters

<a name='Jcd.Formatting.IntegerEncoder.TryParseUInt16(string,ushort).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the text to parse

<a name='Jcd.Formatting.IntegerEncoder.TryParseUInt16(string,ushort).result'></a>

`result` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

the resultant value

Implements [TryParseUInt16(string, ushort)](Jcd.Formatting.IIntegerParser.TryParseUInt16(string,ushort).md 'Jcd.Formatting.IIntegerParser.TryParseUInt16(string, ushort)')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
true if successfully parsed, false otherwise
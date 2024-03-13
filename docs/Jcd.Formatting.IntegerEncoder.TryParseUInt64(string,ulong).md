### [Jcd.Formatting](Jcd.Formatting.md 'Jcd.Formatting').[IntegerEncoder](Jcd.Formatting.IntegerEncoder.md 'Jcd.Formatting.IntegerEncoder')

## IntegerEncoder.TryParseUInt64(string, ulong) Method

Tries to parse a UInt64 from the provided text.

```csharp
public bool TryParseUInt64(string value, out ulong result);
```
#### Parameters

<a name='Jcd.Formatting.IntegerEncoder.TryParseUInt64(string,ulong).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the text to parse

<a name='Jcd.Formatting.IntegerEncoder.TryParseUInt64(string,ulong).result'></a>

`result` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

the resultant value

Implements [TryParseUInt64(string, ulong)](Jcd.Formatting.IIntegerParser.TryParseUInt64(string,ulong).md 'Jcd.Formatting.IIntegerParser.TryParseUInt64(string, ulong)')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
true if successfully parsed, false otherwise
### [Jcd.Formatting](Jcd.Formatting.md 'Jcd.Formatting').[IntegerEncoder](Jcd.Formatting.IntegerEncoder.md 'Jcd.Formatting.IntegerEncoder')

## IntegerEncoder.TryParseInt32(string, int) Method

Tries to parse a Int32 from the provided text.

```csharp
public bool TryParseInt32(string value, out int result);
```
#### Parameters

<a name='Jcd.Formatting.IntegerEncoder.TryParseInt32(string,int).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the text to parse

<a name='Jcd.Formatting.IntegerEncoder.TryParseInt32(string,int).result'></a>

`result` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the resultant value

Implements [TryParseInt32(string, int)](Jcd.Formatting.IIntegerParser.TryParseInt32(string,int).md 'Jcd.Formatting.IIntegerParser.TryParseInt32(string, int)')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
true if successfully parsed, false otherwise
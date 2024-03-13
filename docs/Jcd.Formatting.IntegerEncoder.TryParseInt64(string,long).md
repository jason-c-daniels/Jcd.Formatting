### [Jcd.Formatting](Jcd.Formatting.md 'Jcd.Formatting').[IntegerEncoder](Jcd.Formatting.IntegerEncoder.md 'Jcd.Formatting.IntegerEncoder')

## IntegerEncoder.TryParseInt64(string, long) Method

Tries to parse a Int64 from the provided text.

```csharp
public bool TryParseInt64(string value, out long result);
```
#### Parameters

<a name='Jcd.Formatting.IntegerEncoder.TryParseInt64(string,long).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the text to parse

<a name='Jcd.Formatting.IntegerEncoder.TryParseInt64(string,long).result'></a>

`result` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

the resultant value

Implements [TryParseInt64(string, long)](Jcd.Formatting.IIntegerParser.TryParseInt64(string,long).md 'Jcd.Formatting.IIntegerParser.TryParseInt64(string, long)')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
true if successfully parsed, false otherwise
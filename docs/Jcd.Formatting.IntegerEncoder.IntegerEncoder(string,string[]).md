### [Jcd.Formatting](Jcd.Formatting.md 'Jcd.Formatting').[IntegerEncoder](Jcd.Formatting.IntegerEncoder.md 'Jcd.Formatting.IntegerEncoder')

## IntegerEncoder(string, string[]) Constructor

Constructs an encoder when given a character set to encode to, and an array of decode
mappings. (This is to support Crockford encoding/decoding)

```csharp
public IntegerEncoder(string encodeCharacterSet, string[] decodeCharacterSet);
```
#### Parameters

<a name='Jcd.Formatting.IntegerEncoder.IntegerEncoder(string,string[]).encodeCharacterSet'></a>

`encodeCharacterSet` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The set of characters to use when encoding a number to text.

<a name='Jcd.Formatting.IntegerEncoder.IntegerEncoder(string,string[]).decodeCharacterSet'></a>

`decodeCharacterSet` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The set of decode character mappings (i.e. which sets of characters map to which numeric
base value.)
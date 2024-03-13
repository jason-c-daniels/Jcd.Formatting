### [Jcd.Formatting](Jcd.Formatting.md 'Jcd.Formatting').[IntegerEncoder](Jcd.Formatting.IntegerEncoder.md 'Jcd.Formatting.IntegerEncoder')

## IntegerEncoder(string, bool) Constructor

Constructs an encoder when given an alphabet with exact encoding to decoding matching.

```csharp
public IntegerEncoder(string characterSet, bool caseSensitive=false);
```
#### Parameters

<a name='Jcd.Formatting.IntegerEncoder.IntegerEncoder(string,bool).characterSet'></a>

`characterSet` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The character set to use for encoding and decoding. (where length = n, char at index 0=0,
char at n-1=n-1)

<a name='Jcd.Formatting.IntegerEncoder.IntegerEncoder(string,bool).caseSensitive'></a>

`caseSensitive` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

indicates if the characters are case sensitive for encoding/decoding.
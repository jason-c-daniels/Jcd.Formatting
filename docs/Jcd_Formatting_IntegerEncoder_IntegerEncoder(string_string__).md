### [Jcd.Formatting](Jcd_Formatting.md 'Jcd.Formatting').[IntegerEncoder](Jcd_Formatting_IntegerEncoder.md 'Jcd.Formatting.IntegerEncoder')
## IntegerEncoder.IntegerEncoder(string, string[]) Constructor
Constructs an encoder when given a character set to encode to, and an array of decode  
mappings. (This is to support Crockford encoding/decoding)  
```csharp
public IntegerEncoder(string encodeCharacterSet, string[] decodeCharacterSet);
```
#### Parameters
<a name='Jcd_Formatting_IntegerEncoder_IntegerEncoder(string_string__)_encodeCharacterSet'></a>
`encodeCharacterSet` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The set of characters to use when encoding a number to text.  
  
<a name='Jcd_Formatting_IntegerEncoder_IntegerEncoder(string_string__)_decodeCharacterSet'></a>
`decodeCharacterSet` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The set of decode character mappings (i.e. which sets of characters map to which numeric  
base value.)  
  

### [Jcd.Formatting](Jcd_Formatting.md 'Jcd.Formatting')
## IntegerEncoder Class
A class that performs integer encoding to text in an arbitrary base, as well as parsing  
text encoded in the same manner.  
```csharp
public class IntegerEncoder : Jcd.Formatting.CustomFormatterBase,
Jcd.Formatting.IIntegerFormatter,
Jcd.Formatting.IIntegerParser
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CustomFormatterBase](Jcd_Formatting_CustomFormatterBase.md 'Jcd.Formatting.CustomFormatterBase') &#129106; IntegerEncoder  

Implements [IIntegerFormatter](Jcd_Formatting_IIntegerFormatter.md 'Jcd.Formatting.IIntegerFormatter'), [IIntegerParser](Jcd_Formatting_IIntegerParser.md 'Jcd.Formatting.IIntegerParser')  

| Constructors | |
| :--- | :--- |
| [IntegerEncoder(string, bool)](Jcd_Formatting_IntegerEncoder_IntegerEncoder(string_bool).md 'Jcd.Formatting.IntegerEncoder.IntegerEncoder(string, bool)') | Constructs an encoder when given an alphabet with exact encoding to decoding matching.<br/> |
| [IntegerEncoder(string, string[])](Jcd_Formatting_IntegerEncoder_IntegerEncoder(string_string__).md 'Jcd.Formatting.IntegerEncoder.IntegerEncoder(string, string[])') | Constructs an encoder when given a character set to encode to, and an array of decode<br/>mappings. (This is to support Crockford encoding/decoding)<br/> |

| Fields | |
| :--- | :--- |
| [Base](Jcd_Formatting_IntegerEncoder_Base.md 'Jcd.Formatting.IntegerEncoder.Base') | The numeric base of the encoder<br/> |
| [CaseSensitive](Jcd_Formatting_IntegerEncoder_CaseSensitive.md 'Jcd.Formatting.IntegerEncoder.CaseSensitive') | Indicates if the characters that are decoded/encoded are case sensitive.<br/> |
| [CharacterSet](Jcd_Formatting_IntegerEncoder_CharacterSet.md 'Jcd.Formatting.IntegerEncoder.CharacterSet') | The character set used for encoding and decoding (for simple decoders)<br/> |
| [CharacterSetValuesAlwaysIncrease](Jcd_Formatting_IntegerEncoder_CharacterSetValuesAlwaysIncrease.md 'Jcd.Formatting.IntegerEncoder.CharacterSetValuesAlwaysIncrease') | A flag that indicates if the values of the characterset are numerically increasing. Using this can allow for faster<br/>sorts of short numbers by NOT decoding first. (i.e. For positive numbers the text will sort the same as the number)<br/> |

| Methods | |
| :--- | :--- |
| [Format(byte)](Jcd_Formatting_IntegerEncoder_Format(byte).md 'Jcd.Formatting.IntegerEncoder.Format(byte)') | Formats a byte as a string.<br/> |
| [Format(int)](Jcd_Formatting_IntegerEncoder_Format(int).md 'Jcd.Formatting.IntegerEncoder.Format(int)') | Formats an int as a string.<br/> |
| [Format(long)](Jcd_Formatting_IntegerEncoder_Format(long).md 'Jcd.Formatting.IntegerEncoder.Format(long)') | Formats a long as a string.<br/> |
| [Format(sbyte)](Jcd_Formatting_IntegerEncoder_Format(sbyte).md 'Jcd.Formatting.IntegerEncoder.Format(sbyte)') | Formats an sbyte as a string.<br/> |
| [Format(short)](Jcd_Formatting_IntegerEncoder_Format(short).md 'Jcd.Formatting.IntegerEncoder.Format(short)') | Formats a short as a string.<br/> |
| [Format(BigInteger)](Jcd_Formatting_IntegerEncoder_Format(System_Numerics_BigInteger).md 'Jcd.Formatting.IntegerEncoder.Format(System.Numerics.BigInteger)') | Formats a BigInteger as a string.<br/> |
| [Format(uint)](Jcd_Formatting_IntegerEncoder_Format(uint).md 'Jcd.Formatting.IntegerEncoder.Format(uint)') | Formats a uint as a string.<br/> |
| [Format(ulong)](Jcd_Formatting_IntegerEncoder_Format(ulong).md 'Jcd.Formatting.IntegerEncoder.Format(ulong)') | Formats a ulong as a string.<br/> |
| [Format(ushort)](Jcd_Formatting_IntegerEncoder_Format(ushort).md 'Jcd.Formatting.IntegerEncoder.Format(ushort)') | Formats a ushort as a string.<br/> |
| [ParseBigInteger(string)](Jcd_Formatting_IntegerEncoder_ParseBigInteger(string).md 'Jcd.Formatting.IntegerEncoder.ParseBigInteger(string)') | Parses a string as a BigInteger<br/> |
| [ParseByte(string)](Jcd_Formatting_IntegerEncoder_ParseByte(string).md 'Jcd.Formatting.IntegerEncoder.ParseByte(string)') | Parses a string as a Byte<br/> |
| [ParseInt16(string)](Jcd_Formatting_IntegerEncoder_ParseInt16(string).md 'Jcd.Formatting.IntegerEncoder.ParseInt16(string)') | Parses a string as an Int16<br/> |
| [ParseInt32(string)](Jcd_Formatting_IntegerEncoder_ParseInt32(string).md 'Jcd.Formatting.IntegerEncoder.ParseInt32(string)') | Parses a string as an Int32<br/> |
| [ParseInt64(string)](Jcd_Formatting_IntegerEncoder_ParseInt64(string).md 'Jcd.Formatting.IntegerEncoder.ParseInt64(string)') | Parses a string as an Int64<br/> |
| [ParseSByte(string)](Jcd_Formatting_IntegerEncoder_ParseSByte(string).md 'Jcd.Formatting.IntegerEncoder.ParseSByte(string)') | Parses a string as an SByte<br/> |
| [ParseUInt16(string)](Jcd_Formatting_IntegerEncoder_ParseUInt16(string).md 'Jcd.Formatting.IntegerEncoder.ParseUInt16(string)') | Parses a string as an UInt16<br/> |
| [ParseUInt32(string)](Jcd_Formatting_IntegerEncoder_ParseUInt32(string).md 'Jcd.Formatting.IntegerEncoder.ParseUInt32(string)') | Parses a string as an UInt32<br/> |
| [ParseUInt64(string)](Jcd_Formatting_IntegerEncoder_ParseUInt64(string).md 'Jcd.Formatting.IntegerEncoder.ParseUInt64(string)') | Parses a string as an UInt64<br/> |
| [TryParseBigInteger(string, BigInteger)](Jcd_Formatting_IntegerEncoder_TryParseBigInteger(string_System_Numerics_BigInteger).md 'Jcd.Formatting.IntegerEncoder.TryParseBigInteger(string, System.Numerics.BigInteger)') | Tries to parse a BigInteger from the provided text.<br/> |
| [TryParseByte(string, byte)](Jcd_Formatting_IntegerEncoder_TryParseByte(string_byte).md 'Jcd.Formatting.IntegerEncoder.TryParseByte(string, byte)') | Tries to parse a Byte from the provided text.<br/> |
| [TryParseInt16(string, short)](Jcd_Formatting_IntegerEncoder_TryParseInt16(string_short).md 'Jcd.Formatting.IntegerEncoder.TryParseInt16(string, short)') | Tries to parse a Int16 from the provided text.<br/> |
| [TryParseInt32(string, int)](Jcd_Formatting_IntegerEncoder_TryParseInt32(string_int).md 'Jcd.Formatting.IntegerEncoder.TryParseInt32(string, int)') | Tries to parse a Int32 from the provided text.<br/> |
| [TryParseInt64(string, long)](Jcd_Formatting_IntegerEncoder_TryParseInt64(string_long).md 'Jcd.Formatting.IntegerEncoder.TryParseInt64(string, long)') | Tries to parse a Int64 from the provided text.<br/> |
| [TryParseSByte(string, sbyte)](Jcd_Formatting_IntegerEncoder_TryParseSByte(string_sbyte).md 'Jcd.Formatting.IntegerEncoder.TryParseSByte(string, sbyte)') | Tries to parse a SByte from the provided text.<br/> |
| [TryParseUInt16(string, ushort)](Jcd_Formatting_IntegerEncoder_TryParseUInt16(string_ushort).md 'Jcd.Formatting.IntegerEncoder.TryParseUInt16(string, ushort)') | Tries to parse a UInt16 from the provided text.<br/> |
| [TryParseUInt32(string, uint)](Jcd_Formatting_IntegerEncoder_TryParseUInt32(string_uint).md 'Jcd.Formatting.IntegerEncoder.TryParseUInt32(string, uint)') | Tries to parse a UInt32 from the provided text.<br/> |
| [TryParseUInt64(string, ulong)](Jcd_Formatting_IntegerEncoder_TryParseUInt64(string_ulong).md 'Jcd.Formatting.IntegerEncoder.TryParseUInt64(string, ulong)') | Tries to parse a UInt64 from the provided text.<br/> |

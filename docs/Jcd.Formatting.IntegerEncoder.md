### [Jcd.Formatting](Jcd.Formatting.md 'Jcd.Formatting')

## IntegerEncoder Class

A class that performs integer encoding to text in an arbitrary base, as well as parsing
text encoded in the same manner.

```csharp
public class IntegerEncoder : Jcd.Formatting.CustomFormatterBase,
Jcd.Formatting.IIntegerFormatter,
Jcd.Formatting.IIntegerParser
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CustomFormatterBase](Jcd.Formatting.CustomFormatterBase.md 'Jcd.Formatting.CustomFormatterBase') &#129106; IntegerEncoder

Implements [IIntegerFormatter](Jcd.Formatting.IIntegerFormatter.md 'Jcd.Formatting.IIntegerFormatter'), [IIntegerParser](Jcd.Formatting.IIntegerParser.md 'Jcd.Formatting.IIntegerParser')

| Constructors | |
| :--- | :--- |
| [IntegerEncoder(string, bool)](Jcd.Formatting.IntegerEncoder.IntegerEncoder(string,bool).md 'Jcd.Formatting.IntegerEncoder.IntegerEncoder(string, bool)') | Constructs an encoder when given an alphabet with exact encoding to decoding matching. |
| [IntegerEncoder(string, string[])](Jcd.Formatting.IntegerEncoder.IntegerEncoder(string,string[]).md 'Jcd.Formatting.IntegerEncoder.IntegerEncoder(string, string[])') | Constructs an encoder when given a character set to encode to, and an array of decode mappings. (This is to support Crockford encoding/decoding) |
| [IntegerEncoder(ushort, bool, string, bool, Dictionary&lt;char,int&gt;)](Jcd.Formatting.IntegerEncoder.IntegerEncoder(ushort,bool,string,bool,System.Collections.Generic.Dictionary_char,int_).md 'Jcd.Formatting.IntegerEncoder.IntegerEncoder(ushort, bool, string, bool, System.Collections.Generic.Dictionary<char,int>)') | Constructs an IntegerEncoder |

| Fields | |
| :--- | :--- |
| [Base](Jcd.Formatting.IntegerEncoder.Base.md 'Jcd.Formatting.IntegerEncoder.Base') | The numeric base of the encoder |
| [CaseSensitive](Jcd.Formatting.IntegerEncoder.CaseSensitive.md 'Jcd.Formatting.IntegerEncoder.CaseSensitive') | Indicates if the characters that are decoded/encoded are case sensitive. |
| [CharacterSet](Jcd.Formatting.IntegerEncoder.CharacterSet.md 'Jcd.Formatting.IntegerEncoder.CharacterSet') | The character set used for encoding and decoding (for simple decoders) |
| [CharacterSetValuesAlwaysIncrease](Jcd.Formatting.IntegerEncoder.CharacterSetValuesAlwaysIncrease.md 'Jcd.Formatting.IntegerEncoder.CharacterSetValuesAlwaysIncrease') | A flag that indicates if the values of the character set are numerically increasing. Using this can allow for faster sorts of short numbers by NOT decoding first. (i.e. For positive numbers the text will sort the same as the number) |

| Methods | |
| :--- | :--- |
| [Format(byte)](Jcd.Formatting.IntegerEncoder.Format(byte).md 'Jcd.Formatting.IntegerEncoder.Format(byte)') | Formats a byte as a string. |
| [Format(int)](Jcd.Formatting.IntegerEncoder.Format(int).md 'Jcd.Formatting.IntegerEncoder.Format(int)') | Formats an int as a string. |
| [Format(long)](Jcd.Formatting.IntegerEncoder.Format(long).md 'Jcd.Formatting.IntegerEncoder.Format(long)') | Formats a long as a string. |
| [Format(sbyte)](Jcd.Formatting.IntegerEncoder.Format(sbyte).md 'Jcd.Formatting.IntegerEncoder.Format(sbyte)') | Formats an sbyte as a string. |
| [Format(short)](Jcd.Formatting.IntegerEncoder.Format(short).md 'Jcd.Formatting.IntegerEncoder.Format(short)') | Formats a short as a string. |
| [Format(BigInteger)](Jcd.Formatting.IntegerEncoder.Format(System.Numerics.BigInteger).md 'Jcd.Formatting.IntegerEncoder.Format(System.Numerics.BigInteger)') | Formats a BigInteger as a string. |
| [Format(uint)](Jcd.Formatting.IntegerEncoder.Format(uint).md 'Jcd.Formatting.IntegerEncoder.Format(uint)') | Formats a uint as a string. |
| [Format(ulong)](Jcd.Formatting.IntegerEncoder.Format(ulong).md 'Jcd.Formatting.IntegerEncoder.Format(ulong)') | Formats a ulong as a string. |
| [Format(ushort)](Jcd.Formatting.IntegerEncoder.Format(ushort).md 'Jcd.Formatting.IntegerEncoder.Format(ushort)') | Formats a ushort as a string. |
| [ParseBigInteger(string)](Jcd.Formatting.IntegerEncoder.ParseBigInteger(string).md 'Jcd.Formatting.IntegerEncoder.ParseBigInteger(string)') | Parses a string as a BigInteger |
| [ParseByte(string)](Jcd.Formatting.IntegerEncoder.ParseByte(string).md 'Jcd.Formatting.IntegerEncoder.ParseByte(string)') | Parses a string as a Byte |
| [ParseInt16(string)](Jcd.Formatting.IntegerEncoder.ParseInt16(string).md 'Jcd.Formatting.IntegerEncoder.ParseInt16(string)') | Parses a string as an Int16 |
| [ParseInt32(string)](Jcd.Formatting.IntegerEncoder.ParseInt32(string).md 'Jcd.Formatting.IntegerEncoder.ParseInt32(string)') | Parses a string as an Int32 |
| [ParseInt64(string)](Jcd.Formatting.IntegerEncoder.ParseInt64(string).md 'Jcd.Formatting.IntegerEncoder.ParseInt64(string)') | Parses a string as an Int64 |
| [ParseSByte(string)](Jcd.Formatting.IntegerEncoder.ParseSByte(string).md 'Jcd.Formatting.IntegerEncoder.ParseSByte(string)') | Parses a string as an SByte |
| [ParseUInt16(string)](Jcd.Formatting.IntegerEncoder.ParseUInt16(string).md 'Jcd.Formatting.IntegerEncoder.ParseUInt16(string)') | Parses a string as an UInt16 |
| [ParseUInt32(string)](Jcd.Formatting.IntegerEncoder.ParseUInt32(string).md 'Jcd.Formatting.IntegerEncoder.ParseUInt32(string)') | Parses a string as an UInt32 |
| [ParseUInt64(string)](Jcd.Formatting.IntegerEncoder.ParseUInt64(string).md 'Jcd.Formatting.IntegerEncoder.ParseUInt64(string)') | Parses a string as an UInt64 |
| [TryParseBigInteger(string, BigInteger)](Jcd.Formatting.IntegerEncoder.TryParseBigInteger(string,System.Numerics.BigInteger).md 'Jcd.Formatting.IntegerEncoder.TryParseBigInteger(string, System.Numerics.BigInteger)') | Tries to parse a BigInteger from the provided text. |
| [TryParseByte(string, byte)](Jcd.Formatting.IntegerEncoder.TryParseByte(string,byte).md 'Jcd.Formatting.IntegerEncoder.TryParseByte(string, byte)') | Tries to parse a Byte from the provided text. |
| [TryParseInt16(string, short)](Jcd.Formatting.IntegerEncoder.TryParseInt16(string,short).md 'Jcd.Formatting.IntegerEncoder.TryParseInt16(string, short)') | Tries to parse a Int16 from the provided text. |
| [TryParseInt32(string, int)](Jcd.Formatting.IntegerEncoder.TryParseInt32(string,int).md 'Jcd.Formatting.IntegerEncoder.TryParseInt32(string, int)') | Tries to parse a Int32 from the provided text. |
| [TryParseInt64(string, long)](Jcd.Formatting.IntegerEncoder.TryParseInt64(string,long).md 'Jcd.Formatting.IntegerEncoder.TryParseInt64(string, long)') | Tries to parse a Int64 from the provided text. |
| [TryParseSByte(string, sbyte)](Jcd.Formatting.IntegerEncoder.TryParseSByte(string,sbyte).md 'Jcd.Formatting.IntegerEncoder.TryParseSByte(string, sbyte)') | Tries to parse a SByte from the provided text. |
| [TryParseUInt16(string, ushort)](Jcd.Formatting.IntegerEncoder.TryParseUInt16(string,ushort).md 'Jcd.Formatting.IntegerEncoder.TryParseUInt16(string, ushort)') | Tries to parse a UInt16 from the provided text. |
| [TryParseUInt32(string, uint)](Jcd.Formatting.IntegerEncoder.TryParseUInt32(string,uint).md 'Jcd.Formatting.IntegerEncoder.TryParseUInt32(string, uint)') | Tries to parse a UInt32 from the provided text. |
| [TryParseUInt64(string, ulong)](Jcd.Formatting.IntegerEncoder.TryParseUInt64(string,ulong).md 'Jcd.Formatting.IntegerEncoder.TryParseUInt64(string, ulong)') | Tries to parse a UInt64 from the provided text. |

### [Jcd.Formatting](Jcd_Formatting.md 'Jcd.Formatting')
## IntegerEncoders Class
A class with a set of predefined integer encoders.  
```csharp
public static class IntegerEncoders
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; IntegerEncoders  

| Fields | |
| :--- | :--- |
| [Ascii85](Jcd_Formatting_IntegerEncoders_Ascii85.md 'Jcd.Formatting.IntegerEncoders.Ascii85') | ASCII 85 formatter, possibly under patent protection, need to check.<br/> |
| [Base1280MonotonicIso885915](Jcd_Formatting_IntegerEncoders_Base1280MonotonicIso885915.md 'Jcd.Formatting.IntegerEncoders.Base1280MonotonicIso885915') | Base 128 formatting, first 128 characters from the ISO8859_15_EncodingCharacters alphabet, starting at "0"<br/> |
| [Base128AMonotonicIso885915](Jcd_Formatting_IntegerEncoders_Base128AMonotonicIso885915.md 'Jcd.Formatting.IntegerEncoders.Base128AMonotonicIso885915') | Base 128 formatting, first 128 characters from the ISO8859_15_EncodingCharacters alphabet, starting at "A"<br/> |
| [Base128MonotonicIso885915](Jcd_Formatting_IntegerEncoders_Base128MonotonicIso885915.md 'Jcd.Formatting.IntegerEncoders.Base128MonotonicIso885915') | Base 128 formatting, first 128 characters from the ISO8859_15_EncodingCharacters alphabet.<br/> |
| [Base32](Jcd_Formatting_IntegerEncoders_Base32.md 'Jcd.Formatting.IntegerEncoders.Base32') | A base 32 formatter using 0-9A-V, case insensitive<br/> |
| [Base32Crockford](Jcd_Formatting_IntegerEncoders_Base32Crockford.md 'Jcd.Formatting.IntegerEncoders.Base32Crockford') | A base 32 formatter for Crockford numbers, special parsing rules.<br/>TODO: Fully implement the "check code symbol" ala https://www.crockford.com/wrmg/base32.html<br/> |
| [Base32CrockfordDecodeCharacterSet](Jcd_Formatting_IntegerEncoders_Base32CrockfordDecodeCharacterSet.md 'Jcd.Formatting.IntegerEncoders.Base32CrockfordDecodeCharacterSet') | The decoding mappings for Crockford base 32 decoding.<br/> |
| [Base32Rfc4648](Jcd_Formatting_IntegerEncoders_Base32Rfc4648.md 'Jcd.Formatting.IntegerEncoders.Base32Rfc4648') | A base 32 formatter for RFC4648 numbers, case sensitive<br/> |
| [Base32Zrtp](Jcd_Formatting_IntegerEncoders_Base32Zrtp.md 'Jcd.Formatting.IntegerEncoders.Base32Zrtp') | A base 32 formatter for ZRTP encoded numbers, case sensitive<br/> |
| [Base36](Jcd_Formatting_IntegerEncoders_Base36.md 'Jcd.Formatting.IntegerEncoders.Base36') | A base 36 formatter using 0-9A-Z, case insensitive<br/> |
| [Base58Ipfs](Jcd_Formatting_IntegerEncoders_Base58Ipfs.md 'Jcd.Formatting.IntegerEncoders.Base58Ipfs') | A base 58 formatter IPFS compliant, case sensitive, alphabet:<br/>123456789ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz<br/> |
| [Base62](Jcd_Formatting_IntegerEncoders_Base62.md 'Jcd.Formatting.IntegerEncoders.Base62') | Base 62 formatter using: 0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz<br/> |
| [Base63](Jcd_Formatting_IntegerEncoders_Base63.md 'Jcd.Formatting.IntegerEncoders.Base63') | Base 63 formatter using: 0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz+<br/> |
| [Base64](Jcd_Formatting_IntegerEncoders_Base64.md 'Jcd.Formatting.IntegerEncoders.Base64') | Base 64 formatter using the standard: 0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz+/<br/> |
| [Base64Bcrypt](Jcd_Formatting_IntegerEncoders_Base64Bcrypt.md 'Jcd.Formatting.IntegerEncoders.Base64Bcrypt') | Base 64 formatter: Bcrypt compliant<br/> |
| [Base64BinHex4](Jcd_Formatting_IntegerEncoders_Base64BinHex4.md 'Jcd.Formatting.IntegerEncoders.Base64BinHex4') | Base 64 formatter: BinHex4 compliant<br/> |
| [Base64Radix64](Jcd_Formatting_IntegerEncoders_Base64Radix64.md 'Jcd.Formatting.IntegerEncoders.Base64Radix64') | Base 64 formatter: Radix64 compliant<br/> |
| [Base64UnixB64](Jcd_Formatting_IntegerEncoders_Base64UnixB64.md 'Jcd.Formatting.IntegerEncoders.Base64UnixB64') | Base 64 formatter: Unix B64 compliant<br/> |
| [Base64Uuencoding](Jcd_Formatting_IntegerEncoders_Base64Uuencoding.md 'Jcd.Formatting.IntegerEncoders.Base64Uuencoding') | Base 64 formatter: Uuencoding compliant<br/> |
| [Base64Xxencoding](Jcd_Formatting_IntegerEncoders_Base64Xxencoding.md 'Jcd.Formatting.IntegerEncoders.Base64Xxencoding') | Base 64 formatter: Xxencoding compliant<br/> |
| [Base91](Jcd_Formatting_IntegerEncoders_Base91.md 'Jcd.Formatting.IntegerEncoders.Base91') | Base 91 formatter, basE91 compliant (see http://base91.sourceforge.net/)<br/> |
| [Base930MonotonicIso885915](Jcd_Formatting_IntegerEncoders_Base930MonotonicIso885915.md 'Jcd.Formatting.IntegerEncoders.Base930MonotonicIso885915') | Base 93 formatting, first 93 characters from the ISO8859_15_EncodingCharacters alphabet, starting at "0"<br/> |
| [Base93MonotonicIso885915](Jcd_Formatting_IntegerEncoders_Base93MonotonicIso885915.md 'Jcd.Formatting.IntegerEncoders.Base93MonotonicIso885915') | Base 93 formatting, first 93 characters from the ISO8859_15_EncodingCharacters alphabet"<br/> |
| [Base93StartAtLowercaseAMonotonicIso885915](Jcd_Formatting_IntegerEncoders_Base93StartAtLowercaseAMonotonicIso885915.md 'Jcd.Formatting.IntegerEncoders.Base93StartAtLowercaseAMonotonicIso885915') | Base 93 formatting, first 93 characters from the ISO8859_15_EncodingCharacters alphabet, starting at "a"<br/> |
| [Base93StartAtUppercaseAMonotonicIso885915](Jcd_Formatting_IntegerEncoders_Base93StartAtUppercaseAMonotonicIso885915.md 'Jcd.Formatting.IntegerEncoders.Base93StartAtUppercaseAMonotonicIso885915') | Base 93 formatting, first 93 characters from the ISO8859_15_EncodingCharacters alphabet, starting at "A"<br/> |
| [Binary](Jcd_Formatting_IntegerEncoders_Binary.md 'Jcd.Formatting.IntegerEncoders.Binary') | A base 2 formatter using 01<br/> |
| [Decimal](Jcd_Formatting_IntegerEncoders_Decimal.md 'Jcd.Formatting.IntegerEncoders.Decimal') | A base 10 formatter using 0-9<br/> |
| [Duodecimal](Jcd_Formatting_IntegerEncoders_Duodecimal.md 'Jcd.Formatting.IntegerEncoders.Duodecimal') | A base 12 formatter using 0-9AB, case insensitive<br/> |
| [FlickrBase58](Jcd_Formatting_IntegerEncoders_FlickrBase58.md 'Jcd.Formatting.IntegerEncoders.FlickrBase58') | A base 58 formatter Flickr short URL compliant, case sensitive, alphabet:<br/>123456789abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNPQRSTUVWXYZ<br/> |
| [Heptadecimal](Jcd_Formatting_IntegerEncoders_Heptadecimal.md 'Jcd.Formatting.IntegerEncoders.Heptadecimal') | A base 17 formatter using 0-9A-G, case insensitive<br/> |
| [Hexadecimal](Jcd_Formatting_IntegerEncoders_Hexadecimal.md 'Jcd.Formatting.IntegerEncoders.Hexadecimal') | A base 16 formatter using 0-9A-F, case insensitive<br/> |
| [Iso885915EncodingCharacters](Jcd_Formatting_IntegerEncoders_Iso885915EncodingCharacters.md 'Jcd.Formatting.IntegerEncoders.Iso885915EncodingCharacters') | A base alphabet for various numeric encoders with whitespace and certain special characters removed. |
| [Nonary](Jcd_Formatting_IntegerEncoders_Nonary.md 'Jcd.Formatting.IntegerEncoders.Nonary') | A base 9 formatter using 0-8<br/> |
| [Octal](Jcd_Formatting_IntegerEncoders_Octal.md 'Jcd.Formatting.IntegerEncoders.Octal') | A base 8 formatter using 0-7<br/> |
| [Pentadecimal](Jcd_Formatting_IntegerEncoders_Pentadecimal.md 'Jcd.Formatting.IntegerEncoders.Pentadecimal') | A base 15 formatter using 0-9A-E, case insensitive<br/> |
| [Quaternary](Jcd_Formatting_IntegerEncoders_Quaternary.md 'Jcd.Formatting.IntegerEncoders.Quaternary') | A quaternary formatter using 0123<br/> |
| [Quinary](Jcd_Formatting_IntegerEncoders_Quinary.md 'Jcd.Formatting.IntegerEncoders.Quinary') | A quinary (base 5) formatter using 0-4<br/> |
| [Senary](Jcd_Formatting_IntegerEncoders_Senary.md 'Jcd.Formatting.IntegerEncoders.Senary') | A base 6 formatter using 0-5<br/> |
| [Septenary](Jcd_Formatting_IntegerEncoders_Septenary.md 'Jcd.Formatting.IntegerEncoders.Septenary') | A base 7 formatter using 0-6<br/> |
| [Sexagesimal](Jcd_Formatting_IntegerEncoders_Sexagesimal.md 'Jcd.Formatting.IntegerEncoders.Sexagesimal') | Base 60 formatter using this alphabet: 0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwx<br/> |
| [Ternary](Jcd_Formatting_IntegerEncoders_Ternary.md 'Jcd.Formatting.IntegerEncoders.Ternary') | A base 3 formatter 012<br/> |
| [Tetradecimal](Jcd_Formatting_IntegerEncoders_Tetradecimal.md 'Jcd.Formatting.IntegerEncoders.Tetradecimal') | A base 14 formatter using 0-9A-D, case insensitive<br/> |
| [Tridecimal](Jcd_Formatting_IntegerEncoders_Tridecimal.md 'Jcd.Formatting.IntegerEncoders.Tridecimal') | A base 13 formatter using 0-9A-C, case insensitive<br/> |
| [Undecimal](Jcd_Formatting_IntegerEncoders_Undecimal.md 'Jcd.Formatting.IntegerEncoders.Undecimal') | A base 11 formatter using 0-9A, case insensitive<br/> |
| [Vegesimal](Jcd_Formatting_IntegerEncoders_Vegesimal.md 'Jcd.Formatting.IntegerEncoders.Vegesimal') | A base 20 formatter using 0-9A-J, case insensitive<br/> |

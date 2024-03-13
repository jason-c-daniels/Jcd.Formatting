### [Jcd.Formatting](Jcd.Formatting.md 'Jcd.Formatting')

## IntegerEncoders Class

A class with a set of predefined integer encoders.

```csharp
public static class IntegerEncoders
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; IntegerEncoders

| Fields | |
| :--- | :--- |
| [Base1280MonotonicIso885915](Jcd.Formatting.IntegerEncoders.Base1280MonotonicIso885915.md 'Jcd.Formatting.IntegerEncoders.Base1280MonotonicIso885915') | Base 128 formatting, first 128 characters from the ISO8859_15_EncodingCharacters alphabet, starting at "0" |
| [Base128AMonotonicIso885915](Jcd.Formatting.IntegerEncoders.Base128AMonotonicIso885915.md 'Jcd.Formatting.IntegerEncoders.Base128AMonotonicIso885915') | Base 128 formatting, first 128 characters from the ISO8859_15_EncodingCharacters alphabet, starting at "A" |
| [Base128MonotonicIso885915](Jcd.Formatting.IntegerEncoders.Base128MonotonicIso885915.md 'Jcd.Formatting.IntegerEncoders.Base128MonotonicIso885915') | Base 128 formatting, first 128 characters from the ISO8859_15_EncodingCharacters alphabet. |
| [Base32](Jcd.Formatting.IntegerEncoders.Base32.md 'Jcd.Formatting.IntegerEncoders.Base32') | A base 32 formatter using 0-9A-V, case insensitive |
| [Base32Crockford](Jcd.Formatting.IntegerEncoders.Base32Crockford.md 'Jcd.Formatting.IntegerEncoders.Base32Crockford') | A base 32 formatter for Crockford numbers, special parsing rules. TODO: Fully implement the "check code symbol" ala https://www.crockford.com/wrmg/base32.html |
| [Base32CrockfordDecodeCharacterSet](Jcd.Formatting.IntegerEncoders.Base32CrockfordDecodeCharacterSet.md 'Jcd.Formatting.IntegerEncoders.Base32CrockfordDecodeCharacterSet') | The decoding mappings for Crockford base 32 decoding. |
| [Base32Rfc4648](Jcd.Formatting.IntegerEncoders.Base32Rfc4648.md 'Jcd.Formatting.IntegerEncoders.Base32Rfc4648') | A base 32 formatter for RFC4648 numbers, case sensitive |
| [Base32Zrtp](Jcd.Formatting.IntegerEncoders.Base32Zrtp.md 'Jcd.Formatting.IntegerEncoders.Base32Zrtp') | A base 32 formatter for ZRTP encoded numbers, case sensitive |
| [Base36](Jcd.Formatting.IntegerEncoders.Base36.md 'Jcd.Formatting.IntegerEncoders.Base36') | A base 36 formatter using 0-9A-Z, case insensitive |
| [Base58Ipfs](Jcd.Formatting.IntegerEncoders.Base58Ipfs.md 'Jcd.Formatting.IntegerEncoders.Base58Ipfs') | A base 58 formatter IPFS compliant, case sensitive, alphabet: 123456789ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz |
| [Base62](Jcd.Formatting.IntegerEncoders.Base62.md 'Jcd.Formatting.IntegerEncoders.Base62') | Base 62 formatter using: 0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz |
| [Base63](Jcd.Formatting.IntegerEncoders.Base63.md 'Jcd.Formatting.IntegerEncoders.Base63') | Base 63 formatter using: 0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz+ |
| [Base64](Jcd.Formatting.IntegerEncoders.Base64.md 'Jcd.Formatting.IntegerEncoders.Base64') | Base 64 formatter using the standard: 0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz+/ |
| [Base64Bcrypt](Jcd.Formatting.IntegerEncoders.Base64Bcrypt.md 'Jcd.Formatting.IntegerEncoders.Base64Bcrypt') | Base 64 formatter: Bcrypt compliant |
| [Base64BinHex4](Jcd.Formatting.IntegerEncoders.Base64BinHex4.md 'Jcd.Formatting.IntegerEncoders.Base64BinHex4') | Base 64 formatter: BinHex4 compliant |
| [Base64Radix64](Jcd.Formatting.IntegerEncoders.Base64Radix64.md 'Jcd.Formatting.IntegerEncoders.Base64Radix64') | Base 64 formatter: Radix64 compliant |
| [Base64UnixB64](Jcd.Formatting.IntegerEncoders.Base64UnixB64.md 'Jcd.Formatting.IntegerEncoders.Base64UnixB64') | Base 64 formatter: Unix B64 compliant |
| [Base64Uuencoding](Jcd.Formatting.IntegerEncoders.Base64Uuencoding.md 'Jcd.Formatting.IntegerEncoders.Base64Uuencoding') | Base 64 formatter: Uuencoding compliant |
| [Base64Xxencoding](Jcd.Formatting.IntegerEncoders.Base64Xxencoding.md 'Jcd.Formatting.IntegerEncoders.Base64Xxencoding') | Base 64 formatter: Xxencoding compliant |
| [Base91](Jcd.Formatting.IntegerEncoders.Base91.md 'Jcd.Formatting.IntegerEncoders.Base91') | Base 91 formatter, basE91 compliant (see http://base91.sourceforge.net/) |
| [Base930MonotonicIso885915](Jcd.Formatting.IntegerEncoders.Base930MonotonicIso885915.md 'Jcd.Formatting.IntegerEncoders.Base930MonotonicIso885915') | Base 93 formatting, first 93 characters from the ISO8859_15_EncodingCharacters alphabet, starting at "0" |
| [Base93MonotonicIso885915](Jcd.Formatting.IntegerEncoders.Base93MonotonicIso885915.md 'Jcd.Formatting.IntegerEncoders.Base93MonotonicIso885915') | Base 93 formatting, first 93 characters from the ISO8859_15_EncodingCharacters alphabet" |
| [Base93StartAtLowercaseAMonotonicIso885915](Jcd.Formatting.IntegerEncoders.Base93StartAtLowercaseAMonotonicIso885915.md 'Jcd.Formatting.IntegerEncoders.Base93StartAtLowercaseAMonotonicIso885915') | Base 93 formatting, first 93 characters from the ISO8859_15_EncodingCharacters alphabet, starting at "a" |
| [Base93StartAtUppercaseAMonotonicIso885915](Jcd.Formatting.IntegerEncoders.Base93StartAtUppercaseAMonotonicIso885915.md 'Jcd.Formatting.IntegerEncoders.Base93StartAtUppercaseAMonotonicIso885915') | Base 93 formatting, first 93 characters from the ISO8859_15_EncodingCharacters alphabet, starting at "A" |
| [Binary](Jcd.Formatting.IntegerEncoders.Binary.md 'Jcd.Formatting.IntegerEncoders.Binary') | A base 2 formatter using 01 |
| [Decimal](Jcd.Formatting.IntegerEncoders.Decimal.md 'Jcd.Formatting.IntegerEncoders.Decimal') | A base 10 formatter using 0-9 |
| [Duodecimal](Jcd.Formatting.IntegerEncoders.Duodecimal.md 'Jcd.Formatting.IntegerEncoders.Duodecimal') | A base 12 formatter using 0-9AB, case insensitive |
| [FlickrBase58](Jcd.Formatting.IntegerEncoders.FlickrBase58.md 'Jcd.Formatting.IntegerEncoders.FlickrBase58') | A base 58 formatter Flickr short URL compliant, case sensitive, alphabet: 123456789abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNPQRSTUVWXYZ |
| [Heptadecimal](Jcd.Formatting.IntegerEncoders.Heptadecimal.md 'Jcd.Formatting.IntegerEncoders.Heptadecimal') | A base 17 formatter using 0-9A-G, case insensitive |
| [Hexadecimal](Jcd.Formatting.IntegerEncoders.Hexadecimal.md 'Jcd.Formatting.IntegerEncoders.Hexadecimal') | A base 16 formatter using 0-9A-F, case insensitive |
| [Iso885915EncodingCharacters](Jcd.Formatting.IntegerEncoders.Iso885915EncodingCharacters.md 'Jcd.Formatting.IntegerEncoders.Iso885915EncodingCharacters') | A base alphabet for various numeric encoders with whitespace and certain special characters removed. |
| [Nonary](Jcd.Formatting.IntegerEncoders.Nonary.md 'Jcd.Formatting.IntegerEncoders.Nonary') | A base 9 formatter using 0-8 |
| [Octal](Jcd.Formatting.IntegerEncoders.Octal.md 'Jcd.Formatting.IntegerEncoders.Octal') | A base 8 formatter using 0-7 |
| [Pentadecimal](Jcd.Formatting.IntegerEncoders.Pentadecimal.md 'Jcd.Formatting.IntegerEncoders.Pentadecimal') | A base 15 formatter using 0-9A-E, case insensitive |
| [Quaternary](Jcd.Formatting.IntegerEncoders.Quaternary.md 'Jcd.Formatting.IntegerEncoders.Quaternary') | A quaternary formatter using 0123 |
| [Quinary](Jcd.Formatting.IntegerEncoders.Quinary.md 'Jcd.Formatting.IntegerEncoders.Quinary') | A quinary (base 5) formatter using 0-4 |
| [Senary](Jcd.Formatting.IntegerEncoders.Senary.md 'Jcd.Formatting.IntegerEncoders.Senary') | A base 6 formatter using 0-5 |
| [Septenary](Jcd.Formatting.IntegerEncoders.Septenary.md 'Jcd.Formatting.IntegerEncoders.Septenary') | A base 7 formatter using 0-6 |
| [Sexagesimal](Jcd.Formatting.IntegerEncoders.Sexagesimal.md 'Jcd.Formatting.IntegerEncoders.Sexagesimal') | Base 60 formatter using this alphabet: 0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwx |
| [Ternary](Jcd.Formatting.IntegerEncoders.Ternary.md 'Jcd.Formatting.IntegerEncoders.Ternary') | A base 3 formatter 012 |
| [Tetradecimal](Jcd.Formatting.IntegerEncoders.Tetradecimal.md 'Jcd.Formatting.IntegerEncoders.Tetradecimal') | A base 14 formatter using 0-9A-D, case insensitive |
| [Tridecimal](Jcd.Formatting.IntegerEncoders.Tridecimal.md 'Jcd.Formatting.IntegerEncoders.Tridecimal') | A base 13 formatter using 0-9A-C, case insensitive |
| [Undecimal](Jcd.Formatting.IntegerEncoders.Undecimal.md 'Jcd.Formatting.IntegerEncoders.Undecimal') | A base 11 formatter using 0-9A, case insensitive |
| [Vegesimal](Jcd.Formatting.IntegerEncoders.Vegesimal.md 'Jcd.Formatting.IntegerEncoders.Vegesimal') | A base 20 formatter using 0-9A-J, case insensitive |

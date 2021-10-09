### [Jcd.Formatting](Jcd_Formatting.md 'Jcd.Formatting').[IntegerEncoders](Jcd_Formatting_IntegerEncoders.md 'Jcd.Formatting.IntegerEncoders')
## IntegerEncoders.Iso885915EncodingCharacters Field
A base alphabet for various numeric encoders with whitespace and certain special characters removed.
```csharp
public const string Iso885915EncodingCharacters = ./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[]^_abcdefghijklmnopqrstuvwxyz{|}~¡¢£€¥Š§š©«¬®±Žµ¶ž»ŒœŸ¿ÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖ×ØÙÚÛÜÝÞßàáâãäåæçèéêëìíîïðñòóôõö÷øùúûüýþÿ;
```
#### Field Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
### Remarks
Readable/non-whitespace subset of ISO8859. The following characters have been removed. This gives an alphabet of  
166 characters in numerical order.  
Characters: `¯°²³¹º·  
0x2D (-) and numerically lower characters.  
0x7F (DEL)  
0xA0 (NBSP)  
0xAD (SHY)  

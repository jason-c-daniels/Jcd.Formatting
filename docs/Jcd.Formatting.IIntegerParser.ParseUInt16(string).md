### [Jcd.Formatting](Jcd.Formatting.md 'Jcd.Formatting').[IIntegerParser](Jcd.Formatting.IIntegerParser.md 'Jcd.Formatting.IIntegerParser')

## IIntegerParser.ParseUInt16(string) Method

Parses a string as an UInt16

```csharp
ushort ParseUInt16(string value);
```
#### Parameters

<a name='Jcd.Formatting.IIntegerParser.ParseUInt16(string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The text to decode

#### Returns
[System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')
the decoded value

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')
If the value parameter was null

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')
If the text is empty or whitespace.

[System.OverflowException](https://docs.microsoft.com/en-us/dotnet/api/System.OverflowException 'System.OverflowException')
If the text cannot be parse because the resultant value can't be stored in an UInt16

[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')
If the provided characters cannot be decoded per the current encoding..
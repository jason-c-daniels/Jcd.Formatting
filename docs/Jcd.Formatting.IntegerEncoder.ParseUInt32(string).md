### [Jcd.Formatting](Jcd.Formatting.md 'Jcd.Formatting').[IntegerEncoder](Jcd.Formatting.IntegerEncoder.md 'Jcd.Formatting.IntegerEncoder')

## IntegerEncoder.ParseUInt32(string) Method

Parses a string as an UInt32

```csharp
public uint ParseUInt32(string value);
```
#### Parameters

<a name='Jcd.Formatting.IntegerEncoder.ParseUInt32(string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The text to decode

Implements [ParseUInt32(string)](Jcd.Formatting.IIntegerParser.ParseUInt32(string).md 'Jcd.Formatting.IIntegerParser.ParseUInt32(string)')

#### Returns
[System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')
the decoded value

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')
If the value parameter was null

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')
If the text is empty or whitespace.

[System.OverflowException](https://docs.microsoft.com/en-us/dotnet/api/System.OverflowException 'System.OverflowException')
If the text cannot be parse because the resultant value can't be stored in an UInt32

[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')
If the provided characters cannot be decoded per the current encoding..
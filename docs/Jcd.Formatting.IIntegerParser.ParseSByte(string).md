### [Jcd.Formatting](Jcd.Formatting.md 'Jcd.Formatting').[IIntegerParser](Jcd.Formatting.IIntegerParser.md 'Jcd.Formatting.IIntegerParser')

## IIntegerParser.ParseSByte(string) Method

Parses a string as an SByte

```csharp
sbyte ParseSByte(string value);
```
#### Parameters

<a name='Jcd.Formatting.IIntegerParser.ParseSByte(string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The text to decode

#### Returns
[System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')
the decoded value

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')
If the value parameter was null

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')
If the text is empty or whitespace.

[System.OverflowException](https://docs.microsoft.com/en-us/dotnet/api/System.OverflowException 'System.OverflowException')
If the text cannot be parse because the resultant value can't be stored in an SByte

[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')
If the provided characters cannot be decoded per the current encoding..
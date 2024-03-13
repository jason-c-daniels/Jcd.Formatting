### [Jcd.Formatting](Jcd.Formatting.md 'Jcd.Formatting').[IntegerEncoder](Jcd.Formatting.IntegerEncoder.md 'Jcd.Formatting.IntegerEncoder')

## IntegerEncoder.ParseBigInteger(string) Method

Parses a string as a BigInteger

```csharp
public System.Numerics.BigInteger ParseBigInteger(string value);
```
#### Parameters

<a name='Jcd.Formatting.IntegerEncoder.ParseBigInteger(string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The text to decode

Implements [ParseBigInteger(string)](Jcd.Formatting.IIntegerParser.ParseBigInteger(string).md 'Jcd.Formatting.IIntegerParser.ParseBigInteger(string)')

#### Returns
[System.Numerics.BigInteger](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.BigInteger 'System.Numerics.BigInteger')
the decoded value

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')
If the value parameter was null

[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')
If the text is empty or whitespace.

[System.OutOfMemoryException](https://docs.microsoft.com/en-us/dotnet/api/System.OutOfMemoryException 'System.OutOfMemoryException')
If the provided characters cannot be decoded per the current encoding..

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')
If the text cannot be parse because the resultant value cause the application to exhaust
its memory.
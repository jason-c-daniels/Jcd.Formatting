### [Jcd.Formatting](Jcd_Formatting.md 'Jcd.Formatting').[IntegerEncoder](Jcd_Formatting_IntegerEncoder.md 'Jcd.Formatting.IntegerEncoder')
## IntegerEncoder.CharacterSetValuesAlwaysIncrease Field
A flag that indicates if the values of the character set are numerically increasing. Using this can allow for faster  
sorts of short numbers by NOT decoding first. (i.e. For positive numbers the text will sort the same as the number)  
```csharp
public readonly bool CharacterSetValuesAlwaysIncrease;
```
#### Field Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

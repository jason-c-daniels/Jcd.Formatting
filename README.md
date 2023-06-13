# Jcd.Formatting
A library to simplify implementing IFormatProvider and ICustomFormatter as well as arbitrary integer encoding (e.g. Base 31 if you please)

## Change Log

### 2.0 
- IIntegerParser.`TryParseXYZ` methods now use an `out` instead of taking a `ref`.
- IntegerEncoder - Case insensitive alphabets now emit uppercase letters when calling format.

[![GitHub](https://img.shields.io/github/license/jason-c-daniels/Jcd.Formatting)](https://github.com/jason-c-daniels/Jcd.Formatting/blob/main/LICENSE)
[![Build status](https://ci.appveyor.com/api/projects/status/5lhmo0cnj8wc80yn?svg=true)](https://ci.appveyor.com/project/jason-c-daniels/jcd-formatting)
[![CodeFactor Grade](https://img.shields.io/codefactor/grade/github/jason-c-daniels/Jcd.Formatting)](https://www.codefactor.io/repository/github/jason-c-daniels/jcd.formatting)

[![MyGet](https://img.shields.io/myget/jason-c-daniels/v/Jcd.Formatting?logo=nuget)](https://www.myget.org/feed/jason-c-daniels/package/nuget/Jcd.Formatting)
[![Nuget](https://img.shields.io/nuget/v/Jcd.Formatting?logo=nuget)](https://www.nuget.org/packages/Jcd.Formatting)

[![API Docs](https://img.shields.io/badge/Read-The%20API%20Documentation-blue?style=for-the-badge)](https://github.com/jason-c-daniels/Jcd.Formatting/blob/main/docs/Jcd_Formatting.md)

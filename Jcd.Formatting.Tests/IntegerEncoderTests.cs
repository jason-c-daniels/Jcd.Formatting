﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

using Jcd.Formatting.Tests.TestHelpers;
using Jcd.Reflection;

using Xunit;
using Xunit.Abstractions;

// ReSharper disable HeapView.ObjectAllocation.Evident
// ReSharper disable HeapView.BoxingAllocation
// ReSharper disable HeapView.ClosureAllocation
// ReSharper disable HeapView.DelegateAllocation

namespace Jcd.Formatting.Tests;

[SuppressMessage("Usage", "xUnit1042:The member referenced by the MemberData attribute returns untyped data rows")]
public class IntegerEncoderTests(ITestOutputHelper output)
{
   private const string NegativeDecimal           = "-29";
   private const string ElevenAsBinary            = "1011";
   private const string NonBinaryNegativeTestData = "nonbinary-pass to binary decoder, this should make it sad.";

   /// <summary>
   ///    Performs a round trip (encode, decode) using the CrockfordEncoder encoder on the provided sample data, as
   ///    BigIntegers. The encoded and decoded values must match in order to pass.
   /// </summary>
   /// <param name="number">The number to encode, then decode</param>
   [Theory]
   [MemberData(nameof(NumericMemberDataProvider.ByteList),       MemberType = typeof(NumericMemberDataProvider))]
   [MemberData(nameof(NumericMemberDataProvider.UInt16List),     MemberType = typeof(NumericMemberDataProvider))]
   [MemberData(nameof(NumericMemberDataProvider.UInt32List),     MemberType = typeof(NumericMemberDataProvider))]
   [MemberData(nameof(NumericMemberDataProvider.UInt64List),     MemberType = typeof(NumericMemberDataProvider))]
   [MemberData(nameof(NumericMemberDataProvider.SByteList),      MemberType = typeof(NumericMemberDataProvider))]
   [MemberData(nameof(NumericMemberDataProvider.Int16List),      MemberType = typeof(NumericMemberDataProvider))]
   [MemberData(nameof(NumericMemberDataProvider.Int32List),      MemberType = typeof(NumericMemberDataProvider))]
   [MemberData(nameof(NumericMemberDataProvider.Int64List),      MemberType = typeof(NumericMemberDataProvider))]
   [MemberData(nameof(NumericMemberDataProvider.BigIntegerList), MemberType = typeof(NumericMemberDataProvider))]
   public void CrockfordEncoder_BigIntegerRoundTrip_ExpectValuesMatch(object number)
   {
      var encoder = IntegerEncoders.Base32Crockford;

      if (number.IsBigIntegerType())
      {
         var encoded = encoder.Format((BigInteger) number);
         var decoded = encoder.ParseBigInteger(encoded);
         Assert.Equal(number, decoded);
      }
      else if (number.IsSignedType())
      {
         var num     = Convert.ToInt64(number);
         var encoded = encoder.Format(num);
         var decoded = encoder.ParseInt64(encoded);
         Assert.Equal(num, decoded);
      }
      else
      {
         var num     = Convert.ToUInt64(number);
         var encoded = encoder.Format(Convert.ToUInt64(number));
         var decoded = encoder.ParseUInt64(encoded);
         Assert.Equal(num, decoded);
      }
   }

   /// <summary>
   ///    Performs a round trip (encode, decode) using the Hexadecimal encoder on the provided sample data, as BigIntegers.
   ///    The encoded and decoded values must match in order to pass.
   /// </summary>
   /// <param name="number">The number to encode, then decode</param>
   [Theory]
   [MemberData(nameof(NumericMemberDataProvider.ByteList),       MemberType = typeof(NumericMemberDataProvider))]
   [MemberData(nameof(NumericMemberDataProvider.UInt16List),     MemberType = typeof(NumericMemberDataProvider))]
   [MemberData(nameof(NumericMemberDataProvider.UInt32List),     MemberType = typeof(NumericMemberDataProvider))]
   [MemberData(nameof(NumericMemberDataProvider.UInt64List),     MemberType = typeof(NumericMemberDataProvider))]
   [MemberData(nameof(NumericMemberDataProvider.SByteList),      MemberType = typeof(NumericMemberDataProvider))]
   [MemberData(nameof(NumericMemberDataProvider.Int16List),      MemberType = typeof(NumericMemberDataProvider))]
   [MemberData(nameof(NumericMemberDataProvider.Int32List),      MemberType = typeof(NumericMemberDataProvider))]
   [MemberData(nameof(NumericMemberDataProvider.Int64List),      MemberType = typeof(NumericMemberDataProvider))]
   [MemberData(nameof(NumericMemberDataProvider.BigIntegerList), MemberType = typeof(NumericMemberDataProvider))]
   public void HexadecimalEncoder_BigIntegerRoundTrip_ExpectValuesMatch(object number)
   {
      try
      {
         var encoder = IntegerEncoders.Hexadecimal;

         if (number.IsBigIntegerType())
         {
            var encoded = encoder.Format((BigInteger) number);
            var decoded = encoder.ParseBigInteger(encoded);
            Assert.Equal(number, decoded);
         }
         else if (number.IsSignedType())
         {
            var num     = Convert.ToInt64(number);
            var encoded = encoder.Format(num);
            var decoded = encoder.ParseInt64(encoded);
            Assert.Equal(num, decoded);
         }
         else
         {
            var num     = Convert.ToUInt64(number);
            var encoded = encoder.Format(Convert.ToUInt64(number));
            var decoded = encoder.ParseUInt64(encoded);
            Assert.Equal(num, decoded);
         }
      }
      catch
      {
         output.WriteLine($"Error on {number}");

         throw;
      }
   }

   /// <summary>
   ///    Performs a round trip (encode, decode) using the Hexadecimal encoder on the provided sample data, as Int64. The
   ///    encoded and decoded values must match in order to pass.
   /// </summary>
   /// <param name="number">The number to encode, then decode</param>
   [Theory]
   [MemberData(nameof(NumericMemberDataProvider.ByteList),   MemberType = typeof(NumericMemberDataProvider))]
   [MemberData(nameof(NumericMemberDataProvider.UInt16List), MemberType = typeof(NumericMemberDataProvider))]
   [MemberData(nameof(NumericMemberDataProvider.UInt32List), MemberType = typeof(NumericMemberDataProvider))]
   [MemberData(nameof(NumericMemberDataProvider.UInt64List), MemberType = typeof(NumericMemberDataProvider))]
   [MemberData(nameof(NumericMemberDataProvider.SByteList),  MemberType = typeof(NumericMemberDataProvider))]
   [MemberData(nameof(NumericMemberDataProvider.Int16List),  MemberType = typeof(NumericMemberDataProvider))]
   [MemberData(nameof(NumericMemberDataProvider.Int32List),  MemberType = typeof(NumericMemberDataProvider))]
   [MemberData(nameof(NumericMemberDataProvider.Int64List),  MemberType = typeof(NumericMemberDataProvider))]
   public void CrockfordEncoder_Int64RoundTrip_ExpectValuesMatch(object number)
   {
      var encoder = IntegerEncoders.Base32Crockford;

      if (number.IsSignedType())
      {
         var num     = Convert.ToInt64(number);
         var encoded = encoder.Format(num);
         var decoded = encoder.ParseInt64(encoded);
         Assert.Equal(num, decoded);
      }
      else
      {
         var num     = Convert.ToUInt64(number);
         var encoded = encoder.Format(Convert.ToUInt64(number));
         var decoded = encoder.ParseUInt64(encoded);
         Assert.Equal(num, decoded);
      }
   }

   /// <summary>
   ///    Validate that Constructor Returns ValidMonotonic When MonotonicAlphabetUsed.
   /// </summary>
   [Theory]
   [InlineData("0123456789", true)]
   [InlineData("0246789",    true)]
   [InlineData("1234567890", false)]
   [InlineData("10246789",   false)]
   public void Constructor_WhenGivenAnAlphabet_SetsCharacterSetValuesAlwaysIncreaseCorrectly(string alphabet,
                                                                                             bool   isAlwaysIncreasing)
   {
      var encoder = new IntegerEncoder(alphabet);
      Assert.Equal(isAlwaysIncreasing, encoder.CharacterSetValuesAlwaysIncrease);
   }

   /// <summary>
   ///    Validate that Format Returns correct hex string when given UInt64.
   /// </summary>
   [Theory]
   [MemberData(nameof(NumericMemberDataProvider.FibonacciBigIntegerList),
               MemberType =
                  typeof(NumericMemberDataProvider))]
   public void Format_WhenGivenBigInteger_ReturnsCorrectHexString(BigInteger data)
   {
      var expected = data.ToString("X").ToUpperInvariant();
      var actual   = IntegerEncoders.Hexadecimal.Format(data).ToUpperInvariant();

      // for some odd reason BigInteger zero pads its hex representation. Ensure we've stripped the leading zeros from both. We're looking for hex encoding equivalence, not string equivalence.
      Assert.Equal(expected.TrimLeadingZeros(), actual.TrimLeadingZeros());
      Assert.Equal(data,                        IntegerEncoders.Hexadecimal.ParseBigInteger(actual));
   }

   /// <summary>
   ///    Validate that Format Returns correct hex string when given UInt64.
   /// </summary>
   [Theory]
   [MemberData(nameof(NumericMemberDataProvider.FibonacciUInt64List),
               MemberType =
                  typeof(NumericMemberDataProvider))]
   public void Format_WhenGivenUInt64_ReturnsCorrectHexString(ulong data)
   {
      var expected = data.ToString("X").ToUpperInvariant();
      var actual   = IntegerEncoders.Hexadecimal.Format(data).ToUpperInvariant();
      Assert.Equal(expected, actual);
      Assert.Equal(data,     IntegerEncoders.Hexadecimal.ParseUInt64(actual));
   }

   /// <summary>
   ///    Validate that Format Returns correct hex string when given Int64.
   /// </summary>
   [Theory]
   [MemberData(nameof(NumericMemberDataProvider.FibonacciInt64List),
               MemberType =
                  typeof(NumericMemberDataProvider))]
   public void Format_WhenGivenInt64_ReturnsCorrectHexString(long data)
   {
      var expected = data.ToString("X").ToUpperInvariant();
      var actual   = IntegerEncoders.Hexadecimal.Format(data).ToUpperInvariant();
      Assert.Equal(expected, actual);
      Assert.Equal(data,     IntegerEncoders.Hexadecimal.ParseInt64(actual));
   }

   /// <summary>
   ///    Validate that Format Returns correct hex string when given UInt32.
   /// </summary>
   [Theory]
   [MemberData(nameof(NumericMemberDataProvider.FibonacciUInt32List),
               MemberType =
                  typeof(NumericMemberDataProvider))]
   public void Format_WhenGivenUInt32_ReturnsCorrectHexString(uint data)
   {
      var expected = data.ToString("X").ToUpperInvariant();
      var actual   = IntegerEncoders.Hexadecimal.Format(data).ToUpperInvariant();
      Assert.Equal(expected, actual);
      Assert.Equal(data,     IntegerEncoders.Hexadecimal.ParseUInt32(actual));
   }

   /// <summary>
   ///    Validate that Format Returns correct hex string when given Int32.
   /// </summary>
   [Theory]
   [MemberData(nameof(NumericMemberDataProvider.FibonacciInt32List),
               MemberType =
                  typeof(NumericMemberDataProvider))]
   public void Format_WhenGivenInt32_ReturnsCorrectHexString(int data)
   {
      var expected = data.ToString("X").ToUpperInvariant();
      var actual   = IntegerEncoders.Hexadecimal.Format(data).ToUpperInvariant();
      Assert.Equal(expected, actual);
      Assert.Equal(data,     IntegerEncoders.Hexadecimal.ParseInt32(actual));
   }

   /// <summary>
   ///    Validate that Format Returns correct hex string when given UInt16.
   /// </summary>
   [Theory]
   [MemberData(nameof(NumericMemberDataProvider.FibonacciUInt16List),
               MemberType =
                  typeof(NumericMemberDataProvider))]
   public void Format_WhenGivenUInt16_ReturnsCorrectHexString(ushort data)
   {
      var expected = data.ToString("X").ToUpperInvariant();
      var actual   = IntegerEncoders.Hexadecimal.Format(data).ToUpperInvariant();
      Assert.Equal(expected, actual);
      Assert.Equal(data,     IntegerEncoders.Hexadecimal.ParseUInt16(actual));
   }

   /// <summary>
   ///    Validate that Format Returns correct hex string when given Int16.
   /// </summary>
   [Theory]
   [MemberData(nameof(NumericMemberDataProvider.FibonacciInt16List),
               MemberType =
                  typeof(NumericMemberDataProvider))]
   public void Format_WhenGivenInt16_ReturnsCorrectHexString(short data)
   {
      var expected = data.ToString("X").ToUpperInvariant();
      var actual   = IntegerEncoders.Hexadecimal.Format(data).ToUpperInvariant();
      Assert.Equal(expected, actual);
      Assert.Equal(data,     IntegerEncoders.Hexadecimal.ParseInt16(actual));
   }

   /// <summary>
   ///    Validate that Format Returns correct hex string when given UInt16.
   /// </summary>
   [Theory]
   [MemberData(nameof(NumericMemberDataProvider.FibonacciByteList),
               MemberType =
                  typeof(NumericMemberDataProvider))]
   public void Format_WhenGivenByte_ReturnsCorrectHexString(byte data)
   {
      var expected = data.ToString("X").ToUpperInvariant();
      var actual   = IntegerEncoders.Hexadecimal.Format(data).ToUpperInvariant();
      Assert.Equal(expected, actual);
      Assert.Equal(data,     IntegerEncoders.Hexadecimal.ParseByte(actual));
   }

   /// <summary>
   ///    Validate that Format Returns correct hex string when given Int16. And validate round trip. (Parse)
   /// </summary>
   [Theory]
   [MemberData(nameof(NumericMemberDataProvider.FibonacciSByteList),
               MemberType =
                  typeof(NumericMemberDataProvider))]
   public void Format_WhenGivenSByte_ReturnsCorrectHexString(sbyte data)
   {
      var expected = data.ToString("X").ToUpperInvariant();
      var actual   = IntegerEncoders.Hexadecimal.Format(data).ToUpperInvariant();
      Assert.Equal(expected, actual);
      Assert.Equal(data,     IntegerEncoders.Hexadecimal.ParseSByte(actual));
   }

   /// <summary>
   ///    Validate that Format Returns correct hex string when given negative sbyte.
   /// </summary>
   [Theory]
   [MemberData(nameof(NumericMemberDataProvider.NegativeFibonacciSByteList),
               MemberType =
                  typeof(NumericMemberDataProvider))]
   public void Format_WhenGivenNegativeSByte_ReturnsCorrectHexString(sbyte data)
   {
      var abs      = (byte) Math.Abs((short) data);
      var expected = abs.ToString("X").ToUpperInvariant();
      var actual   = IntegerEncoders.Hexadecimal.Format(data).ToUpperInvariant();
      Assert.EndsWith(expected, actual);

      if (data < 0) Assert.StartsWith("-", actual);

      Assert.Equal(data, IntegerEncoders.Hexadecimal.ParseSByte(actual));
   }

   /// <summary>
   ///    Validate that Format Returns correct hex string when given negative short.
   /// </summary>
   [Theory]
   [MemberData(nameof(NumericMemberDataProvider.NegativeFibonacciInt16List),
               MemberType =
                  typeof(NumericMemberDataProvider))]
   public void Format_WhenGivenNegativeInt16_ReturnsCorrectHexString(short data)
   {
      var abs      = (ushort) Math.Abs((int) data);
      var expected = abs.ToString("X").ToUpperInvariant();
      var actual   = IntegerEncoders.Hexadecimal.Format(data).ToUpperInvariant();
      Assert.EndsWith(expected, actual);

      if (data < 0) Assert.StartsWith("-", actual);

      Assert.Equal(data, IntegerEncoders.Hexadecimal.ParseInt16(actual));
   }

   /// <summary>
   ///    Validate that Format Returns correct hex string when given negative int.
   /// </summary>
   [Theory]
   [MemberData(nameof(NumericMemberDataProvider.NegativeFibonacciInt32List),
               MemberType =
                  typeof(NumericMemberDataProvider))]
   public void Format_WhenGivenNegativeInt32_ReturnsCorrectHexString(int data)
   {
      var abs      = (uint) Math.Abs((long) data);
      var expected = abs.ToString("X").ToUpperInvariant();
      var actual   = IntegerEncoders.Hexadecimal.Format(data).ToUpperInvariant();
      Assert.EndsWith(expected, actual);

      if (data < 0) Assert.StartsWith("-", actual);

      Assert.Equal(data, IntegerEncoders.Hexadecimal.ParseInt32(actual));
   }

   /// <summary>
   ///    Validate that Format Returns correct hex string when given negative int.
   /// </summary>
   [Theory]
   [MemberData(nameof(NumericMemberDataProvider.NegativeFibonacciInt64List),
               MemberType =
                  typeof(NumericMemberDataProvider))]
   public void Format_WhenGivenNegativeInt64_ReturnsCorrectHexString(long data)
   {
      var abs      = (ulong) ((BigInteger) data * -1);
      var expected = abs.ToString("X").ToUpperInvariant();
      var actual   = IntegerEncoders.Hexadecimal.Format(data).ToUpperInvariant();
      Assert.EndsWith(expected, actual);

      if (data < 0) Assert.StartsWith("-", actual);

      Assert.Equal(data, IntegerEncoders.Hexadecimal.ParseInt64(actual));
   }

   /// <summary>
   ///    Validate that Format Returns correct hex string when given negative int.
   /// </summary>
   [Theory]
   [MemberData(nameof(NumericMemberDataProvider.NegativeFibonacciBigIntegerList),
               MemberType =
                  typeof(NumericMemberDataProvider))]
   public void Format_WhenGivenNegativeBigInteger_ReturnsCorrectHexString(BigInteger data)
   {
      var abs      = data * -1;
      var expected = abs.ToString("X").ToUpperInvariant().TrimLeadingZeros();
      var actual   = IntegerEncoders.Hexadecimal.Format(data).ToUpperInvariant();

      if (data < 0) Assert.StartsWith("-", actual);

      Assert.EndsWith(expected, actual.Replace("-", ""));
      Assert.Equal(data, IntegerEncoders.Hexadecimal.ParseBigInteger(actual));
   }

   /// <summary>
   ///    Validate that ParseByte throws ArgumentException when given characters not in the encoding scheme.
   /// </summary>
   [Theory]
   [InlineData(ElevenAsBinary,            true)]
   [InlineData(NonBinaryNegativeTestData, false)]
   public void TryParseBigInteger_WhenGivenText_ReturnsTrueWhenDecodedFalseWhenNot(string text, bool parsed)
   {
      BigInteger expectedParsedResult = 11; // BigInteger can't be const. Have to use this hack.
      Assert.Equal(parsed, IntegerEncoders.Binary.TryParseBigInteger(text, out var result));

      if (parsed) Assert.Equal(expectedParsedResult, result);
   }

   /// <summary>
   ///    Validate that ParseByte throws ArgumentException when given characters not in the encoding scheme.
   /// </summary>
   [Theory]
   [InlineData(ElevenAsBinary,            true,  11)]
   [InlineData(NonBinaryNegativeTestData, false, 0)]
   public void TryParseUInt64_WhenGivenText_ReturnsTrueWhenDecodedFalseWhenNot(string text,
                                                                               bool   parsed,
                                                                               ulong  decoded)
   {
      Assert.Equal(parsed, IntegerEncoders.Binary.TryParseUInt64(text, out var result));

      if (parsed) Assert.Equal(decoded, result);
   }

   /// <summary>
   ///    Validate that ParseSByte throws ArgumentException when given characters not in the encoding scheme.
   /// </summary>
   [Theory]
   [InlineData(ElevenAsBinary,            true,  11)]
   [InlineData(NonBinaryNegativeTestData, false, 0)]
   public void TryParseInt64_WhenGivenText_ReturnsTrueWhenDecodedFalseWhenNot(string text,
                                                                              bool   parsed,
                                                                              long   decoded)
   {
      Assert.Equal(parsed, IntegerEncoders.Binary.TryParseInt64(text, out var result));

      if (parsed) Assert.Equal(decoded, result);
   }

   /// <summary>
   ///    Validate that ParseByte throws ArgumentException when given characters not in the encoding scheme.
   /// </summary>
   [Theory]
   [InlineData(ElevenAsBinary,            true,  11)]
   [InlineData(NonBinaryNegativeTestData, false, 0)]
   public void TryParseUInt32_WhenGivenText_ReturnsTrueWhenDecodedFalseWhenNot(string text,
                                                                               bool   parsed,
                                                                               uint   decoded)
   {
      Assert.Equal(parsed, IntegerEncoders.Binary.TryParseUInt32(text, out var result));

      if (parsed) Assert.Equal(decoded, result);
   }

   /// <summary>
   ///    Validate that ParseSByte throws ArgumentException when given characters not in the encoding scheme.
   /// </summary>
   [Theory]
   [InlineData(ElevenAsBinary,            true,  11)]
   [InlineData(NonBinaryNegativeTestData, false, 0)]
   public void TryParseInt32_WhenGivenText_ReturnsTrueWhenDecodedFalseWhenNot(string text,
                                                                              bool   parsed,
                                                                              int    decoded)
   {
      Assert.Equal(parsed, IntegerEncoders.Binary.TryParseInt32(text, out var result));

      if (parsed) Assert.Equal(decoded, result);
   }

   /// <summary>
   ///    Validate that ParseByte throws ArgumentException when given characters not in the encoding scheme.
   /// </summary>
   [Theory]
   [InlineData(ElevenAsBinary,            true,  11)]
   [InlineData(NonBinaryNegativeTestData, false, 0)]
   public void TryParseUInt16_WhenGivenText_ReturnsTrueWhenDecodedFalseWhenNot(string text,
                                                                               bool   parsed,
                                                                               ushort decoded)
   {
      Assert.Equal(parsed, IntegerEncoders.Binary.TryParseUInt16(text, out var result));

      if (parsed) Assert.Equal(decoded, result);
   }

   /// <summary>
   ///    Validate that ParseSByte throws ArgumentException when given characters not in the encoding scheme.
   /// </summary>
   [Theory]
   [InlineData(ElevenAsBinary,            true,  11)]
   [InlineData(NonBinaryNegativeTestData, false, 0)]
   public void TryParseInt16_WhenGivenText_ReturnsTrueWhenDecodedFalseWhenNot(string text,
                                                                              bool   parsed,
                                                                              short  decoded)
   {
      Assert.Equal(parsed, IntegerEncoders.Binary.TryParseInt16(text, out var result));

      if (parsed) Assert.Equal(decoded, result);
   }

   /// <summary>
   ///    Validate that ParseByte throws ArgumentException when given characters not in the encoding scheme.
   /// </summary>
   [Theory]
   [InlineData(ElevenAsBinary,            true,  11)]
   [InlineData(NonBinaryNegativeTestData, false, 0)]
   public void TryParseByte_WhenGivenText_ReturnsTrueWhenDecodedFalseWhenNot(string text,
                                                                             bool   parsed,
                                                                             byte   decoded)
   {
      Assert.Equal(parsed, IntegerEncoders.Binary.TryParseByte(text, out var result));

      if (parsed) Assert.Equal(decoded, result);
   }

   /// <summary>
   ///    Validate that ParseSByte throws ArgumentException when given characters not in the encoding scheme.
   /// </summary>
   [Theory]
   [InlineData(ElevenAsBinary,            true,  11)]
   [InlineData(NonBinaryNegativeTestData, false, 0)]
   public void TryParseSByte_WhenGivenText_ReturnsTrueWhenDecodedFalseWhenNot(string text,
                                                                              bool   parsed,
                                                                              sbyte  decoded)
   {
      Assert.Equal(parsed, IntegerEncoders.Binary.TryParseSByte(text, out var result));

      if (parsed) Assert.Equal(decoded, result);
   }

   /// <summary>
   ///    Validate that Format Returns a formatted value when given a BigInteger.
   /// </summary>
   [Theory]
   [MemberData(nameof(NumericMemberDataProvider.BigIntegerList), MemberType = typeof(NumericMemberDataProvider))]
   public void Format_WhenGivenABigInteger_ReturnsFormattedValue(BigInteger data)
   {
      Assert.Equal(data.ToString(), IntegerEncoders.Decimal.Format(data));
   }

   /// <summary>
   ///    Validate that Format Returns a formatted value when given an UInt64.
   /// </summary>
   [Theory]
   [MemberData(nameof(NumericMemberDataProvider.UInt64List), MemberType = typeof(NumericMemberDataProvider))]
   public void Format_WhenGivenAUInt64_ReturnsFormattedValue(ulong data)
   {
      Assert.Equal(data.ToString(), IntegerEncoders.Decimal.Format(data));
   }

   /// <summary>
   ///    Validate that Format returns a formatted value when given an Int16.
   /// </summary>
   [Theory]
   [MemberData(nameof(NumericMemberDataProvider.Int64List), MemberType = typeof(NumericMemberDataProvider))]
   public void Format_WhenGivenAnInt64_ReturnsFormattedValue(long data)
   {
      Assert.Equal(data.ToString(), IntegerEncoders.Decimal.Format(data));
   }

   /// <summary>
   ///    Validate that Format Returns a formatted value when given an UInt32.
   /// </summary>
   [Theory]
   [MemberData(nameof(NumericMemberDataProvider.UInt32List), MemberType = typeof(NumericMemberDataProvider))]
   public void Format_WhenGivenAUInt32_ReturnsFormattedValue(uint data)
   {
      Assert.Equal(data.ToString(), IntegerEncoders.Decimal.Format(data));
   }

   /// <summary>
   ///    Validate that Format returns a formatted value when given an Int16.
   /// </summary>
   [Theory]
   [MemberData(nameof(NumericMemberDataProvider.Int32List), MemberType = typeof(NumericMemberDataProvider))]
   public void Format_WhenGivenAnInt32_ReturnsFormattedValue(int data)
   {
      Assert.Equal(data.ToString(), IntegerEncoders.Decimal.Format(data));
   }

   /// <summary>
   ///    Validate that Format Returns a formatted value when given an UInt16.
   /// </summary>
   [Theory]
   [MemberData(nameof(NumericMemberDataProvider.UInt16List), MemberType = typeof(NumericMemberDataProvider))]
   public void Format_WhenGivenAUInt16_ReturnsFormattedValue(ushort data)
   {
      Assert.Equal(data.ToString(), IntegerEncoders.Decimal.Format(data));
   }

   /// <summary>
   ///    Validate that Format returns a formatted value when given an Int16.
   /// </summary>
   [Theory]
   [MemberData(nameof(NumericMemberDataProvider.Int16List), MemberType = typeof(NumericMemberDataProvider))]
   public void Format_WhenGivenAnInt16_ReturnsFormattedValue(short data)
   {
      Assert.Equal(data.ToString(), IntegerEncoders.Decimal.Format(data));
   }

   /// <summary>
   ///    Validate that Format Returns a formatted value when given a byte.
   /// </summary>
   [Theory]
   [MemberData(nameof(NumericMemberDataProvider.ByteList), MemberType = typeof(NumericMemberDataProvider))]
   public void Format_WhenGivenAByte_ReturnsFormattedValue(byte data)
   {
      Assert.Equal(data.ToString(), IntegerEncoders.Decimal.Format(data));
   }

   /// <summary>
   ///    Validate that Format returns a formatted value when given an sbyte.
   /// </summary>
   [Theory]
   [MemberData(nameof(NumericMemberDataProvider.SByteList), MemberType = typeof(NumericMemberDataProvider))]
   public void Format_WhenGivenAnSByte_ReturnsFormattedValue(sbyte data)
   {
      Assert.Equal(data.ToString(), IntegerEncoders.Decimal.Format(data));
   }

   /// <summary>
   ///    Validate that Format Returns a formatted value when given a BigInteger.
   /// </summary>
   [Theory]
   [MemberData(nameof(NumericMemberDataProvider.BigIntegerList), MemberType = typeof(NumericMemberDataProvider))]
   public void ICustomFormatter_Format_WhenGivenABigInteger_ReturnsFormattedValue(BigInteger data)
   {
      Assert.Equal(data.ToString(), IntegerEncoders.Decimal.Format("", data, IntegerEncoders.Decimal));
   }

   /// <summary>
   ///    Validate that Format Returns a formatted value when given an UInt64.
   /// </summary>
   [Theory]
   [MemberData(nameof(NumericMemberDataProvider.UInt64List), MemberType = typeof(NumericMemberDataProvider))]
   public void ICustomFormatter_Format_WhenGivenAUInt64_ReturnsFormattedValue(ulong data)
   {
      Assert.Equal(data.ToString(), IntegerEncoders.Decimal.Format("", data, IntegerEncoders.Decimal));
   }

   /// <summary>
   ///    Validate that Format returns a formatted value when given an Int16.
   /// </summary>
   [Theory]
   [MemberData(nameof(NumericMemberDataProvider.Int64List), MemberType = typeof(NumericMemberDataProvider))]
   public void ICustomFormatter_Format_WhenGivenAnInt64_ReturnsFormattedValue(long data)
   {
      Assert.Equal(data.ToString(), IntegerEncoders.Decimal.Format("", data, IntegerEncoders.Decimal));
   }

   /// <summary>
   ///    Validate that Format Returns a formatted value when given an UInt32.
   /// </summary>
   [Theory]
   [MemberData(nameof(NumericMemberDataProvider.UInt32List), MemberType = typeof(NumericMemberDataProvider))]
   public void ICustomFormatter_Format_WhenGivenAUInt32_ReturnsFormattedValue(uint data)
   {
      Assert.Equal(data.ToString(), IntegerEncoders.Decimal.Format("", data, IntegerEncoders.Decimal));
   }

   /// <summary>
   ///    Validate that Format returns a formatted value when given an Int16.
   /// </summary>
   [Theory]
   [MemberData(nameof(NumericMemberDataProvider.Int32List), MemberType = typeof(NumericMemberDataProvider))]
   public void ICustomFormatter_Format_WhenGivenAnInt32_ReturnsFormattedValue(int data)
   {
      Assert.Equal(data.ToString(), IntegerEncoders.Decimal.Format("", data, IntegerEncoders.Decimal));
   }

   /// <summary>
   ///    Validate that Format Returns a formatted value when given an UInt16.
   /// </summary>
   [Theory]
   [MemberData(nameof(NumericMemberDataProvider.UInt16List), MemberType = typeof(NumericMemberDataProvider))]
   public void ICustomFormatter_Format_WhenGivenAUInt16_ReturnsFormattedValue(ushort data)
   {
      Assert.Equal(data.ToString(), IntegerEncoders.Decimal.Format("", data, IntegerEncoders.Decimal));
   }

   /// <summary>
   ///    Validate that Format returns a formatted value when given an Int16.
   /// </summary>
   [Theory]
   [MemberData(nameof(NumericMemberDataProvider.Int16List), MemberType = typeof(NumericMemberDataProvider))]
   public void ICustomFormatter_Format_WhenGivenAnInt16_ReturnsFormattedValue(short data)
   {
      Assert.Equal(data.ToString(), IntegerEncoders.Decimal.Format("", data, IntegerEncoders.Decimal));
   }

   /// <summary>
   ///    Validate that Format Returns a formatted value when given a byte.
   /// </summary>
   [Theory]
   [MemberData(nameof(NumericMemberDataProvider.ByteList), MemberType = typeof(NumericMemberDataProvider))]
   public void ICustomFormatter_Format_WhenGivenAByte_ReturnsFormattedValue(byte data)
   {
      Assert.Equal(data.ToString(), IntegerEncoders.Decimal.Format("", data, IntegerEncoders.Decimal));
   }

   /// <summary>
   ///    Validate that Format returns a formatted value when given an sbyte.
   /// </summary>
   [Theory]
   [MemberData(nameof(NumericMemberDataProvider.SByteList), MemberType = typeof(NumericMemberDataProvider))]
   public void ICustomFormatter_Format_WhenGivenAnSByte_ReturnsFormattedValue(sbyte data)
   {
      Assert.Equal(data.ToString(), IntegerEncoders.Decimal.Format("", data, IntegerEncoders.Decimal));
   }

   /// <summary>
   ///    Validate that Constructor throws ArgumentException when encode character set has extra characters.
   /// </summary>
   [Fact]
   public void Constructor_WhenEncodeCharacterAndDecodeCharacterMapMismatchInCount_ThrowsArgumentException()
   {
      var decodeSet = new[]
                      {
                         "0oO",
                         "1iIlL",
                         "2"
                      };

      var encodeSet = "012!";

      Assert.Throws<ArgumentException>(() => { _ = new IntegerEncoder(encodeSet, decodeSet); });

      encodeSet = "01";

      Assert.Throws<ArgumentException>(() => { _ = new IntegerEncoder(encodeSet, decodeSet); });
   }

   /// <summary>
   ///    Validate that Constructor throws ArgumentException when encode character set encodes to different value than decode
   ///    character set.
   /// </summary>
   [Fact]
   public void
      Constructor_WhenEncodeCharacterSetEncodesToDifferentValueThanDecodeCharacterSet_ThrowsArgumentException()
   {
      var decodeSet = new[]
                      {
                         "1iIlL",
                         "2",
                         "0oO"
                      };

      const string encodeSet = "012";

      Assert.Throws<ArgumentException>(() => { _ = new IntegerEncoder(encodeSet, decodeSet); });
   }

   /// <summary>
   ///    Validate that Constructor throws ArgumentException when encode character set has extra characters.
   /// </summary>
   [Fact]
   public void Constructor_WhenEncodeCharacterSetHasExtraCharacters_ThrowsArgumentException()
   {
      var decodeSet = new[]
                      {
                         "0oO",
                         "1iIlL",
                         "2"
                      };

      const string encodeSet = "0!2";

      Assert.Throws<ArgumentException>(() => { _ = new IntegerEncoder(encodeSet, decodeSet); });
   }

   /// <summary>
   ///    Validate that ParseBigInteger throws ArgumentException when given characters not in the encoding scheme.
   /// </summary>
   [Fact]
   public void ParseBigInteger_WhenGivenCharactersNotInTheEncodingScheme_ThrowsArgumentOutOfRangeException()
   {
      Assert.Throws<ArgumentOutOfRangeException>(() =>
                                                    IntegerEncoders
                                                      .Binary.ParseBigInteger(NonBinaryNegativeTestData));
   }

   /// <summary>
   ///    Validate that ParseByte throws ArgumentException when given characters not in the encoding scheme.
   /// </summary>
   [Fact]
   public void ParseByte_WhenGivenCharactersNotInTheEncodingScheme_ThrowsArgumentOutOfRangeException()
   {
      Assert.Throws<ArgumentOutOfRangeException>(
                                                 () => IntegerEncoders.Binary.ParseByte(NonBinaryNegativeTestData));
   }

   /// <summary>
   ///    Validate that ParseByte throws ArgumentException when given characters not in the encoding scheme.
   /// </summary>
   [Fact]
   public void ParseByte_WhenGivenNegativeNumber_ThrowsArgumentException()
   {
      Assert.Throws<ArgumentException>(() => IntegerEncoders.Decimal.ParseByte(NegativeDecimal));
   }

   /// <summary>
   ///    Validate that ParseByte throws an OverflowException when given too large or small of a value.
   /// </summary>
   [Fact]
   public void ParseByte_WhenGivenTooLargeOfAValue_ThrowsOverflowException()
   {
      Assert.Throws<OverflowException>(() => IntegerEncoders.Hexadecimal.ParseByte(
                                                                                   IntegerEncoders
                                                                                     .Hexadecimal
                                                                                     .Format(byte.MaxValue +
                                                                                             1)));

      Assert.Throws<OverflowException>(() =>
                                          IntegerEncoders
                                            .Hexadecimal.ParseByte(IntegerEncoders
                                                                  .Hexadecimal.Format(int.MaxValue)));
   }

   /// <summary>
   ///    Validate that ParseInt16 throws ArgumentException when given characters not in the encoding scheme.
   /// </summary>
   [Fact]
   public void ParseInt16_WhenGivenCharactersNotInTheEncodingScheme_ThrowsArgumentOutOfRangeException()
   {
      Assert.Throws<ArgumentOutOfRangeException>(() =>
                                                    IntegerEncoders.Binary.ParseInt16(NonBinaryNegativeTestData));
   }

   /// <summary>
   ///    Validate that ParseInt16 throws an OverflowException when given too large or small of a value.
   /// </summary>
   [Fact]
   public void ParseInt16_WhenGivenTooExtremeOfAValue_ThrowsOverflowException()
   {
      Assert.Throws<OverflowException>(() => IntegerEncoders.Hexadecimal.ParseInt16(
                                                                                    IntegerEncoders
                                                                                      .Hexadecimal.Format(
                                                                                                          int
                                                                                                            .MinValue)));

      Assert.Throws<OverflowException>(() => IntegerEncoders.Hexadecimal.ParseInt16(
                                                                                    IntegerEncoders
                                                                                      .Hexadecimal.Format(
                                                                                                          int
                                                                                                            .MaxValue)));

      Assert.Throws<OverflowException>(() => IntegerEncoders.Hexadecimal.ParseInt16(
                                                                                    IntegerEncoders
                                                                                      .Hexadecimal.Format(
                                                                                                          short
                                                                                                            .MinValue -
                                                                                                          1)));

      Assert.Throws<OverflowException>(() => IntegerEncoders.Hexadecimal.ParseInt16(
                                                                                    IntegerEncoders
                                                                                      .Hexadecimal.Format(
                                                                                                          short
                                                                                                            .MaxValue +
                                                                                                          1)));
   }

   /// <summary>
   ///    Validate that ParseInt32 throws ArgumentException when given characters not in the encoding scheme.
   /// </summary>
   [Fact]
   public void ParseInt32_WhenGivenCharactersNotInTheEncodingScheme_ThrowsArgumentOutOfRangeException()
   {
      Assert.Throws<ArgumentOutOfRangeException>(() =>
                                                    IntegerEncoders.Binary.ParseInt32(NonBinaryNegativeTestData));
   }

   /// <summary>
   ///    Validate that ParseInt32 throws an OverflowException when given too large or small of a value.
   /// </summary>
   [Fact]
   public void ParseInt32_WhenGivenTooExtremeOfAValue_ThrowsOverflowException()
   {
      Assert.Throws<OverflowException>(() => IntegerEncoders.Hexadecimal.ParseInt32(
                                                                                    IntegerEncoders
                                                                                      .Hexadecimal.Format(
                                                                                                          long
                                                                                                            .MinValue)));

      Assert.Throws<OverflowException>(() => IntegerEncoders.Hexadecimal.ParseInt32(
                                                                                    IntegerEncoders
                                                                                      .Hexadecimal.Format(
                                                                                                          long
                                                                                                            .MaxValue)));

      Assert.Throws<OverflowException>(() => IntegerEncoders.Hexadecimal.ParseInt16(
                                                                                    IntegerEncoders
                                                                                      .Hexadecimal.Format(
                                                                                                          int
                                                                                                            .MinValue -
                                                                                                          (long)
                                                                                                          1)));

      Assert.Throws<OverflowException>(() => IntegerEncoders.Hexadecimal.ParseInt16(
                                                                                    IntegerEncoders
                                                                                      .Hexadecimal.Format(
                                                                                                          int
                                                                                                            .MaxValue +
                                                                                                          (long)
                                                                                                          1)));
   }

   /// <summary>
   ///    Validate that ParseInt64 throws ArgumentException when given characters not in the encoding scheme.
   /// </summary>
   [Fact]
   public void ParseInt64_WhenGivenCharactersNotInTheEncodingScheme_ThrowsArgumentOutOfRangeException()
   {
      Assert.Throws<ArgumentOutOfRangeException>(() =>
                                                    IntegerEncoders.Binary.ParseInt64(NonBinaryNegativeTestData));
   }

   /// <summary>
   ///    Validate that ParseInt64 throws an OverflowException when given too large or small of a value.
   /// </summary>
   [Fact]
   public void ParseInt64_WhenGivenTooExtremeOfAValue_ThrowsOverflowException()
   {
      Assert.Throws<OverflowException>(() => IntegerEncoders.Hexadecimal.ParseInt64(
                                                                                    IntegerEncoders
                                                                                      .Hexadecimal.Format(
                                                                                                          long
                                                                                                            .MinValue -
                                                                                                          (BigInteger
                                                                                                          ) 1)));

      Assert.Throws<OverflowException>(() => IntegerEncoders.Hexadecimal.ParseInt64(
                                                                                    IntegerEncoders
                                                                                      .Hexadecimal.Format(
                                                                                                          long
                                                                                                            .MaxValue +
                                                                                                          (BigInteger
                                                                                                          ) 1)));

      Assert.Throws<OverflowException>(() => IntegerEncoders.Hexadecimal.ParseInt64(
                                                                                    IntegerEncoders
                                                                                      .Hexadecimal.Format(
                                                                                                          long
                                                                                                            .MinValue *
                                                                                                          (BigInteger
                                                                                                          ) 2)));

      Assert.Throws<OverflowException>(() => IntegerEncoders.Hexadecimal.ParseInt64(
                                                                                    IntegerEncoders
                                                                                      .Hexadecimal.Format(
                                                                                                          long
                                                                                                            .MaxValue *
                                                                                                          (BigInteger
                                                                                                          ) 2)));
   }

   /// <summary>
   ///    Validate that ParseSByte throws ArgumentException when given characters not in the encoding scheme.
   /// </summary>
   [Fact]
   public void ParseSByte_WhenGivenCharactersNotInTheEncodingScheme_ThrowsArgumentOutOfRangeException()
   {
      Assert.Throws<ArgumentOutOfRangeException>(() =>
                                                    IntegerEncoders.Binary.ParseSByte(NonBinaryNegativeTestData));
   }

   /// <summary>
   ///    Validate that ParseSByte throws an OverflowException when given too large or small of a value.
   /// </summary>
   [Fact]
   public void ParseSByte_WhenGivenTooExtremeOfAValue_ThrowsOverflowException()
   {
      Assert.Throws<OverflowException>(() => IntegerEncoders.Hexadecimal.ParseSByte(
                                                                                    IntegerEncoders
                                                                                      .Hexadecimal.Format(
                                                                                                          int
                                                                                                            .MinValue)));

      Assert.Throws<OverflowException>(() => IntegerEncoders.Hexadecimal.ParseSByte(
                                                                                    IntegerEncoders
                                                                                      .Hexadecimal.Format(
                                                                                                          int
                                                                                                            .MaxValue)));

      Assert.Throws<OverflowException>(() => IntegerEncoders.Hexadecimal.ParseSByte(
                                                                                    IntegerEncoders
                                                                                      .Hexadecimal.Format(
                                                                                                          sbyte
                                                                                                            .MinValue -
                                                                                                          1)));

      Assert.Throws<OverflowException>(() => IntegerEncoders.Hexadecimal.ParseSByte(
                                                                                    IntegerEncoders
                                                                                      .Hexadecimal.Format(
                                                                                                          sbyte
                                                                                                            .MaxValue +
                                                                                                          1)));
   }

   /// <summary>
   ///    Validate that ParseUInt16 throws ArgumentException when given characters not in the encoding scheme.
   /// </summary>
   [Fact]
   public void ParseUInt16_WhenGivenCharactersNotInTheEncodingScheme_ThrowsArgumentOutOfRangeException()
   {
      Assert.Throws<ArgumentOutOfRangeException>(() =>
                                                    IntegerEncoders.Binary.ParseUInt16(NonBinaryNegativeTestData));
   }

   /// <summary>
   ///    Validate that ParseUInt16 throws ArgumentException when given characters not in the encoding scheme.
   /// </summary>
   [Fact]
   public void ParseUInt16_WhenGivenNegativeNumber_ThrowsArgumentException()
   {
      Assert.Throws<ArgumentException>(() => IntegerEncoders.Decimal.ParseUInt16(NegativeDecimal));
   }

   /// <summary>
   ///    Validate that ParseUInt16 throws an OverflowException when given too large or small of a value.
   /// </summary>
   [Fact]
   public void ParseUInt16_WhenGivenTooLargeOfAValue_ThrowsOverflowException()
   {
      Assert.Throws<OverflowException>(() => IntegerEncoders.Hexadecimal.ParseUInt16(
                                                                                     IntegerEncoders
                                                                                       .Hexadecimal.Format(
                                                                                                           ushort
                                                                                                             .MaxValue +
                                                                                                           1)));

      Assert.Throws<OverflowException>(() => IntegerEncoders.Hexadecimal.ParseUInt16(
                                                                                     IntegerEncoders
                                                                                       .Hexadecimal.Format(
                                                                                                           int
                                                                                                             .MaxValue)));
   }

   /// <summary>
   ///    Validate that ParseUInt32 throws ArgumentException when given characters not in the encoding scheme.
   /// </summary>
   [Fact]
   public void ParseUInt32_WhenGivenCharactersNotInTheEncodingScheme_ThrowsArgumentOutOfRangeException()
   {
      Assert.Throws<ArgumentOutOfRangeException>(() =>
                                                    IntegerEncoders.Binary.ParseUInt32(NonBinaryNegativeTestData));
   }

   /// <summary>
   ///    Validate that ParseUInt32 throws ArgumentException when given characters not in the encoding scheme.
   /// </summary>
   [Fact]
   public void ParseUInt32_WhenGivenNegativeNumber_ThrowsArgumentException()
   {
      Assert.Throws<ArgumentException>(() => IntegerEncoders.Decimal.ParseUInt32(NegativeDecimal));
   }

   /// <summary>
   ///    Validate that ParseUInt32 throws an OverflowException when given too large or small of a value.
   /// </summary>
   [Fact]
   public void ParseUInt32_WhenGivenTooLargeOfAValue_ThrowsOverflowException()
   {
      Assert.Throws<OverflowException>(() => IntegerEncoders.Hexadecimal.ParseUInt16(
                                                                                     IntegerEncoders
                                                                                       .Hexadecimal.Format(
                                                                                                           uint
                                                                                                             .MaxValue +
                                                                                                           (long)
                                                                                                           1)));

      Assert.Throws<OverflowException>(() => IntegerEncoders.Hexadecimal.ParseUInt32(
                                                                                     IntegerEncoders
                                                                                       .Hexadecimal.Format(
                                                                                                           ulong
                                                                                                             .MaxValue)));
   }

   /// <summary>
   ///    Validate that ParseUInt64 throws ArgumentException when given characters not in the encoding scheme.
   /// </summary>
   [Fact]
   public void ParseUInt64_WhenGivenCharactersNotInTheEncodingScheme_ThrowsArgumentOutOfRangeException()
   {
      Assert.Throws<ArgumentOutOfRangeException>(() =>
                                                    IntegerEncoders.Binary.ParseUInt64(NonBinaryNegativeTestData));
   }

   /// <summary>
   ///    Validate that ParseUInt64 throws ArgumentException when given characters not in the encoding scheme.
   /// </summary>
   [Fact]
   public void ParseUInt64_WhenGivenNegativeNumber_ThrowsArgumentException()
   {
      Assert.Throws<ArgumentException>(() => IntegerEncoders.Decimal.ParseUInt64(NegativeDecimal));
   }

   /// <summary>
   ///    Validate that ParseUInt64 throws an OverflowException when given too large or small of a value.
   /// </summary>
   [Fact]
   public void ParseUInt64_WhenGivenTooLargeOfAValue_ThrowsOverflowException()
   {
      BigInteger overflow = ulong.MaxValue;
      overflow *= 2;
      var oft   = IntegerEncoders.Hexadecimal.Format(overflow);
      _ = overflow.ToString("X");
      Assert.Throws<OverflowException>(() => IntegerEncoders.Hexadecimal.ParseUInt64(oft));

      Assert.Throws<OverflowException>(() => IntegerEncoders.Hexadecimal.ParseUInt64(
                                                                                     IntegerEncoders
                                                                                       .Hexadecimal.Format(
                                                                                                           ulong
                                                                                                             .MaxValue +
                                                                                                           (BigInteger
                                                                                                           ) 1)));
   }
}
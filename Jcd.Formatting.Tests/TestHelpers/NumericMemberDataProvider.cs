using System;
using System.Collections.Generic;
using System.Numerics;
// ReSharper disable HeapView.BoxingAllocation
// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable HeapView.ObjectAllocation.Evident
// ReSharper disable HeapView.ObjectAllocation.Possible

// ReSharper disable LoopCanBeConvertedToQuery
// ReSharper disable UnusedMember.Global

namespace Jcd.Formatting.Tests.TestHelpers;

/// <summary>
///    An XUnit data provider. This one provides lists of numeric data of a various sorts.
/// </summary>
public class NumericMemberDataProvider
{
   /// <summary>
   ///    Provides a set of BigIntegers
   /// </summary>
   public static IEnumerable<object[]> BigIntegerList()
   {
      var biMax = new BigInteger(ulong.MaxValue) * 2;
      var biMin = new BigInteger(ulong.MinValue) * 2;
      var bi2   = new BigInteger(2);
      var bi1   = new BigInteger(1);

      yield return [biMax];
      yield return [biMin];
      yield return [bi2];
      yield return [bi1];
   }

   /// <summary>
   ///    Provides a set of Bytes
   /// </summary>
   public static IEnumerable<object[]> ByteList()
   {
      const byte two = 2;
      const byte one = 1;

      yield return [byte.MaxValue];
      yield return [byte.MinValue];
      yield return [two];
      yield return [one];
   }

   /// <summary>
   ///    Provides a set of Decimals
   /// </summary>
   public static IEnumerable<object[]> DecimalList()
   {
      const decimal two = 2;
      const decimal one = 1;

      yield return [decimal.MaxValue];
      yield return [decimal.MinValue];
      yield return [two];
      yield return [one];
   }

   /// <summary>
   ///    Provides a set of Doubles
   /// </summary>
   public static IEnumerable<object[]> DoublePrecisionFloatList()
   {
      const double two = 2;
      const double one = 1;

      yield return [double.MaxValue];
      yield return [double.MinValue];
      yield return [two];
      yield return [one];
   }

   /// <summary>
   ///    Provides a set of Int16s
   /// </summary>
   public static IEnumerable<object[]> Int16List()
   {
      const short two = 2;
      const short one = 1;

      yield return [short.MaxValue];
      yield return [short.MinValue];
      yield return [two];
      yield return [one];
   }

   /// <summary>
   ///    Provides a set of Int32s
   /// </summary>
   public static IEnumerable<object[]> Int32List()
   {
      const int two = 2;
      const int one = 1;

      yield return [int.MaxValue];
      yield return [int.MinValue];
      yield return [two];
      yield return [one];
   }

   /// <summary>
   ///    Provides a set of Int64s
   /// </summary>
   public static IEnumerable<object[]> Int64List()
   {
      const long two = 2;
      const long one = 1;

      yield return [long.MaxValue];
      yield return [long.MinValue];
      yield return [two];
      yield return [one];
   }

   /// <summary>
   ///    Provides a set of non-numeric data.
   /// </summary>
   public static IEnumerable<object[]> NonNumbersCollection()
   {
      yield return [new object()];
      yield return [new[] {1, 2, 3}];
      yield return [new Exception()];
   }

   /// <summary>
   ///    Provides a set of signed bytes
   /// </summary>
   public static IEnumerable<object[]> SByteList()
   {
      const sbyte two = 2;
      const sbyte one = 1;

      yield return [sbyte.MaxValue];
      yield return [sbyte.MinValue];
      yield return [two];
      yield return [one];
   }

   /// <summary>
   ///    Provides a set of Singles
   /// </summary>
   public static IEnumerable<object[]> SinglePrecisionFloatList()
   {
      const float two = 2;
      const float one = 1;

      yield return [float.MaxValue];
      yield return [float.MinValue];
      yield return [two];
      yield return [one];
   }

   /// <summary>
   ///    Provides a set of UInt16s
   /// </summary>
   public static IEnumerable<object[]> UInt16List()
   {
      const ushort two = 2;
      const ushort one = 1;

      yield return [ushort.MaxValue];
      yield return [ushort.MinValue];
      yield return [two];
      yield return [one];
   }

   /// <summary>
   ///    Provides a set of UInt32s
   /// </summary>
   public static IEnumerable<object[]> UInt32List()
   {
      const uint two = 2;
      const uint one = 1;

      yield return [uint.MaxValue];
      yield return [uint.MinValue];
      yield return [two];
      yield return [one];
   }

   /// <summary>
   ///    Provides a set of UInt64s
   /// </summary>
   public static IEnumerable<object[]> UInt64List()
   {
      const ulong two = 2;
      const ulong one = 1;

      yield return [ulong.MaxValue];
      yield return [ulong.MinValue];
      yield return [two];
      yield return [one];
   }

   /// <summary>
   ///    Provides a set of BigIntegers from the fibonacci sequence,
   /// </summary>
   public static IEnumerable<object[]> FibonacciBigIntegerList()
   {
      foreach (var bi in new NaiiveFibonacciGenerator(long.MaxValue * (BigInteger) 15))
      {
         yield return [bi];
      }
   }

   /// <summary>
   ///    Provides a set of UInt64s from the fibonacci sequence,
   /// </summary>
   public static IEnumerable<object[]> FibonacciUInt64List()
   {
      foreach (var bi in new NaiiveFibonacciGenerator(ulong.MaxValue))
      {
         var v = (ulong) bi;

         yield return [v];
      }
   }

   /// <summary>
   ///    Provides a set of Int64s from the fibonacci sequence,
   /// </summary>
   public static IEnumerable<object[]> FibonacciInt64List()
   {
      foreach (var bi in new NaiiveFibonacciGenerator(long.MaxValue))
      {
         var v = (long) bi;

         yield return [v];
      }
   }

   /// <summary>
   ///    Provides a set of UInt32s from the fibonacci sequence,
   /// </summary>
   public static IEnumerable<object[]> FibonacciUInt32List()
   {
      foreach (var bi in new NaiiveFibonacciGenerator(uint.MaxValue))
      {
         var v = (uint) bi;

         yield return [v];
      }
   }

   /// <summary>
   ///    Provides a set of Int32s from the fibonacci sequence,
   /// </summary>
   public static IEnumerable<object[]> FibonacciInt32List()
   {
      foreach (var bi in new NaiiveFibonacciGenerator(int.MaxValue))
      {
         var v = (int) bi;

         yield return [v];
      }
   }

   /// <summary>
   ///    Provides a set of UInt16s from the fibonacci sequence,
   /// </summary>
   public static IEnumerable<object[]> FibonacciUInt16List()
   {
      foreach (var bi in new NaiiveFibonacciGenerator(ushort.MaxValue))
      {
         var v = (ushort) bi;

         yield return [v];
      }
   }

   /// <summary>
   ///    Provides a set of Int16s from the fibonacci sequence,
   /// </summary>
   public static IEnumerable<object[]> FibonacciInt16List()
   {
      foreach (var bi in new NaiiveFibonacciGenerator(short.MaxValue))
      {
         var v = (short) bi;

         yield return [v];
      }
   }

   /// <summary>
   ///    Provides a set of Bytes from the fibonacci sequence,
   /// </summary>
   public static IEnumerable<object[]> FibonacciByteList()
   {
      foreach (var bi in new NaiiveFibonacciGenerator(byte.MaxValue))
      {
         var v = (byte) bi;

         yield return [v];
      }
   }

   /// <summary>
   ///    Provides a set of SBytes from the fibonacci sequence,
   /// </summary>
   public static IEnumerable<object[]> FibonacciSByteList()
   {
      foreach (var bi in new NaiiveFibonacciGenerator(sbyte.MaxValue))
      {
         var v = (sbyte) bi;

         yield return [v];
      }
   }

   /// <summary>
   ///    Provides a set of SBytes from the negative fibonacci sequence,
   /// </summary>
   public static IEnumerable<object[]> NegativeFibonacciSByteList()
   {
      foreach (var bi in new NegativeNaiiveFibonacciGenerator(sbyte.MinValue))
      {
         var v = (sbyte) bi;

         yield return [v];
      }
   }

   /// <summary>
   ///    Provides a set of Int16s from the negative fibonacci sequence,
   /// </summary>
   public static IEnumerable<object[]> NegativeFibonacciInt16List()
   {
      foreach (var bi in new NegativeNaiiveFibonacciGenerator(short.MinValue))
      {
         var v = (short) bi;

         yield return [v];
      }
   }

   /// <summary>
   ///    Provides a set of Int32s from the negative fibonacci sequence,
   /// </summary>
   public static IEnumerable<object[]> NegativeFibonacciInt32List()
   {
      foreach (var bi in new NegativeNaiiveFibonacciGenerator(int.MinValue))
      {
         var v = (int) bi;

         yield return [v];
      }
   }

   /// <summary>
   ///    Provides a set of Int64s from the negative fibonacci sequence,
   /// </summary>
   public static IEnumerable<object[]> NegativeFibonacciInt64List()
   {
      foreach (var bi in new NegativeNaiiveFibonacciGenerator(long.MinValue))
      {
         var v = (long) bi;

         yield return [v];
      }
   }

   /// <summary>
   ///    Provides a set of BigIntegers from the negative fibonacci sequence,
   /// </summary>
   public static IEnumerable<object[]> NegativeFibonacciBigIntegerList()
   {
      foreach (var bi in new NegativeNaiiveFibonacciGenerator(long.MinValue * (BigInteger) 15))
      {
         yield return [bi];
      }
   }
}
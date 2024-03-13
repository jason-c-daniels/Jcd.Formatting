using System;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection;
// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable HeapView.BoxingAllocation

// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global

namespace Jcd.Formatting.Tests.TestHelpers;

/// <summary>
/// An XUnit data provider. This one provides lists of numeric data of a various sorts.
/// </summary>
public class ScalarDataProvider
{
   /// <summary>
   /// Provides a set of BigIntegers
   /// </summary>
   public static IEnumerable<object[]> AllScalars()
   {
      var biMax = new BigInteger(ulong.MaxValue) * 2;
      Uri.TryCreate("http://google.com", UriKind.Absolute, out var uri);
      yield return [typeof(int)];
      yield return [null];
      yield return [biMax];
      yield return [BindingFlags.CreateInstance];
      yield return [byte.MaxValue];
      yield return [short.MaxValue];
      yield return [int.MaxValue];
      yield return [long.MaxValue];
      yield return [byte.MaxValue];
      yield return [ushort.MaxValue];
      yield return [uint.MaxValue];
      yield return [ulong.MaxValue];
      yield return [DateTime.Now];
      yield return [DateTimeOffset.Now];
      yield return [TimeSpan.MaxValue];
      yield return [uri];
      yield return [Guid.Empty];
      yield return ["a string"];
   }
}
﻿using System;
using System.Collections.Generic;

using Jcd.Formatting;

using Xunit;

namespace Jcd.Formatting.Tests
{
   public class CustomFormatterBaseTests
   {
      private const string FakeFormattedResult = "result";

      private static FakeCustomFormatter CreateSut()
      {
         return new FakeCustomFormatter(FakeFormattedResult,
                                        FakeCustomFormatter.HandledTypes,
                                        FakeCustomFormatter.Format);
      }

      /// <inheritdoc />
      /// <summary>
      ///    A helper class that yields a fixed result for any calls to format
      /// </summary>
      public class FakeCustomFormatter : CustomFormatterBase
      {
         #region Public Fields

         /// <summary>
         ///    The types of data this fake formatter will handle
         /// </summary>
         public static readonly Type[] HandledTypes = {typeof(int), typeof(float)};

         #endregion Public Fields

         #region Protected Fields

         protected readonly string FormatResult;

         #endregion Protected Fields

         #region Public Constructors

         public FakeCustomFormatter(string formatResult,
                                    IEnumerable<Type> handledTypes = null,
                                    Func<ICustomFormatter, string, object, IFormatProvider, string> formatFunction =
                                       null)
            : base(
                   handledTypes,
                   formatFunction)
         {
            FormatResult = formatResult;
         }

         #endregion Public Constructors

         #region Public Methods

         public static string Format(ICustomFormatter formatter, string fmt, object arg, IFormatProvider fmtProvider)
         {
            if (formatter is FakeCustomFormatter self) return self.FormatResult;

            return null;
         }

         #endregion Public Methods
      }

      /// <summary>
      ///    Validate that the Constructor throws an ArgumentException when passing an empty set of handled types.
      /// </summary>
      [Fact]
      public void Constructor_WhenGivenEmptyHandledTypes_ThrowsArgumentNullException()
      {
         Assert.Throws<ArgumentNullException>(() => new FakeCustomFormatter(null, new Type[] { }));
      }

      /// <summary>
      ///    Validate that the Constructor throws an ArgumentNullException when passing any null parameters.
      /// </summary>
      [Fact]
      public void Constructor_WhenGivenNullParams_ThrowsArgumentNullException()
      {
         Assert.Throws<ArgumentNullException>(() => new FakeCustomFormatter(null));
         Assert.Throws<ArgumentNullException>(() => new FakeCustomFormatter(""));
         Assert.Throws<ArgumentNullException>(() => new FakeCustomFormatter("", new[] {typeof(int)}));

         Assert.Throws<ArgumentNullException>(() => new FakeCustomFormatter("",
                                                                            null,
                                                                            FakeCustomFormatter.Format));
      }

      /// <summary>
      ///    Validate that Format Returns default format for an unhandled data type
      /// </summary>
      [Fact]
      public void Format_WhenGivenHandledType_ReturnsFormattedResult()
      {
         // setup
         var sut = CreateSut();
         const int arg = 9;

         // act
         var result = sut.Format("", arg, sut);

         // assert
         Assert.Equal(FakeFormattedResult, result);
      }

      /// <summary>
      ///    Validate that Format returns "ToString" when given non-null non-formattable arg.
      /// </summary>
      [Fact]
      public void Format_WhenGivenNonNullNonFormattableArg_ReturnsToString()
      {
         var arg = new List<int>();
         var sut = CreateSut();
         Assert.Equal(arg.ToString(), sut.Format("", arg, sut));
      }

      /// <summary>
      ///    Validate that Format returns empty string when given null arg.
      /// </summary>
      [Fact]
      public void Format_WhenGivenNullArg_ReturnsEmptyString()
      {
         var sut = CreateSut();
         Assert.Empty(sut.Format("", null, sut));
      }

      /// <summary>
      ///    Validate that the Format throws ArgumentNullException when given null arguments for format or format provider.
      /// </summary>
      [Fact]
      public void Format_WhenGivenNullParameters_ThrowsArgumentNullException()
      {
         var sut = CreateSut();
         Assert.Throws<ArgumentNullException>(() => sut.Format("", new object(), null));
         Assert.Throws<ArgumentNullException>(() => sut.Format(null, new object(), sut));
      }

      /// <summary>
      ///    Validate that Format Returns default format for an unhandled data type
      /// </summary>
      [Fact]
      public void Format_WhenGivenUnhandledType_ReturnsDefaultFormat()
      {
         // setup
         var sut = CreateSut();
         long arg = 9;

         // act
         var result = sut.Format("", arg, sut);

         // assert
         Assert.Equal("9", result);
      }

      /// <summary>
      ///    Validate that Format Returns default format for an unhandled data type
      /// </summary>
      [Fact]
      public void Format_WhenGivenWrongFormatProvider_ReturnsNull()
      {
         // setup
         var sut = CreateSut();
         var otherCustomFormatter = IntegerEncoders.Decimal;
         var arg = (long) 9;

         // act
         // assert
         Assert.Null(sut.Format("", arg, otherCustomFormatter));
      }

      /// <summary>
      ///    Validate that GetFormat returns itself when given custom formatter type.
      /// </summary>
      [Fact]
      public void GetFormat_WhenGivenCustomFormatterType_ReturnsSelf()
      {
         var sut = CreateSut();
         Assert.Same(sut, sut.GetFormat(typeof(ICustomFormatter)));
      }

      /// <summary>
      ///    Validate that GetFormat returns null when given non-custom formatter type.
      /// </summary>
      [Fact]
      public void GetFormat_WhenGivenNonCustomFormatterType_ReturnsNull()
      {
         var sut = CreateSut();
         Assert.Null(sut.GetFormat(typeof(int)));
      }

      /// <summary>
      ///    Validate that GetFormat throws ArgumentNullException when given null format type.
      /// </summary>
      [Fact]
      public void GetFormat_WhenGivenNullFormatType_ThrowsArgumentNullException()
      {
         var sut = CreateSut();
         Assert.Throws<ArgumentNullException>(() => sut.GetFormat(null));
      }
   }
}

﻿using System;
using System.Collections.Generic;
using System.Globalization;

using Jcd.Validations;

// ReSharper disable HeapView.ObjectAllocation.Possible
// ReSharper disable HeapView.ObjectAllocation

// ReSharper disable HeapView.ObjectAllocation.Evident

namespace Jcd.Formatting;

/// <inheritdoc cref="IFormatProvider" />
/// <inheritdoc cref="ICustomFormatter" />
/// <summary>
///    A base class to simplify custom formatter implementation by requiring the implementer to only
///    provide an array of handled types, and a formatting function.
/// </summary>
public abstract class CustomFormatterBase : IFormatProvider, ICustomFormatter
{
   #region Protected Fields

   /// <summary>
   ///    Default type comparison
   /// </summary>
   // ReSharper disable once UnusedMember.Global
   protected readonly MyTypeComparer TypeComparer = new();

   #endregion Protected Fields

   #region Protected Constructors

   /// <summary>
   ///    Constructs a custom formatter, and enforces some common rules.
   /// </summary>
   /// <param name="handledTypes">The data types the derived type will handle.</param>
   /// <param name="formatFunction">
   ///    The formatting function, provided by the derived type, abiding by the
   ///    CustomFormattingFunction signature
   /// </param>
   protected CustomFormatterBase(IEnumerable<Type>                                               handledTypes,
                                 Func<ICustomFormatter, string, object, IFormatProvider, string> formatFunction)
   {
      // ReSharper disable once AssignNullToNotNullAttribute
      this.handledTypes   = [..Argument.IsNotNull(handledTypes, nameof(handledTypes))];
      this.formatFunction = Argument.IsNotNull(formatFunction, nameof(formatFunction));
   }

   #endregion Protected Constructors

   #region Private Methods

   private static string HandleOtherFormats(string format, object arg)
   {
      if (arg is IFormattable formattable) return formattable.ToString(format, CultureInfo.CurrentCulture);

      return arg != null ? arg.ToString() : string.Empty;
   }

   #endregion Private Methods

   #region Protected Classes

   /// <inheritdoc />
   /// <summary>
   ///    Compares types by name.
   /// </summary>
   protected class MyTypeComparer : IComparer<Type>
   {
      #region Public Methods

      /// <summary>
      ///    Performs a comparison between two types.
      /// </summary>
      /// <param name="x">the left side of the comparison</param>
      /// <param name="y">the right ride of the comparison</param>
      /// <returns>-1 if x is less than y, 1 if x is greater than y, 0 if equal.</returns>
      public int Compare(Type x, Type y)
      {
         return string.Compare(x?.ToString(), y?.ToString(), StringComparison.InvariantCulture);
      }

      #endregion Public Methods
   }

   #endregion Protected Classes

   #region Private Fields

   private readonly Func<ICustomFormatter, string, object, IFormatProvider, string> formatFunction;

   private readonly HashSet<Type> handledTypes;

   #endregion Private Fields

   #region Public Methods

   /// <inheritdoc />
   /// <summary>
   /// </summary>
   /// <param name="fmt"></param>
   /// <param name="arg"></param>
   /// <param name="formatProvider"></param>
   /// <returns></returns>
   public virtual string Format(string fmt, object arg, IFormatProvider formatProvider)
   {
      Argument.IsNotNull(formatProvider, nameof(formatProvider));
      //Argument.IsNotNull(fmt, nameof(fmt));

      if (!ReferenceEquals(this, formatProvider)) return null;

      // ReSharper disable once ConvertIfStatementToReturnStatement
      if (handledTypes.Contains(arg == null ? typeof(object) : arg.GetType()))
      {
         return formatFunction(this, fmt, arg, formatProvider);
      }
         
      return HandleOtherFormats(fmt, arg);
   }

   /// <inheritdoc />
   /// <summary>
   ///    Gets the format object. (this)
   /// </summary>
   /// <param name="formatType">The data type for the format type</param>
   /// <returns>this if custom formatting requested.</returns>
   public virtual object GetFormat(Type formatType)
   {
      Argument.IsNotNull(formatType);

      return formatType == typeof(ICustomFormatter) ? this : null;
   }

   #endregion Public Methods
}
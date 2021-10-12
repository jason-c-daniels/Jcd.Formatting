using System;
using System.Collections.Generic;

namespace Jcd.Formatting.Examples
{
    public class CustomFormatter : CustomFormatterBase
    {
        public CustomFormatter() : this(new []{typeof(int)}, FormatIt) {}

        private CustomFormatter(IEnumerable<Type> handledTypes, 
                                Func<ICustomFormatter, string, object, IFormatProvider, string> formatFunction) 
            : base(handledTypes, formatFunction)
        {
        }

        private static string FormatIt(ICustomFormatter fmt, string fmtStr, object item, IFormatProvider provider)
        {
            return "prefixed from CustomFormatter" + item.ToString();
        }
    }
}
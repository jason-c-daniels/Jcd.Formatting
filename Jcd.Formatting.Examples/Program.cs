using System;

namespace Jcd.Formatting.Examples
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var anInt = int.MaxValue / 5;
            Console.WriteLine($"{anInt} as Base32 {IntegerEncoders.Base32.Format(anInt)}");
            Console.WriteLine($"{anInt} as Base36 {IntegerEncoders.Base36.Format(anInt)}");
            Console.WriteLine($"{anInt} as Base32Zrtp {IntegerEncoders.Base32Zrtp.Format(anInt)}");
            Console.WriteLine($"{anInt} as Base32Rfc4648 {IntegerEncoders.Base32Rfc4648.Format(anInt)}");
            Console.WriteLine($"{anInt} as Base64 {IntegerEncoders.Base64.Format(anInt)}");
            Console.WriteLine($"{anInt} as Base64Uuencoding {IntegerEncoders.Base64Uuencoding.Format(anInt)}");

            var formatter = new CustomFormatter();
            Console.WriteLine(string.Format(formatter,"{0}", anInt));
            Console.WriteLine("{0} {1}",anInt,string.Format(IntegerEncoders.Base64Uuencoding, " as Base64Uuencoding {0}", anInt));
        }
    }
}
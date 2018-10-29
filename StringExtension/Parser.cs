using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringExtension.Converters;

namespace StringExtension
{
    /// <summary>
    /// Provides the extension method for string class to parse string in some base to its' base 10 integer number
    /// </summary>
    public static class Parser
    {
        /// <summary>
        /// Parses string in some base (from 2 to 16) to its' base 10 integer number
        /// </summary>
        /// <param name="source">String in base @base</param>
        /// <param name="base">Base of string</param>
        /// <returns>Positive integer number</returns>
        /// <exception cref="ArgumentNullException">Source string is null</exception>
        /// <exception cref="ArgumentOutOfRangeException">Value of base isn't from 2 to 16</exception>
        /// <exception cref="OverflowException">Can't parse to positive integer</exception>
        /// <exception cref="ArithmeticException">Source string contains invalid chars</exception>
        public static int ToDecimal(this string source, int @base)
        {
            if (source == null)
            {
                throw new ArgumentNullException();
            }
            if (@base <= 1)
            {
                throw new ArgumentOutOfRangeException();
            }

            return (new Converter()).Convert(source, @base);
        }
    }
}

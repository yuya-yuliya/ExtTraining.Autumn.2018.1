using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtension.Converters
{
    /// <summary>
    /// Provides method to convert string notation of positive number in some base (from 2 to 16) to integer number in base 10
    /// </summary>
    public class Converter : IConverter
    {
        /// <summary>
        /// The dictionary of chars and its' eqvivalents in base 10
        /// </summary>
        private Dictionary<char, int> baseCharIntPairs = new Dictionary<char, int>
        {
            ['0'] = 0,
            ['1'] = 1,
            ['2'] = 2,
            ['3'] = 3,
            ['4'] = 4,
            ['5'] = 5,
            ['6'] = 6,
            ['7'] = 7,
            ['8'] = 8,
            ['9'] = 9,
            ['A'] = 10,
            ['B'] = 11,
            ['C'] = 12,
            ['D'] = 13,
            ['E'] = 14,
            ['F'] = 15
        };

        /// <summary>
        /// Converts string notation of positive number in some base (from 2 to 16) to integer number in base 10
        /// </summary>
        /// <param name="source">String notation of positive number in base systemBase</param>
        /// <param name="systemBase">Base from 2 to 16</param>
        /// <returns>Positive integer number</returns>
        public int Convert(string source, int systemBase)
        {
            if (baseCharIntPairs.Count < systemBase || systemBase <= 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (source == null)
            {
                throw new ArgumentException();
            }

            Dictionary<char, int> curBaseChrIntPairs = new Dictionary<char, int>();
            for (int i = 0; i < systemBase; i++)
            {
                KeyValuePair<char, int> keyValue = baseCharIntPairs.First((pair) => pair.Value == i);
                curBaseChrIntPairs.Add(keyValue.Key, keyValue.Value);
            }
            return Convert(systemBase, curBaseChrIntPairs, source);
        }

        /// <summary>
        /// Converts string notation of positive number in some base to integer number in base 10 using dictionary
        /// </summary>
        /// <param name="systemBase">Native base of string representation</param>
        /// <param name="baseCharIntPairs">Dictionary of char of base and its' base 10 eqvivalent</param>
        /// <param name="source">String notation of positive number in base systemBase</param>
        /// <returns>Positive integer number</returns>
        private int Convert(int systemBase, Dictionary<char, int> baseCharIntPairs, string source)
        {
            if (baseCharIntPairs.Count != systemBase)
            {
                throw new ArgumentOutOfRangeException();
            }
            
            source = source.ToUpper();
            int number = 0;
            for (int i = 0; i < source.Length; i++)
            {
                int baseNumber;
                try
                {
                    baseNumber = baseCharIntPairs[source[i]];
                }
                catch (KeyNotFoundException)
                {
                    throw new ArgumentException("");
                }
                number = checked(number * systemBase + baseNumber);
            }
            return number;
        }
    }
}

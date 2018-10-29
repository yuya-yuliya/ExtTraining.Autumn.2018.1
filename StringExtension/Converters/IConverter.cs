using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtension.Converters
{
    /// <summary>
    /// Provides method to convert string notation of positive number in some base to integer number in base 10
    /// </summary>
    public interface IConverter
    {
        /// <summary>
        /// Converts string notation of positive number in some base to integer number in base 10
        /// </summary>
        /// <param name="source">String notation of positive number in base systemBase</param>
        /// <param name="systemBase">Some base</param>
        /// <returns>Positive integer number</returns>
        int Convert(string source, int systemBase);
    }
}

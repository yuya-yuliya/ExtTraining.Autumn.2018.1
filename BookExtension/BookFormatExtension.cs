using System;
using System.Globalization;
using BookLibrary;

namespace BookExtension
{
    /// <summary>
    /// Provides extension method for Book class to get formatting string in shop format
    /// </summary>
    public class BookFormatExtension : ICustomFormatter, IFormatProvider
    {
        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            if (formatProvider == null)
            {
                formatProvider = CultureInfo.CurrentCulture;
            }

            if (arg.GetType() != typeof(Book))
            {
                try
                {
                    return HandleOtherFormats(format, arg, formatProvider);
                }
                catch (FormatException ex)
                {
                    throw new FormatException($"The {format} format string is not supported.", ex);
                }
            }

            Book book = (Book)arg;
            if (format.ToUpper() == "SH")
            {
                return $"Book record: {book.Title}, " +
                $"{book.Author}, " +
                $"{book.Year}, " +
                $"{book.Pages}, " +
                $"{book.Price.ToString("C0", formatProvider)}";
            }
            else
            {
                try
                {
                    return HandleOtherFormats(format, arg, formatProvider);
                }
                catch (FormatException ex)
                {
                    throw new FormatException($"The {format} format string is not supported.", ex);
                }
            }
        }

        private string HandleOtherFormats(string format, object arg, IFormatProvider formatProvider)
        {
            if (formatProvider == null)
            {
                formatProvider = CultureInfo.CurrentCulture;
            }

            if (arg is IFormattable)
                return ((IFormattable)arg).ToString(format, formatProvider);
            else if (arg != null)
                return arg.ToString();
            else
                return string.Empty;
        }

        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
            {
                return this;
            }
            else
            {
                return null;
            }
        }
    }
}

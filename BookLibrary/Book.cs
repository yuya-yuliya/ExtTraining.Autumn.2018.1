using System;
using System.Globalization;

namespace BookLibrary
{
    public class Book : IFormattable
    { 
        private int year;
        private int pages;
        private double price;
        private int edition;

        public string Author { get; set; }
        public string Title { get; set; }
        public string PublishingHous { get; set; }
        public int Year
        {
            get => year;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Year must be positive number");
                }
                year = value;
            }
        }
        public int Pages
        {
            get => pages;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Count pages must be positive number");
                }
                pages = value;
            }
        }
        public double Price
        {
            get => price;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price must be positive number");
                }
                price = value;
            }
        }
        public int Edition
        {
            get => edition;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Edition must be positive number");
                }
                edition = value;
            }
        }

        public override string ToString()
        {
            return ToString("G", CultureInfo.CurrentCulture);
        }

        public string ToString(string format)
        {
            return ToString(format, CultureInfo.CurrentCulture);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (string.IsNullOrEmpty(format))
            {
                format = "G";
            }

            if (formatProvider == null)
            {
                formatProvider = CultureInfo.CurrentCulture;
            }

            switch (format.ToUpperInvariant())
            {
                case "G":
                case "F":
                    return $"Book record: {Title}, {Author}, {Edition.ToString(formatProvider)}, {Year}, {PublishingHous}, {Pages}, {Price.ToString("C0", formatProvider)}";
                case "C":
                    return $"Book record: {Title}, {Author}, {Edition.ToString(formatProvider)}";
                case "P":
                    return $"Book record: {Title}, {Edition.ToString(formatProvider)}, {Year}, {PublishingHous}";
                case "S":
                    return $"Book record: {Title}, {Author}, {Year}";
                default:
                    throw new FormatException($"The {format} format string is not supported.");
            }
        }
    }
}

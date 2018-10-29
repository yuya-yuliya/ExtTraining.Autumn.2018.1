using BookLibrary.Fabric;
using System;

namespace BookLibrary
{
    public class Book
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

        public string ToFullFormatString()
        {
            return new FullFormatFabric().CreateFormatter().GetFormatString(this);
        }

        public string ToCoverFormatString()
        {
            return new CoverFormatFabric().CreateFormatter().GetFormatString(this);
        }

        public string ToPublishingFormatString()
        {
            return new PublishingFormatFabric().CreateFormatter().GetFormatString(this);
        }

        public string ToSimpleFormatString()
        {
            return new SimpleFormatFabric().CreateFormatter().GetFormatString(this);
        }
    }
}

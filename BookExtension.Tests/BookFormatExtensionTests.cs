using NUnit.Framework;
using BookLibrary;

namespace BookExtension.Tests
{
    [TestFixture]
    public class BookFormatExtensionTests
    {
        public Book book = new Book()
        {
            Title = "C# in Depth",
            Author = "Jon Skeet",
            Year = 2019,
            PublishingHous = "Manning",
            Edition = 4,
            Pages = 900,
            Price = 40
        };

        [TestCase(ExpectedResult = "Book record: C# in Depth, Jon Skeet, 2019, 900, 40 ₽")]
        public string ToShopFormatString_ValidResult() =>
            string.Format(new BookFormatExtension(), "{0:SH}", book);

        [TestCase(ExpectedResult = "Book record: C# in Depth, Jon Skeet, 2019")]
        public string ToFormatString_OldFormat_ValidResult() =>
            string.Format(new BookFormatExtension(), "{0:S}", book);
    }
}

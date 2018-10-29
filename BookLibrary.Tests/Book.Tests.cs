using NUnit.Framework;

namespace BookLibrary.Tests
{
    [TestFixture]
    public class Book_Tests
    {
        public Book book = new Book() {
            Title = "C# in Depth",
            Author = "Jon Skeet",
            Year = 2019,
            PublishingHous = "Manning",
            Edition = 4,
            Pages = 900,
            Price = 40 };

        [TestCase(ExpectedResult = "Book record: C# in Depth, Jon Skeet, 4, 2019, Manning, 900, 40")]
        public string ToFullFormatString_ValidResult() =>
            book.ToFullFormatString();

        [TestCase(ExpectedResult = "Book record: C# in Depth, Jon Skeet, 4")]
        public string ToCoverFormatString_ValidResult() =>
            book.ToCoverFormatString();

        [TestCase(ExpectedResult = "Book record: C# in Depth, 2019, Manning")]
        public string ToPublishingFormatString_ValidResult() =>
            book.ToPublishingFormatString();

        [TestCase(ExpectedResult = "Book record: C# in Depth, Jon Skeet, 2019")]
        public string ToSimpleFormatString_ValidResult() =>
            book.ToSimpleFormatString();

    }
}

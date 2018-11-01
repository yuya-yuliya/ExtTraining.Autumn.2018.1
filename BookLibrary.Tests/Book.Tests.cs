using NUnit.Framework;
using System;

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

        [TestCase("F", ExpectedResult = "Book record: C# in Depth, Jon Skeet, 4, 2019, Manning, 900, 40 ₽")]
        [TestCase("C", ExpectedResult = "Book record: C# in Depth, Jon Skeet, 4")]
        [TestCase("P", ExpectedResult = "Book record: C# in Depth, 4, 2019, Manning")]
        [TestCase("S", ExpectedResult = "Book record: C# in Depth, Jon Skeet, 2019")]
        public string ToString_ValidArgument_ValidResult(string format) =>
            book.ToString(format);

        [TestCase]
        public void ToString_WrongFormatString_ThrowsFormatException() =>
            Assert.Throws<FormatException>(() => book.ToString("A"));
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        [Test]
        public void ToShopFormatString_NullBook_ThrowsArgumentNullException()
            => Assert.Throws<ArgumentNullException>(() => ((Book)null).ToShopFormatString());

        [TestCase(ExpectedResult = "Book record: C# in Depth, Jon Skeet, 2019, 900, 40 ₽")]
        public string ToShopFormatString_ValidResult() =>
            book.ToShopFormatString();
    }
}

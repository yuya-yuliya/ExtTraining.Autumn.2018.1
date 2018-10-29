using BookLibrary;
using BookLibrary.Formatters;

namespace BookExtension
{
    /// <summary>
    /// Provides method to get formatting string of Book class instance in shop format
    /// </summary>
    public class ShopFormatter : IBookFormatter
    {
        /// <summary>
        /// Gets foramatting string of Book class instance in shop format
        /// </summary>
        /// <param name="book">The book class instance to get formatting string</param>
        /// <returns>String that represents the Book class instance in shop format</returns>
        public string GetFormatString(Book book)
        {
            return $"Book record: {book.Title}, " +
                $"{book.Author}, " +
                $"{book.Year}, " +
                $"{book.Pages}, " +
                $"{book.Price.ToString("C0")}";
        }
    }
}

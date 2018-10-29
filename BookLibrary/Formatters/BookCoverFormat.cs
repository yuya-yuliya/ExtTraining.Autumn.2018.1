namespace BookLibrary.Formatters
{
    /// <summary>
    /// Provides method to get formatting string of Book class instance in book cover format
    /// </summary>
    public class BookCoverFormat : IBookFormatter
    {
        /// <summary>
        /// Gets foramatting string of Book class instance in book cover format
        /// </summary>
        /// <param name="book">The book class instance to get formatting string</param>
        /// <returns>String that represents the Book class instance in book cover format</returns>
        public string GetFormatString(Book book)
        {
            return $"Book record: {book.Title}, " +
                $"{book.Author}, " +
                $"{book.Edition}";
        }
    }
}

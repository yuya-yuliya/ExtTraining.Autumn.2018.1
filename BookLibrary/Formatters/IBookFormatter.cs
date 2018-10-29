namespace BookLibrary.Formatters
{
    /// <summary>
    /// Provides method to get formatting string of Book class instance
    /// </summary>
    public interface IBookFormatter
    {
        /// <summary>
        /// Gets foramatting string of Book class instance
        /// </summary>
        /// <param name="book">The book class instance to get formatting string</param>
        /// <returns>String that represents the Book class instance</returns>
        string GetFormatString(Book book);
    }
}

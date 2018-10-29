using System;
using BookLibrary;

namespace BookExtension
{
    /// <summary>
    /// Provides extension method for Book class to get formatting string in shop format
    /// </summary>
    public static class BookFormatExtension
    {
        /// <summary>
        /// Get formatting string in shop format
        /// </summary>
        /// <param name="book"></param>
        /// <returns>String in shop format</returns>
        public static string ToShopFormatString(this Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException();
            }
            return new ShopFormatFabric().CreateFormatter().GetFormatString(book);
        }
    }
}

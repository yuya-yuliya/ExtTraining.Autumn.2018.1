using BookLibrary.Fabric;
using BookLibrary.Formatters;

namespace BookExtension
{
    /// <summary>
    /// Provides method for creating ShopFormatter class instance
    /// </summary>
    public class ShopFormatFabric : IFormatterFabric
    {
        /// <summary>
        /// Creates new instance of ShopFormatter class
        /// </summary>
        /// <returns>New instance of ShopFormatter class</returns>
        public IBookFormatter CreateFormatter()
        {
            return new ShopFormatter();
        }
    }
}

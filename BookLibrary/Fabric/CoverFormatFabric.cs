using BookLibrary.Formatters;

namespace BookLibrary.Fabric
{
    /// <summary>
    /// Provides method for creating BookCoverFormat class instance
    /// </summary>
    public class CoverFormatFabric : IFormatterFabric
    {
        /// <summary>
        /// Creates new instance of BookCoverFormat class
        /// </summary>
        /// <returns>New instance of BookCoverFormat class</returns>
        public IBookFormatter CreateFormatter()
        {
            return new BookCoverFormat();
        }
    }
}

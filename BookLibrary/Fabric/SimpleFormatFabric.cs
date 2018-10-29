using BookLibrary.Formatters;

namespace BookLibrary.Fabric
{
    /// <summary>
    /// Provides method for creating SimpleFormat class instance
    /// </summary>
    public class SimpleFormatFabric : IFormatterFabric
    {
        /// <summary>
        /// Creates new instance of SimpleFormat class
        /// </summary>
        /// <returns>New instance of SimpleFormat class</returns>
        public IBookFormatter CreateFormatter()
        {
            return new SimpleFormat();
        }
    }
}

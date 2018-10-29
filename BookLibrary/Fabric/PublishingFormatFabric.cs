using BookLibrary.Formatters;

namespace BookLibrary.Fabric
{
    /// <summary>
    /// Provides method for creating PublishingFormat class instance
    /// </summary>
    public class PublishingFormatFabric : IFormatterFabric
    {
        /// <summary>
        /// Creates new instance of PublishingFormat class
        /// </summary>
        /// <returns>New instance of PublishingFormat class</returns>
        public IBookFormatter CreateFormatter()
        {
            return new PublishingFormat();
        }
    }
}

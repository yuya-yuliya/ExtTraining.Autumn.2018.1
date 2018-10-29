using BookLibrary.Formatters;

namespace BookLibrary.Fabric
{
    /// <summary>
    /// Provides method for creating FullInfoFormat class instance
    /// </summary>
    class FullFormatFabric : IFormatterFabric
    {
        /// <summary>
        /// Creates new instance of FullInfoFormat class
        /// </summary>
        /// <returns>New instance of FullInfoFormat class class</returns>
        public IBookFormatter CreateFormatter()
        {
            return new FullInfoFormat();
        }
    }
}

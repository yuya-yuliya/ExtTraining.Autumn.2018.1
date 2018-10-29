using BookLibrary.Formatters;

namespace BookLibrary.Fabric
{
    /// <summary>
    /// Provides method for creating instance of class implements IBookFormatter interface
    /// </summary>
    public interface IFormatterFabric
    {
        /// <summary>
        /// Creates new instance of class implements IBookFormatter interface
        /// </summary>
        /// <returns>New instance of class implements IBookFormatter interface</returns>
        IBookFormatter CreateFormatter();
    }
}

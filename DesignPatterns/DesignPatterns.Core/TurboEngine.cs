using DesignPatterns.Core.AbstractClasses;

namespace DesignPatterns.Core
{
    /// <summary>
    /// TurboEngine class
    /// </summary>
    public class TurboEngine : AbstractEngine
    {
        /// <summary>
        /// Passing true to the base class as it is turbo engine 
        /// </summary>
        /// <param name="size">size</param>
        public TurboEngine(int size) : base(size, true)
        {
        }
    }
}

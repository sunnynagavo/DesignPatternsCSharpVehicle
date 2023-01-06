using DesignPatterns.Core.AbstractClasses;

namespace DesignPatterns.Core
{
    /// <summary>
    /// Standard Engine which is not turbocharged
    /// </summary>
    public class StandardEngine : AbstractEngine
    {
        /// <summary>
        /// As its not turbo charged, passing false to base class
        /// </summary>
        /// <param name="size">size</param>
        public StandardEngine(int size) : base(size, false)
        {
        }
    }
}

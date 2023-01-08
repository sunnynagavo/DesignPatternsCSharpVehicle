using System.Reflection.Metadata.Ecma335;

namespace DesignPatterns.CreationalPatterns.Singleton
{
    /// <summary>
    /// Singleton class 
    /// </summary>
    public sealed class SerialNumberGenerator
    {
        /* Todo: for more details read from here 
         * https://csharpindepth.com/articles/singleton
         * A single constructor, which is private and parameterless. This prevents other classes from instantiating it 
         * (which would be a violation of the pattern). Note that it also prevents subclassing - if a singleton can be subclassed once,
         * it can be subclassed twice, and if each of those subclasses can create an instance, the pattern is violated. 
         * The factory pattern can be used if you need a single instance of a base type, but the exact type isn't known until runtime.
         * The class is sealed. This is unnecessary, strictly speaking, due to the above point, but may help the JIT to optimise things more.
         * A static variable which holds a reference to the single created instance, if any.
         * A public static means of getting the reference to the single created instance, creating one if necessary.
         */

        private static readonly Lazy<SerialNumberGenerator> lazy =
            new Lazy<SerialNumberGenerator>(() => new SerialNumberGenerator());

        private SerialNumberGenerator() { }

        // Old way of declaring an instance but there will be threading issues. instead use the lazy way as above.
        //public static SerialNumberGenerator Instance
        //{
        //    get
        //    {
        //        instance ??= new SerialNumberGenerator();
        //        return Instance;
        //    }
        //}

        public static SerialNumberGenerator Instance { get { return lazy.Value; } }
        private int count;

        public int NextSerial => ++count;
    }
}

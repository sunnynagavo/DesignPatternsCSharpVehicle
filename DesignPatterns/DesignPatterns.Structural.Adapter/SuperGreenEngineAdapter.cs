using DesignPatterns.Core.AbstractClasses;
using DesignPatterns.Core.Interfaces;

namespace DesignPatterns.Structural.Adapter
{
    /// <summary>
    /// Adapter class which is adapting to IEngine (abstract engine class) and adapting from supergreenengine.
    /// </summary>
    public class SuperGreenEngineAdapter : AbstractEngine
    {
        /* Variations for implementing Adapters
         * 1. Extend the class you are adapting to ( or implement it, if it's an interface). in this ex: its AbstractEngine you are adapting to
         * 2. Specify the class you are adapting from in the ctor and store a reference to it in an instance variable.
         * 3. for each method in the class you are extending, override it to delegate to the corresponding method 
         * of the class you are adapting from ( in this case its supergreenengine, for ex: you can override tostring() to call
         * supergreenengine (3rd party) tostring() method.
         * */

        private readonly SuperGreenEngine engine;

        /// <summary>
        /// in this ctor, it accepts the adapting from class which is supergreenengine class and then passes it to the base class ctor
        /// </summary>
        /// <param name="engine"></param>
        public SuperGreenEngineAdapter(SuperGreenEngine engine) : base(engine.EngineSize, false)
        {
            this.engine = engine;
        }

        // uncomment it to call supergreenengine(3rd party tostring() method)
        //public override string ToString()
        //{
        //    // if we want we can override this method and call the super engine tostring method
        //    return engine.ToString();
        //}
    }
}

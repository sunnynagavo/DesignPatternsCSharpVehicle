using DesignPatterns.Core.Interfaces;

namespace DesignPatterns.Structural.Bridge
{
    public class SportControls : AbstractDriverControls
    {
        public SportControls(IEngine engine) : base(engine)
        {
        }

        /// <summary>
        /// This method is specific to this class, where it calls base class Accelerate() twice
        /// rather than using engine.increasepower()
        /// </summary>
        public virtual void AccelerateHard()
        {
            Accelerate();
            Accelerate();
        }
    }
}

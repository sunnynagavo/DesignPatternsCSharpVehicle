using DesignPatterns.Core.Interfaces;

namespace DesignPatterns.Structural.Bridge
{
    public abstract class AbstractDriverControls
    {
        private readonly IEngine engine;

        public AbstractDriverControls(IEngine engine)
        {
            this.engine = engine;
        }

        public virtual void IgnitionOn() { engine.Start(); }

        public virtual void IgnitionOff() { engine.Stop(); }

        public virtual void Accelerate() { engine.IncreasePower(); }

        public virtual void Brake() { engine.DecreasePower(); }

    }
}

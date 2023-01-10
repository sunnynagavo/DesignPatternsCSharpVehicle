using DesignPatterns.Core.Interfaces;

namespace DesignPatterns.Core.AbstractClasses
{
    /// <summary>
    /// Abstract class implementing IEngine
    /// </summary>
    public abstract class AbstractEngine : IEngine
    {
        private int size;
        private bool turbo;
        private bool running;
        private int power;

        protected AbstractEngine(int size, bool turbo)
        {
            this.size = size;
            this.turbo = turbo;
            running = false;
            power = 0;
        }

        public virtual int Size { get => size; }
        public virtual bool Turbo { get => turbo; }

        public virtual void DecreasePower()
        {
            if (running && power > 0) { power--; }
        }

        public virtual void IncreasePower()
        {
            if (running && power < 10) { power++; }
        }

        public virtual void Start()
        {
            running = true;
        }

        public virtual void Stop()
        {
            running = false;
        }

        public override string ToString()
        {
            return GetType().Name + $"({size})";
        }
    }
}

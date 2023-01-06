namespace DesignPatterns.Core
{
    /// <summary>
    /// Abstract class implementing IEngine
    /// </summary>
    public abstract class AbstractEngine : IEngine
    {
        private int size;
        private bool turbo;

        protected AbstractEngine(int size, bool turbo)
        {
            this.size = size;
            this.turbo = turbo;
        }

        public virtual int Size { get => size;}
        public virtual bool Turbo { get => turbo; }

        public override string ToString()
        {
            return this.GetType().Name + $"({size})";
        }
    }
}

namespace DesignPatterns.Structural.Adapter
{
    /// <summary>
    /// This is a 3rd party classes which does not implement IEngine interface and extends from object
    /// We will create an Adapter to make it compatible to the IEngine interface that client expects.
    /// </summary>
    public class SuperGreenEngine
    {
        private readonly int engineSize;

        public SuperGreenEngine(int engineSize)
        {
            this.engineSize = engineSize;
        }

        public int EngineSize { get { return engineSize; } }

        public override string ToString() => $"SUPER ENGINE {engineSize}";
    }
}

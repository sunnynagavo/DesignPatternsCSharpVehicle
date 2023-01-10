using DesignPatterns.Core.Interfaces;

namespace DesignPatterns.Structural.Bridge
{
    public class StandardControls : AbstractDriverControls
    {
        public StandardControls(IEngine engine) : base(engine)
        {
        }

        // No extra functions here in this class
    }
}

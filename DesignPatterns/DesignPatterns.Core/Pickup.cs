using DesignPatterns.Core.AbstractClasses;
using DesignPatterns.Core.Interfaces;

namespace DesignPatterns.Core
{
    /// <summary>
    /// Pick up van implementing abstract van class
    /// </summary>
    public class Pickup : AbstractVan
    {
        public Pickup(IEngine engine) : this(engine, VehicleColor.Unpainted)
        {
        }

        public Pickup(IEngine engine, VehicleColor colour) : base(engine, colour)
        {
        }
    }
}

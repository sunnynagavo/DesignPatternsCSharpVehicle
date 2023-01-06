using DesignPatterns.Core.AbstractClasses;
using DesignPatterns.Core.Interfaces;

namespace DesignPatterns.Core
{
    /// <summary>
    /// Coupe car implementing abstract car
    /// </summary>
    public class Coupe : AbstractCar
    {
        public Coupe(IEngine engine) : this(engine, VehicleColor.Unpainted)
        {
        }

        public Coupe(IEngine engine, VehicleColor colour) : base(engine, colour)
        {
        }
    }
}

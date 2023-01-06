using DesignPatterns.Core.AbstractClasses;
using DesignPatterns.Core.Interfaces;

namespace DesignPatterns.Core
{
    /// <summary>
    /// Saloon car implementing abstract car
    /// </summary>
    public class Saloon : AbstractCar
    {
        public Saloon(IEngine engine) : this(engine, VehicleColor.Unpainted)
        {
        }

        public Saloon(IEngine engine, VehicleColor colour) : base(engine, colour)
        {
        }
    }
}

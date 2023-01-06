using DesignPatterns.Core.AbstractClasses;
using DesignPatterns.Core.Interfaces;

namespace DesignPatterns.Core
{
    /// <summary>
    /// Sports car implementing abstract car
    /// </summary>
    public class Sport : AbstractCar
    {
        public Sport(IEngine engine) : this(engine, VehicleColor.Unpainted)
        {
        }

        public Sport(IEngine engine, VehicleColor colour) : base(engine, colour)
        {
        }
    }
}

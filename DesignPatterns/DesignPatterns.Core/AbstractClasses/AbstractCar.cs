using DesignPatterns.Core.Interfaces;

namespace DesignPatterns.Core.AbstractClasses
{
    /// <summary>
    /// Abstract car implementing Abstract Vehicle
    /// </summary>
    public abstract class AbstractCar : AbstractVehicle
    {
        public AbstractCar(IEngine engine) : this(engine, VehicleColor.Unpainted)
        {
        }

        protected AbstractCar(IEngine engine, VehicleColor colour) : base(engine, colour)
        {
        }
    }
}

using DesignPatterns.Core.Interfaces;

namespace DesignPatterns.Core.AbstractClasses
{
    /// <summary>
    /// Abstract van implementing abstract vehicle class
    /// </summary>
    public abstract class AbstractVan : AbstractVehicle
    {
        public AbstractVan(IEngine engine) : this(engine, VehicleColor.Unpainted)
        {
        }

        public AbstractVan(IEngine engine, VehicleColor colour) : base(engine, colour)
        {
        }
    }
}

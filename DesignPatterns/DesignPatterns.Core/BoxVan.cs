using DesignPatterns.Core.AbstractClasses;
using DesignPatterns.Core.Interfaces;

namespace DesignPatterns.Core
{
    /// <summary>
    /// Box van implementing abstract van class
    /// </summary>
    public class BoxVan : AbstractVan
    {
        public BoxVan(IEngine engine) : this(engine, VehicleColor.Unpainted)
        {
        }

        public BoxVan(IEngine engine, VehicleColor colour) : base(engine, colour)
        {
        }
    }
}

using DesignPatterns.Core.Interfaces;

namespace DesignPatterns.Core.AbstractClasses
{
    /// <summary>
    /// Abstract vehicle implementing IVehicle interface. No one can create object of type abstract class
    /// </summary>
    public abstract class AbstractVehicle : IVehicle
    {
        private IEngine engine;
        private VehicleColor colour;

        /// <summary>
        /// constructor when only engine is passed, use Unpainted color
        /// </summary>
        /// <param name="engine"></param>
        public AbstractVehicle(IEngine engine) : this(engine, VehicleColor.Unpainted)
        {
        }

        /// <summary>
        /// Constructor to create vehicle
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="colour"></param>
        public AbstractVehicle(IEngine engine, VehicleColor colour)
        {
            this.engine = engine;
            this.colour = colour;
        }

        public virtual IEngine Engine { get { return engine; } }
        public virtual VehicleColor Colour { get { return colour; } }

        /// <summary>
        /// used by prototype pattern to perform cloning of the receiving object.
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public virtual void Paint(VehicleColor color)
        {
            this.colour = color;
        }

        public override string ToString()
        {
            return this.GetType().Name + $"({engine},{colour})";
        }
    }
}

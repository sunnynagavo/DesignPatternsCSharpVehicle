using DesignPatterns.Core;
using DesignPatterns.Core.Interfaces;

namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
    public abstract class VehicleFactory
    {
        public enum DrivingStyle
        {
            Economical, MidRange, Powerful
        }

        /// <summary>
        /// We expose this method so that clients can call this method to create vehicles.
        /// </summary>
        /// <param name="style"></param>
        /// <param name="colour"></param>
        /// <returns></returns>
        public virtual IVehicle BuildVehicle(DrivingStyle style, VehicleColor colour)
        {
            IVehicle vehicle = SelectVehicle(style);
            vehicle.Paint(colour);
            return vehicle;
        }

        /// <summary>
        /// This is the factory method after which the pattern was named.
        /// This method is abstracted out to the end clients.
        /// </summary>
        /// <param name="style"></param>
        /// <returns></returns>
        protected internal abstract IVehicle SelectVehicle(DrivingStyle style);
    }
}

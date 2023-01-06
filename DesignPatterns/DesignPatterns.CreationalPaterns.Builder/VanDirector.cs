using DesignPatterns.Core.Interfaces;

namespace DesignPatterns.CreationalPaterns.Builder
{
    /// <summary>
    /// Concrete implentation of van director
    /// </summary>
    public class VanDirector : VehicleDirector
    {
        /// <summary>
        /// This is the main method which does all individual build steps and returns the object to the client
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public override IVehicle Build(VehicleBuilder builder)
        {
            builder.BuildChasis();
            builder.BuildBody();
            builder.BuildReinforcedStorageArea();
            builder.BuildWindows();

            return builder.Vehicle;
        }
    }
}

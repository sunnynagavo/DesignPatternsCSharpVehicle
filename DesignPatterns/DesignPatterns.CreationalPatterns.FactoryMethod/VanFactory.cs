using DesignPatterns.Core;
using DesignPatterns.Core.Interfaces;

namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
    /// <summary>
    /// concrete implementation of van factory which is implementing vehicle factory
    /// </summary>
    public class VanFactory : VehicleFactory
    {
        /// <summary>
        /// Factory method to be implemented in all sub classes and based on this implementation
        /// abstract factory will create instances 
        /// </summary>
        /// <param name="style"></param>
        /// <returns></returns>
        protected internal override IVehicle SelectVehicle(DrivingStyle style)
        {
            // Using latest c#8 Switch expression instead of boring if else stmts.
            return style switch
            {
                DrivingStyle.MidRange or DrivingStyle.Economical => new Pickup(new StandardEngine(2200)),
                _ => new BoxVan(new TurboEngine(2500))
            };
        }
    }
}

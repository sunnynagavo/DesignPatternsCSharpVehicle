using DesignPatterns.Core;
using DesignPatterns.Core.Interfaces;

namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
    /// <summary>
    /// concrete implementation of car factory which is implementing vehicle factory
    /// </summary>
    public class CarFactory : VehicleFactory
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
                DrivingStyle.Economical => new Saloon(new StandardEngine(1300)),
                DrivingStyle.MidRange => new Coupe(new StandardEngine(1600)),
                _ => new Sport(new TurboEngine(2000))
            };
        }
    }
}

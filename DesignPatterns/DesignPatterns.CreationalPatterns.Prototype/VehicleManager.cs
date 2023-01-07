using DesignPatterns.Core;
using DesignPatterns.Core.Interfaces;

namespace DesignPatterns.CreationalPatterns.Prototype
{
    public class VehicleManagerLazy
    {
        private IVehicle? saloon, coupe, sport, boxVan, pickup;

        public VehicleManagerLazy()
        {
        }

        public virtual IVehicle CreateSaloon()
        {
            saloon ??= new Saloon(new StandardEngine(1300));
            return (IVehicle)saloon.Clone();
        }

        public virtual IVehicle CreateCoupe()
        {
            coupe ??= new Coupe(new StandardEngine(1300));
            return (IVehicle)coupe.Clone();
        }

        public virtual IVehicle CreateSport()
        {
            sport ??= new Sport(new StandardEngine(1300));
            return (IVehicle)sport.Clone();
        }

        public virtual IVehicle CreateBoxVan()
        {
            boxVan = new BoxVan(new StandardEngine(1300));
            return (IVehicle)boxVan.Clone();
        }

        public virtual IVehicle CreatePickup()
        {
            pickup = new Pickup(new StandardEngine(1300));
            return (IVehicle)pickup.Clone();
        }
    }
}

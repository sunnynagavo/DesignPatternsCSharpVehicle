using DesignPatterns.Core.AbstractClasses;
using DesignPatterns.Core.Interfaces;

namespace DesignPatterns.CreationalPaterns.Builder
{
    public class CarBuilder : VehicleBuilder
    {
        private AbstractCar carInProgress;

        public CarBuilder(AbstractCar carInProgress)
        {
            this.carInProgress = carInProgress;
        }

        public override void BuildBody() { Console.WriteLine("Building Car Body"); }
        public override void BuildBoot() { Console.WriteLine("Building Car Boot"); }
        public override void BuildChasis() { Console.WriteLine("Building Car Chasis"); }
        public override void BuildPassengerArea() { Console.WriteLine("Building Car Passenger Area"); }
       
        // commented because this method is not applicable to cars
        // public override void BuildReinforcedStorageArea() { Console.WriteLine("Building Car Body"); }
        public override void BuildWindows() { Console.WriteLine("Building Car Windows"); }

        public override IVehicle Vehicle => carInProgress;
    }
}

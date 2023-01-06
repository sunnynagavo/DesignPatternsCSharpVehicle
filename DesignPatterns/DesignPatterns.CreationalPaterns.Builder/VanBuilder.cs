using DesignPatterns.Core.AbstractClasses;
using DesignPatterns.Core.Interfaces;

namespace DesignPatterns.CreationalPaterns.Builder
{
    public class VanBuilder : VehicleBuilder
    {
        private AbstractCar vanInProgress;

        public VanBuilder(AbstractCar carInProgress)
        {
            this.vanInProgress = carInProgress;
        }

        public override void BuildBody() { Console.WriteLine("Building Van Body"); }
        public override void BuildChasis() { Console.WriteLine("Building Van Chasis"); }

        // commented because this method is not applicable to cars
        // public override void BuildBoot() { Console.WriteLine("Building Van Boot"); }
        // public override void BuildPassengerArea() { Console.WriteLine("Building Van Passenger Area"); }

        public override void BuildReinforcedStorageArea() { Console.WriteLine("Building Van Body"); }
        public override void BuildWindows() { Console.WriteLine("Building Van Windows"); }

        public override IVehicle Vehicle => vanInProgress;
    }
}

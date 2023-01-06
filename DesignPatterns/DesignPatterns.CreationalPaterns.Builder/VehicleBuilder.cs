using DesignPatterns.Core.Interfaces;

namespace DesignPatterns.CreationalPaterns.Builder
{
    /// <summary>
    /// Vehicle builder class which has separate methods for all build activity
    /// </summary>
    public abstract class VehicleBuilder
    {
        public virtual void BuildBody() { }
        public virtual void BuildBoot() { }
        public virtual void BuildChasis() { }
        public virtual void BuildPassengerArea() { }
        public virtual void BuildReinforcedStorageArea() { }
        public virtual void BuildWindows() { }


        public abstract IVehicle Vehicle { get; }

    }
}

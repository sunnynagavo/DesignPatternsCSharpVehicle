namespace DesignPatterns.Core.Interfaces
{
    /// <summary>
    /// Interface for vehicle object
    /// </summary>
    public interface IVehicle : ICloneable // adding this for protoype design pattern
    {
        IEngine Engine { get; }
        VehicleColor Colour { get; }
        void Paint(VehicleColor color);
    }
}

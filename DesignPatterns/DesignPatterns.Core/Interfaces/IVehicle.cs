namespace DesignPatterns.Core.Interfaces
{
    /// <summary>
    /// Interface for vehicle object
    /// </summary>
    public interface IVehicle
    {
        IEngine Engine { get; }
        VehicleColor Colour { get; }
        void Paint(VehicleColor color);
    }
}

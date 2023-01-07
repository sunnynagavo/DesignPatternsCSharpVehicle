namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    public abstract class AbstractVehicleFactory
    {
        public abstract IBody CreateBody();
        public abstract IGlassware CreateGlassware();
        public abstract IChasis CreateChasis();
    }
}

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    public class CarFactory : AbstractVehicleFactory
    {
        public override IBody CreateBody()
        {
            return new CarBody();
        }

        public override IChasis CreateChasis()
        {
            return new CarChasis();
        }

        public override IGlassware CreateGlassware()
        {
            return new CarGlassware();
        }
    }
}

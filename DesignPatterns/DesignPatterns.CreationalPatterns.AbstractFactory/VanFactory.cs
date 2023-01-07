namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    public class VanFactory : AbstractVehicleFactory
    {
        public override IBody CreateBody()
        {
            return new VanBody();
        }

        public override IChasis CreateChasis()
        {
            return new VanChasis();
        }

        public override IGlassware CreateGlassware()
        {
            return new VanGlassware();
        }
    }
}

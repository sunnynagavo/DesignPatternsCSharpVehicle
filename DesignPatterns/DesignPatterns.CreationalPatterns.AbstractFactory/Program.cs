namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("____________________________________________________________________________________");
            Console.WriteLine("Abstract Factory: Provides an interface for creating families of related or dependent objects" +
                 "without specifying their concrete classes. when we build a vehicle we can think of the components as coming" +
                 "from different families;that is, when we build a car we use one family of components and when we build a van" +
                 "we use a different family of component as car's chasis is different from van's chasis");
            Console.WriteLine("____________________________________________________________________________________");
            Console.WriteLine("\n");

            AbstractVehicleFactory factory;
            string whatToMake = "Van"; // "van"
            factory = whatToMake.Equals("car", StringComparison.OrdinalIgnoreCase) ? new CarFactory() : new VanFactory();

            // Create the vehicle's component parts...
            // These will either be all car parts or all van parts

            IBody vehicleBody = factory.CreateBody();
            IChasis vehicleChasis = factory.CreateChasis();
            IGlassware vehicleGlassware = factory.CreateGlassware();

            // display what we have created
            Console.WriteLine(vehicleBody.BodyParts);
            Console.WriteLine(vehicleChasis.ChasisParts);
            Console.WriteLine(vehicleGlassware.GlasswareParts);

            Console.WriteLine("____________________________________________________________________________________");

            Console.WriteLine("Note: Main disadvantage of this pattern arises if you need to add additional products" +
                "for ex: to include lights in the family of components, we would need to amend AbstractVehicleFactory," +
                "carfactory, vanfactory, in addition to creating a new Ilights hierarchy ( carlights and vanlights)");
        }
    }
}
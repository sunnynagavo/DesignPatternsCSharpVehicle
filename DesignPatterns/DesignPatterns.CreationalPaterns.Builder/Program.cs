// See https://aka.ms/new-console-template for more information

using DesignPatterns.Core;
using DesignPatterns.Core.AbstractClasses;
using DesignPatterns.Core.Interfaces;
using DesignPatterns.CreationalPaterns.Builder;

Console.WriteLine("____________________________________________________________________________________");
Console.WriteLine("Builder Pattern: Separate the construction of a complex object from its representation" +
    "so that the same construction process can create different representations. Mainly comprises of vehiclebuilder which facilitates" +
    "the construction of complex objects by separating the individual steps into separate methods in a builder hierarchy," +
    "and then using a director object to specify the required steps in the correct order");
Console.WriteLine("____________________________________________________________________________________");
Console.WriteLine("\n");

AbstractCar car = new Saloon(new StandardEngine(1300)); // create an abstract car
VehicleBuilder carBuilder = new CarBuilder(car); // pass it into car builder
VehicleDirector carDirector = new CarDirector(); // pass builder object into director and then call build on director object
IVehicle v = carDirector.Build(carBuilder);
Console.WriteLine(v);
Console.ReadLine();

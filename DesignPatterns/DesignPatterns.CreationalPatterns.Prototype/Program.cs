// See https://aka.ms/new-console-template for more information
using DesignPatterns.CreationalPatterns.Prototype;

Console.WriteLine("____________________________________________________________________________________");
Console.WriteLine("Prototype: Creational pattern. Specify the kinds of objects to create using a prototypical instance" +
    "and create new objects by copying the prototype");
Console.WriteLine("____________________________________________________________________________________");
Console.WriteLine("\n");

VehicleManagerLazy manager = new VehicleManagerLazy();
Console.WriteLine(manager.CreateCoupe());
Console.WriteLine(manager.CreateBoxVan());
Console.WriteLine(manager.CreateSaloon());
Console.WriteLine(manager.CreateSport());
Console.WriteLine(manager.CreatePickup());
Console.WriteLine(manager.CreateBoxVan());

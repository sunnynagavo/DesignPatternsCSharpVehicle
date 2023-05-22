// See https://aka.ms/new-console-template for more information
using DesignPatterns.Core;
using DesignPatterns.Core.Interfaces;
using DesignPatterns.Structural.Adapter;

Console.WriteLine("____________________________________________________________________________________");
Console.WriteLine("Adaptor: Convert the interface of a class into another interface clients expects." +
    "Adapter lets classes work together that couldnt otherwise because of incompatible interfaces");
Console.WriteLine("____________________________________________________________________________________");
Console.WriteLine("\n");

// Create Ilist of engines and loop through it

IList<IEngine> engines = new List<IEngine>();
engines.Add(new StandardEngine(1300));
engines.Add(new StandardEngine(1600));
engines.Add(new TurboEngine(2600));

// Now add the 3rd party engine, as we created adapter to make it compatible
engines.Add(new SuperGreenEngineAdapter(new SuperGreenEngine(4000)));

foreach (var engine in engines)
{
    Console.WriteLine(engine);
}

Console.ReadLine();

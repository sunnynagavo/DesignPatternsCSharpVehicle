// See https://aka.ms/new-console-template for more information
using DesignPatterns.Core;
using DesignPatterns.Core.Interfaces;
using DesignPatterns.Structural.Bridge;

Console.WriteLine("____________________________________________________________________________________");
Console.WriteLine("Bridge: Decouple an abstraction from its implementation so that each may vary independently");
Console.WriteLine("____________________________________________________________________________________");
Console.WriteLine("\n");

IEngine engine = new StandardEngine(1300);
StandardControls stdControl = new StandardControls(engine);
stdControl.IgnitionOn();
stdControl.Accelerate();
stdControl.Brake();
stdControl.IgnitionOff();

// now use sports control 
SportControls sportControls = new SportControls(engine);
sportControls.IgnitionOn();
sportControls.Accelerate();
sportControls.AccelerateHard();
sportControls.Brake();
sportControls.IgnitionOff();

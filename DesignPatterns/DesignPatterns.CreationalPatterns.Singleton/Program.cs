// See https://aka.ms/new-console-template for more information
using DesignPatterns.CreationalPatterns.Singleton;

Console.WriteLine("____________________________________________________________________________________");
Console.WriteLine("Singleton: Ensure a class allows only one object to be created, providing a single point of access to it");
Console.WriteLine("____________________________________________________________________________________");
Console.WriteLine("\n");

// Here when we call SerialNumberGenerator.Instance, we are creating a single instance and then reusing it all the time.
Console.WriteLine($"Next serial number: {SerialNumberGenerator.Instance.NextSerial}");
Console.WriteLine($"Next serial number: {SerialNumberGenerator.Instance.NextSerial}");
Console.WriteLine($"Next serial number: {SerialNumberGenerator.Instance.NextSerial}");
Console.WriteLine($"Next serial number: {SerialNumberGenerator.Instance.NextSerial}");
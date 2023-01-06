﻿// See https://aka.ms/new-console-template for more information
using DesignPatterns.Core;
using DesignPatterns.Core.Interfaces;
using DesignPatterns.CreationalPatterns.FactoryMethod;

Console.WriteLine("____________________________________________________________________________________");
Console.WriteLine("Factory Method: Defines an interface for creating an object, but let subclasses decide which class to instantiate");
Console.WriteLine("____________________________________________________________________________________");
Console.WriteLine("\n");

// Client program to instantiate the required factory and call its build vehicle method

// implement economical car
Console.WriteLine("Building a new car");
VehicleFactory carFactory = new CarFactory();
IVehicle car =  carFactory.BuildVehicle(VehicleFactory.DrivingStyle.Economical, VehicleColor.Red);
Console.WriteLine(car);
Console.WriteLine("____________________________________________________________________________________");

// implement box van
Console.WriteLine("Building a new van");
VehicleFactory vanFactory = new VanFactory();
IVehicle van = vanFactory.BuildVehicle(VehicleFactory.DrivingStyle.Powerful, VehicleColor.Yellow);
Console.WriteLine(van);
Console.WriteLine("____________________________________________________________________________________");


Console.ReadLine();


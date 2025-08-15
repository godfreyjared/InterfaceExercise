using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating instances
            var car = new Car
            {
                Make = "Tesla",
                Model = "Model S",
                EngineSize = 0,
                SeatCount = 5,
                CompanyName = "Tesla Inc.",
                Motto = "Accelerating the world's transition to sustainable energy",
                HasTrunk = true,
                IsElectric = true
            };

            var truck = new Truck
            {
                Make = "Ford",
                Model = "F-150",
                EngineSize = 5.0,
                SeatCount = 5,
                CompanyName = "Ford Motor Co.",
                Motto = "Built Ford Tough",
                BedLength = 6.5,
                HasFourWheelDrive = true
            };

            var suv = new SUV
            {
                Make = "Toyota",
                Model = "4Runner",
                EngineSize = 4.0,
                SeatCount = 7,
                CompanyName = "Toyota Motor Corporation",
                Motto = "Let's Go Places",
                HasRoofRack = true,
                CargoSpace = 89
            };

            // Putting them into a list
            var vehicles = new List<IVehicle> { car, truck, suv };

            // Display details
            foreach (var vehicle in vehicles)
            {
                vehicle.DisplayDetails();
                vehicle.Drive();
                vehicle.Park();
            }
        }
    }
}
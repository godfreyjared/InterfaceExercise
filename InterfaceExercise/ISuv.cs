using System;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV() { }

        // IVehicle
        public double EngineSize { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int SeatCount { get; set; }
        public bool HasChangedGears { get; set; }

        // ICompany
        public string CompanyName { get; set; }
        public string Motto { get; set; }

        // Unique to SUV
        public bool HasRoofRack { get; set; }
        public int CargoSpace { get; set; } // cubic feet

        public void Drive() => Console.WriteLine($"{GetType().Name} now driving forward!");
        public void Reverse() => Console.WriteLine($"{GetType().Name} now reversing!");
        public void Park() => Console.WriteLine($"{GetType().Name} now parked!");
        public bool ChangeGears(bool hasChanged) => HasChangedGears = hasChanged;

        public void DisplayDetails()
        {
            Console.WriteLine($"\n--- {GetType().Name} Details ---");
            Console.WriteLine($"Make: {Make}, Model: {Model}, Engine: {EngineSize}L, Seats: {SeatCount}");
            Console.WriteLine($"Company: {CompanyName}, Motto: {Motto}");
            Console.WriteLine($"Has Roof Rack: {HasRoofRack}, Cargo Space: {CargoSpace} cu ft");
        }
    }
}
using System;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck() { }

        // IVehicle
        public double EngineSize { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int SeatCount { get; set; }
        public bool HasChangedGears { get; set; }

        // ICompany
        public string CompanyName { get; set; }
        public string Motto { get; set; }

        // Unique to Truck
        public double BedLength { get; set; }
        public bool HasFourWheelDrive { get; set; }

        public void Drive() => Console.WriteLine($"{GetType().Name} now driving forward!");
        public void Reverse() => Console.WriteLine($"{GetType().Name} now reversing!");
        public void Park() => Console.WriteLine($"{GetType().Name} now parked!");
        public bool ChangeGears(bool hasChanged) => HasChangedGears = hasChanged;

        public void DisplayDetails()
        {
            Console.WriteLine($"\n--- {GetType().Name} Details ---");
            Console.WriteLine($"Make: {Make}, Model: {Model}, Engine: {EngineSize}L, Seats: {SeatCount}");
            Console.WriteLine($"Company: {CompanyName}, Motto: {Motto}");
            Console.WriteLine($"Bed Length: {BedLength} ft, 4WD: {HasFourWheelDrive}");
        }
    }
}

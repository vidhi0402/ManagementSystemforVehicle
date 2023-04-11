using System;
using System.Collections.Generic;
using System.Text;
using static Vehiclemanagementsystem.EnumClass;

namespace Vehiclemanagementsystem
{
    // base class
    public abstract class vehicle
    {
        public string Id { get; }
        public string Name { get; }
        public VehicleType VehicleType { get; }
        public int SeatingCapacity { get; }
        public double FuelTankSize { get; }
        public int HeadLightCount { get; }
        public int TailLightCount { get; }
        public int IndicatorCount { get; }
        public int ExhaustCount { get; }
        public int WheelsCount { get; }
    

    // constructor
    protected vehicle(string id, string name, VehicleType vehicleType, int seatingCapacity, double fuelTankSize, int headLightCount, int tailLightCount, int indicatorCount, int exhaustCount, int wheelsCount)
    {
        Id = id;
        Name = name;
        VehicleType = vehicleType;
        SeatingCapacity = seatingCapacity;
        FuelTankSize = fuelTankSize;
        HeadLightCount = headLightCount;
        TailLightCount = tailLightCount;
        IndicatorCount = indicatorCount;
        ExhaustCount = exhaustCount;
        WheelsCount = wheelsCount;
    }

        public virtual void PrintInformation()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Vehicle Type: {VehicleType}");
            Console.WriteLine($"Seating Capacity: {SeatingCapacity}");
            Console.WriteLine($"Fuel Tank Size: {FuelTankSize}");
            Console.WriteLine($"Head Light Count: {HeadLightCount}");
            Console.WriteLine($"Tail Light Count: {TailLightCount}");
            Console.WriteLine($"Indicator Count: {IndicatorCount}");
            Console.WriteLine($"Exhaust Count: {ExhaustCount}");
            Console.WriteLine($"Wheels Count: {WheelsCount}");
        }

        // Start Method
        public abstract void Start();

        // Stop Method
        public abstract void Stop();
    }
}

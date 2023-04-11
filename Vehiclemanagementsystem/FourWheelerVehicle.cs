using System;
using System.Collections.Generic;
using System.Text;
using static Vehiclemanagementsystem.EnumClass;

namespace Vehiclemanagementsystem
{
    public class FourWheelerVehicle : vehicle
    {
        public FuelType FuelType { get; }
        public int SpeakerCount { get; }
        public int WindowCount { get; }
        public int SeatBeltCount { get; }
        public int DiscBrakeCount { get; }

        //constructor 
        public FourWheelerVehicle(string id, VehicleType vehicleType, FuelType fuelType, int seatingCapacity, double fuelTankSize, int headLightCount, int tailLightCount, int indicatorCount, int exhaustCount, int wheelsCount, int speakerCount, int windowCount, int seatBeltCount, int discBrakeCount)
          : base(id, vehicleType.ToString(), vehicleType, seatingCapacity, fuelTankSize, headLightCount, tailLightCount, indicatorCount, exhaustCount, wheelsCount)
        {
            FuelType = fuelType;
            SpeakerCount = speakerCount;
            WindowCount = windowCount;
            SeatBeltCount = seatBeltCount;
            DiscBrakeCount = discBrakeCount;
        }

        public override void PrintInformation()
        {
            base.PrintInformation();
            Console.WriteLine($"Fuel Type: {FuelType}");
            Console.WriteLine($"Speaker Count: {SpeakerCount}");
            Console.WriteLine($"Window Count: {WindowCount}");
            Console.WriteLine($"Seat Belt Count: {SeatBeltCount}");
            Console.WriteLine($"Disc Brake Count: {DiscBrakeCount}");
        }
        public override void Start()
        {
            Console.WriteLine("Start Engine...");
            Console.WriteLine("Release Hand Brake...");
            Console.WriteLine("Start Driving...");
        }

        public override void Stop()
        {
            Console.WriteLine("Stop Driving...");
            Console.WriteLine("Engage Hand Brake...");
            Console.WriteLine("Stop Engine...");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using static Vehiclemanagementsystem.EnumClass;

namespace Vehiclemanagementsystem
{
    public class TwoWheelerVehicle : vehicle
    {
        public int NoOfHelmet { get; }


        public TwoWheelerVehicle(string id, VehicleType vehicleType, int seatingCapacity, double fuelTankSize, int headLightCount, int tailLightCount, int indicatorCount, int exhaustCount, int wheelsCount, int noOfHelmet)
           : base(id, vehicleType.ToString(), vehicleType, seatingCapacity, fuelTankSize, headLightCount, tailLightCount, indicatorCount, exhaustCount, wheelsCount)
            {
                NoOfHelmet = noOfHelmet;
            }

        public override void PrintInformation()
        {
            base.PrintInformation();
            Console.WriteLine($"No Of Helmet: {NoOfHelmet}");
        }

        public override void Start()
        {
            Console.WriteLine("Start Engine...");
            Console.WriteLine("Start Driving...");
        }

        public override void Stop()
        {
            Console.WriteLine("Stop Driving...");
            Console.WriteLine("Stop Engine...");
        }
    }
}

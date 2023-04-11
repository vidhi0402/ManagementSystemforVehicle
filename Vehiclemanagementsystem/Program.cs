using System;
using static Vehiclemanagementsystem.EnumClass;

namespace Vehiclemanagementsystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //two wheeler vehicle object
            var access = new TwoWheelerVehicle("access", VehicleType.TwoWheeler, 2, 2.5, 2, 2, 2, 2, 2, 2);
            var activa5g = new TwoWheelerVehicle("activa5g", VehicleType.TwoWheeler, 2, 4.5, 2, 2, 2, 2, 2, 2);
            var jupiter = new TwoWheelerVehicle("jupiter", VehicleType.TwoWheeler, 2, 4.7, 2, 2, 2, 2, 2, 2);

            //four wheeler vehicle object
            var scorpio = new FourWheelerVehicle("scorpio", VehicleType.FourWheeler, FuelType.Diesel, 5, 4, 4, 4, 2, 6, 4, 4, 4, 5, 3);
            var nexon = new FourWheelerVehicle("nexon", VehicleType.FourWheeler, FuelType.Petrol, 5, 4, 4, 4, 2, 6, 4, 4, 4, 5, 3);
            var ciaz = new FourWheelerVehicle("ciaz", VehicleType.FourWheeler, FuelType.Diesel, 5, 4, 4, 4, 2, 6, 4, 4, 4, 5, 3);

            Console.WriteLine("Two Wheeler Vehicle Information");
            Console.WriteLine("Access");
            access.PrintInformation();
            Console.WriteLine("Activa 5G");
            activa5g.PrintInformation();
            Console.WriteLine("Jupiter");
            jupiter.PrintInformation();

            // start two wheeler vehicles
            access.Start();
            activa5g.Start();
            jupiter.Start();

            //stop two wheeler vehicles
            access.Stop();
            activa5g.Stop();
            jupiter.Stop();

            Console.WriteLine("Four Wheeler Vehicle Information");
            Console.WriteLine("Scorpio");
            scorpio.PrintInformation();
            Console.WriteLine("Nexon");
            nexon.PrintInformation();
            Console.WriteLine("Ciaz");
            ciaz.PrintInformation();

            // Start four wheeler vehicles
            scorpio.Start();
            nexon.Start();
            ciaz.Start();

            // Stop four wheeler vehicles
            scorpio.Stop();
            nexon.Stop();
            ciaz.Stop();

            Console.ReadLine();

        }
    }
}

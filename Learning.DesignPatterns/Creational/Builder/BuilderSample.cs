using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPatterns.Builder
{
    public class BuilderSample
    {

        public static void Run()
        {
            VehicleDTO vehicle = new VehicleDTO();
            vehicle.VIN = "12345";
            vehicle.Make = "Maruti";
            vehicle.Model = "Ritz ZXi";
            vehicle.Name = "Maruti Suzuki Ritz 2014 Model";
            vehicle.Year = "2014";
            vehicle.Type = VehicleType.Car;


            Shop shop = new Shop();

            CarBuilder carBuilder = new CarBuilder(vehicle);

            shop.Contruct(carBuilder);


            vehicle.Type = VehicleType.Truck;
            TruckBuilder truckBuilder = new TruckBuilder(vehicle);

            shop.Contruct(truckBuilder);


            vehicle.Type = VehicleType.Bike;
            BikeBuilder bikeBuilder = new BikeBuilder(vehicle);

            shop.Contruct(bikeBuilder);


            Console.ReadKey();
        }
    }
}

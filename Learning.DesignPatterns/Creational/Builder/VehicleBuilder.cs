using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPatterns.Builder
{
    public abstract class VehicleBuilder
    {
        private VehicleDTO vehicle;


        public VehicleDTO Vehicle
        {
            get
            {
                return vehicle;
            }
            set
            {
                vehicle = value;
            }
        }

        public VehicleBuilder()
        {

        }
        public  VehicleBuilder(VehicleDTO _vehicle)
        {
            vehicle = _vehicle;
        }

        public void BuildVehicle()
        {
            
        }

        public void BuildVehicle(VehicleDTO _vehicle)
        {

        }

        public VehicleDTO GetVehicleInfo()
        {
            return vehicle;
        }

        public void DisplayVehicleInfo()
        {
            if(vehicle != null)
            {
                Console.WriteLine(String.Format("VIN:{0}, Name{1}, Make: {2}, Model: {3}, Year: {5}, Type: {4},", vehicle.VIN, vehicle.Name, vehicle.Make, vehicle.Model, vehicle.Year, vehicle.Type.ToString()));
            }
        }
    }
}

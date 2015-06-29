using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPatterns.Builder
{
    public class CarBuilder : VehicleBuilder
    {

        public CarBuilder()
        {

        }

        public CarBuilder(VehicleDTO vehicle) : base(vehicle)
        {

        }
    }
}

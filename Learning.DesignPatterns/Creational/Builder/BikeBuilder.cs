using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPatterns.Builder
{
    public class BikeBuilder : VehicleBuilder
    {

         public BikeBuilder(VehicleDTO vehicle) : base(vehicle)
        {

        }
    }
}

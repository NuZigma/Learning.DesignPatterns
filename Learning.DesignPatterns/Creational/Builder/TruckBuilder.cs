using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPatterns.Builder
{
    public class TruckBuilder : VehicleBuilder
    {

        public TruckBuilder()
        {

        }

        public TruckBuilder(VehicleDTO vehicle) : base(vehicle)
        {

        }
    }
}

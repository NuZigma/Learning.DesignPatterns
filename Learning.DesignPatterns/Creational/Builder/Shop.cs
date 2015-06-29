using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPatterns.Builder
{
    public class Shop
    {

        public void Contruct(VehicleBuilder builder)
        {

            
            builder.BuildVehicle();

            builder.DisplayVehicleInfo();
        }
    }
}

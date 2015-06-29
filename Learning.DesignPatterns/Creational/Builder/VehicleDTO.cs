using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPatterns.Builder
{
    public class VehicleDTO
    {

        public string VIN
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string Model
        {
            get;
            set;
        }


        public string Make
        {
            get;
            set;
        }

        public string Year
        {
            get;
            set;
        }

        public VehicleType Type
        {
            get;
            set;
        }
    }
}

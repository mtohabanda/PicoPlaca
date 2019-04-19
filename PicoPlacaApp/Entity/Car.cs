using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class Car
    {
        public string LicensePlate { set; get; }

        public Car(string licensePlate) {
            this.LicensePlate = licensePlate;
        }
    }
}

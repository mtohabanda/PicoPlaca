using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class CarOnRoad
    {
        public string LicensePlate { set; get; }
        public string Date { set; get; }
        public string Time { set; get; }

        public CarOnRoad(string licenseplate, string date, string time) {
            this.LicensePlate = licenseplate;
            this.Date = date;
            this.Time = time;
        }
    }
}

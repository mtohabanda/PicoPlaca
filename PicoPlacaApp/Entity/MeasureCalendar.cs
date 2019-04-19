using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public  class MeasureCalendar
    {
        public string Day { set; get; }
        public int LastDigitLicensePlate1 { set; get; }
        public int LastDigitLicensePlate2 { set; get; }

        public MeasureCalendar(string day, int lastDigitLicensePlate1, int lastDigitLicensePlate2 ) {
            this.Day = day;
            this.LastDigitLicensePlate1 = lastDigitLicensePlate1;
            this.LastDigitLicensePlate2 = lastDigitLicensePlate2;
        }
    }
}

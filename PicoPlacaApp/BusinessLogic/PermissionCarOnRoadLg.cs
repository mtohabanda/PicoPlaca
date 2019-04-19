using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace BusinessLogic
{
  public  class PermissionCarOnRoadLg
    {
        public bool HasCarPermissionOnRoad(CarOnRoad car) {
            return !(IsLicensePlateNumberIntoCalendar(car) && IsCarOnPicoTime(car));
        }

        public bool IsLicensePlateNumberIntoCalendar(CarOnRoad carOnRoad) {
            List<MeasureCalendar> lstMeasureCalendar = (new MeasureCalendarLg()).GetListOfMeasureCalendar();
            
            int lastDigitLicensePlateOnRoad = Convert.ToInt16(carOnRoad.LicensePlate.Substring(carOnRoad.LicensePlate.Length-1, 1));
            string dayCarOnRoad = DateTime.Parse(carOnRoad.Date).DayOfWeek.ToString().ToUpper();

            string isIntoCalendar =  lstMeasureCalendar.Where(x => x.Day.Equals(dayCarOnRoad) && 
                                                                 ( x.LastDigitLicensePlate1.Equals(lastDigitLicensePlateOnRoad) ||
                                                                   x.LastDigitLicensePlate2.Equals(lastDigitLicensePlateOnRoad)
                                                                 )
                                                             ).Count().ToString();
            return isIntoCalendar == "1";
        }

        public bool IsCarOnPicoTime(CarOnRoad carOnRoad) {
            PicoHour picoHour = new PicoHour();
            picoHour = new PicoHourLg().getPicoHours();

            return (TimeSpan.Parse(carOnRoad.Time) >= TimeSpan.Parse(picoHour.StartMorningTime) &&
                    TimeSpan.Parse(carOnRoad.Time) <= TimeSpan.Parse(picoHour.EndMorningTime)
                   ) ||
                   (
                    TimeSpan.Parse(carOnRoad.Time) >= TimeSpan.Parse(picoHour.StartAfternoonTime) &&
                    TimeSpan.Parse(carOnRoad.Time) <= TimeSpan.Parse(picoHour.EndAfternoonTime)
                   );
        }
    }
}

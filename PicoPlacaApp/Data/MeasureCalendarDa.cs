using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Data
{
    public class MeasureCalendarDa
    {


        public MeasureCalendarDa() {
        }


        public List<MeasureCalendar> GetListOfMeasureCalendar() {
            List<MeasureCalendar> lstMeasureCalendar = new List<MeasureCalendar>();
            MeasureCalendar monday = new MeasureCalendar("MONDAY", 1, 2);
            MeasureCalendar tuesday = new MeasureCalendar("TUESDAY", 3, 4);
            MeasureCalendar wednesday = new MeasureCalendar("WEDNESDAY", 5, 6);
            MeasureCalendar thursday = new MeasureCalendar("THURSDAY", 7, 8);
            MeasureCalendar friday = new MeasureCalendar("FRIDAY", 9, 0);

            lstMeasureCalendar.Add(monday);
            lstMeasureCalendar.Add(tuesday);
            lstMeasureCalendar.Add(wednesday);
            lstMeasureCalendar.Add(thursday);
            lstMeasureCalendar.Add(friday);

            return lstMeasureCalendar;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entity;

namespace BusinessLogic
{
    public class MeasureCalendarLg
    {
        public List<MeasureCalendar> GetListOfMeasureCalendar() {
            MeasureCalendarDa measureCalendar = new MeasureCalendarDa();
            return measureCalendar.GetListOfMeasureCalendar();
        }
    }
}

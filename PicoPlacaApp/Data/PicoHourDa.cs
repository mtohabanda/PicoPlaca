using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Data
{
    public class PicoHourDa
    {
        public PicoHourDa() { }

        public PicoHour GetPicoHours() {
            return ( new PicoHour("07:00", "09:30", "16:00", "19:30"));
        }
    }
}

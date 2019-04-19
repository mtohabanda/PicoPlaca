using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Data;

namespace BusinessLogic
{
   public class PicoHourLg
    {
        public PicoHour getPicoHours(){
            return (new PicoHourDa().GetPicoHours());
        }
    }
}

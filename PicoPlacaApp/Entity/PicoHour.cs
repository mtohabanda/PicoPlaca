using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class PicoHour
    {
       public string StartMorningTime { set; get; }
       public string EndMorningTime { set; get; }
       public string StartAfternoonTime { set; get; }
       public string EndAfternoonTime { set; get; }

       public PicoHour() { }

        public PicoHour(string startMorningTime, string endMorningTime, string startAfternoonTime, string endAfternoonTime) {
            this.StartMorningTime = startMorningTime;
            this.EndMorningTime = endMorningTime;
            this.StartAfternoonTime = startAfternoonTime;
            this.EndAfternoonTime = endAfternoonTime;
        }
    }
}

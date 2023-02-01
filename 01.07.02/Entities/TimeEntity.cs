using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._07._02.Entities
{
    public class TimeEntity
    {
        private TimeOnly arrivalTime;
        private TimeOnly testTime;

        public TimeEntity(TimeOnly arrivalTime, TimeOnly testTime)
        {
            this.arrivalTime= arrivalTime;
            this.testTime= testTime;
        }

        public TimeSpan CalculateDifference()
        {
            if (arrivalTime > testTime)
                return arrivalTime - testTime;
            else 
                return testTime - arrivalTime;
        }

        public string LateOrOnTime()
        {
            if (arrivalTime > testTime)
                return "Late";
            else if (CalculateDifference().Minutes <= 30 && CalculateDifference().Hours == 0)
                return "On time";
            else
                return "Early";
        }


    }
}

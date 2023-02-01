using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._07._02.Views
{
    public class View
    {
        public TimeOnly ReadTestTime()
        {
            Console.WriteLine("Hour of the test: ");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Minute of the test: ");
            int m = int.Parse(Console.ReadLine());
            return TimeOnly.ParseExact($"{h}:{m}", "h:m");
        }

        public TimeOnly ReadArrivalTime()
        {
            Console.WriteLine("Hour of the arrival: ");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Minute of the arrival: ");
            int m = int.Parse(Console.ReadLine());
            return TimeOnly.ParseExact($"{h}:{m}", "h:m");
        }

        public void WriteTheResultTime(TimeSpan time, string result)
        {
            Console.WriteLine(result);
            string afterOrBefore = "";

            if (result == "Late")
                afterOrBefore = "after";
            else
                afterOrBefore = "before";

            if (time.Hours == 0)
                Console.WriteLine($"{time.Minutes} minutes {afterOrBefore} the start");
            else
                Console.WriteLine($"{time.Hours}:{time.Minutes:D2} hours {afterOrBefore} the start");
        }
    }
}

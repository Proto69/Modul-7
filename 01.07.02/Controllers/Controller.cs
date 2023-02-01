using _01._07._02.Entities;
using _01._07._02.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._07._02.Controllers
{
    public class Controller
    {
        private TimeEntity time;
        private View view;

        public Controller()
        {
            view = new View();
            time = new TimeEntity(view.ReadArrivalTime(), view.ReadTestTime());

            view.WriteTheResultTime(time.CalculateDifference(), time.LateOrOnTime());
        }
    }
}

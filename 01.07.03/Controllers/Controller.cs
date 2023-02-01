using _01._07._03.Entities;
using _01._07._03.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._07._03.Controllers
{
    public class Controller
    {
        private View view;
        private Histogram histogram;

        public Controller()
        {
            view = new View();
            histogram = new Histogram(view.ReadNumbers());

            histogram.GetAllPs();

            view.DisplayTheResult(histogram.GetAllPercents());
        }
    }
}

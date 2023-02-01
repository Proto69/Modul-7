using _07._1ва_задача.Models;
using _07._1ва_задача.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._1ва_задача.Controllers
{
    public class Controller
    {
        private Transports transports;
        private View view;

        public Controller()
        {
            view = new();
            transports = new(view.GetKm(), view.GetTime());
            view.PrintResult(transports.GetCheapestTransport());
        }
    }
}

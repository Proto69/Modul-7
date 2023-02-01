using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._1ва_задача.Views
{
    public class View
    {

        public View()
        {
        }

        public int GetKm()
        {
            Console.Write("Insert km: ");
            return int.Parse(Console.ReadLine());
        }

        public string GetTime()
        {
            Console.Write("What is the time: ");
            return Console.ReadLine();
        }

        public void PrintResult(double result)
        {
            Console.WriteLine($"The cheapest price is {result}");
        }
    }
}

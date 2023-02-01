using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._07._04.Views
{
    public class View
    {
        public int ReadN()
        {
            Console.Write("Enter n: ");
            return int.Parse(Console.ReadLine());
        }

        public int ReadL()
        {
            Console.Write("Enter l: ");
            return int.Parse(Console.ReadLine());
        }

        public void DisplayResult(List<string> strings)
        {
            foreach (string password in strings)
            {
                Console.Write(password + " ");
            }
        }
    }
}

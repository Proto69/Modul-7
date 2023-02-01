using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._07._03.Views
{
    public class View
    {
        public List<int> ReadNumbers()
        {
            Console.Write("Enter the count of numbers: ");
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>(n);
            
            Console.WriteLine("Write all numbers on new rows: ");

            for (int i = 0; i < n; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            return numbers;
        }

        public void DisplayTheResult(List<double> doubles)
        {
            foreach (double percent in doubles)
            {
                Console.WriteLine($"{percent:F2}%");
            }
        }
    }
}

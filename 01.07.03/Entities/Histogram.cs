using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._07._03.Entities
{
    public class Histogram
    {
        private List<double> p;

        private List<int> numbers;

        public Histogram(List<int> numbers)
        {
            this.numbers = numbers;
            p = new List<double> { 0, 0, 0, 0, 0};
        }

        public void GetAllPs()
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 200) p[0]++;
                else if (numbers[i] < 400) p[1]++;
                else if (numbers[i] < 600) p[2]++;
                else if (numbers[i] < 800) p[3]++;
                else p[4]++;
            }
        }

        public List<double> GetAllPercents()
        {
            List<double> listOfPercentages = new List<double>();
            foreach (double item in p)
            {
                listOfPercentages.Add(item / numbers.Count * 100);
            }
            return listOfPercentages;
        }
    }
}

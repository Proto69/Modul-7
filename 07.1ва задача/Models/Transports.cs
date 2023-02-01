using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._1ва_задача.Models
{
    public class Transports
    {
        private const double taxiStartPrice = 0.70;
        private const double taxiDayPricePerKm = 0.79;
        private const double taxiNightPricePerKm = 0.90;

        private int km;
        private string time;

        private const double busPricePerKm = 0.09;

        private const double trainPricePerKm = 0.06;

        public static double TaxiStartPrice => taxiStartPrice;

        public static double TaxiDayPricePerKm => taxiDayPricePerKm;

        public static double TaxiNightPricePerKm => taxiNightPricePerKm;

        public static double BusPricePerKm => busPricePerKm;

        public static double TrainPricePerKm => trainPricePerKm;

        public int Km { get => km; set => km = value; }
        public string Time { get => time; set => time = value; }

        public Transports(int km, string time)
        {
            this.Km = km;
            this.Time = time;
        }

        public double GetCheapestTransport()
        {
            double taxi = 0;
            double bus = 0;
            double train = 0;
            if (Time == "day")
                taxi = TaxiStartPrice + TaxiDayPricePerKm * Km;
            else
                taxi = TaxiStartPrice + TaxiNightPricePerKm * Km;
            if (Km >= 20)
                bus = busPricePerKm * Km;
            if (Km >= 100)
                train = trainPricePerKm * Km;

            if (bus == 0)
                return taxi;
            if (train == 0)
                return bus;
            else
                return train;
        }
    }
}

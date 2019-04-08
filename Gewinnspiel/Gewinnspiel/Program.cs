using System;

namespace Gewinnspiel
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var rnd = Randomizer();
            var ergebnis = PrüfeErgebnis(rnd);
            Ausgabe(ergebnis);
        }

        private static int Randomizer()
        {
            var zahl = new Random();
            return zahl.Next(1,1);
        }

        private static int HoleEingabe()
        {
            Console.WriteLine("Versuchen Sie eine Zahl zwischen 1 und 10 zu erraten");
            return Convert.ToByte(Console.ReadLine());
        }

        internal static string PrüfeErgebnis(int rnd)
        {
           // Console.WriteLine(rnd);
            for (var iteration = 0; iteration <= 3; iteration++)
            {
                var eingabe = HoleEingabe();
                if (iteration == 3)
                {
                    return "verloren";
                }
                if (rnd == eingabe)
                {
                    return "gewonnen";
                }
                Console.WriteLine("Das war leider Falsch");
            }
            return "";
        }

        public static void Ausgabe(string ergebnis)
        {
            switch (ergebnis)
            {
                case "gewonnen":
                    Console.WriteLine("Sie haben gewonnen!");
                    break;
                case "verloren":
                    Console.WriteLine("Sie haben verloren!");
                    break;
            }
        }
    }
}
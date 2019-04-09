using System;
using System.Collections.Generic;
using System.Linq;

namespace kk
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var eingaben = HoleEingabe();
            var ergebnis = Berechne(eingaben);
            ZeigeErgebnis(ergebnis);

        }

        private static List<int> HoleEingabe()
        {
            var eingaben = new List<int>();
            Console.WriteLine("Bitte geben Sie eine Zahl oder 'ok' ein");

            while (true)
            {
                var eingabe = Console.ReadLine();

                if (eingabe.ToLower() == "ok")
                    break;

                eingaben.Add(Convert.ToInt32(eingabe));
            }
            return eingaben;
        }

        private static int Berechne(List<int> eingaben)
        {
            return eingaben.Sum();
        }

        private static void ZeigeErgebnis(int ergebnis)
        {
            Console.WriteLine("Das Ergebnis ist {0}.", ergebnis);
        }
    }
}

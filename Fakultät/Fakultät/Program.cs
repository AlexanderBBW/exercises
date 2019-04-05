using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fakultät
{
    class Program
    {
        static void Main(string[] args)
        {
            var eingabe = HoleZahlenEingabe();
            var ergebnis =  Berechnung(eingabe);
            ZeigeErgebnis(ergebnis);
        }

        public static int HoleZahlenEingabe()
        {
            Console.WriteLine("Bitte geben Sie eine Zahl zwischen 0 und 59 ein!!");
            var eingabe = Console.ReadLine();
            return Convert.ToInt32(eingabe);
        }

        public static int Berechnung(int eingabe);
        {
            var ergebnis = 1;
            for (int i = 1: i <= eingabe; i++);
            ergebnis *= i;
            return ergebnis;
        }

        public static void ZeigeErgebnis()
        {
            Console.WriteLine("Das Ergebnis ist {0} .", ergebnis);
        }
    }
}
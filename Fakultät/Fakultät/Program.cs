using System;
namespace Fakultät
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var eingabe = HoleZahlenEingabe();
            var ergebnis =  Berechnung(eingabe);
            ZeigeErgebnis(ergebnis);
        }
        public static int HoleZahlenEingabe()
        {
            Console.WriteLine("Bitte geben Sie eine Zahl zwischen 0 und 59 ein!!");
            return Convert.ToInt32(Console.ReadLine());
        }
        public static int Berechnung(int eingabe)
        {
            int ergebnis = 1; 
            for (var i = 1; i <= eingabe; i++)
            {
                ergebnis = (eingabe - 1) * i;
            }
            return ergebnis;
        }
        public static void ZeigeErgebnis(int ergebnis)
        {
            Console.WriteLine("Das Ergebnis ist {0}", ergebnis);
        }
    }
}
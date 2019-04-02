using System;

namespace Zahlenvergleich
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var ersteZahl = ErfrageErsteZahl();
            var zweiteZahl = ErfrageZweiteZahl();
            var ergebnis = ÜberprüfeZahl(ersteZahl, zweiteZahl);
            Console.WriteLine("Ergebnis: " + ergebnis);
        }
        public static int ErfrageErsteZahl()
        {
            Console.WriteLine("Geben Sie die erste Zahl ein!");
            return Convert.ToInt32(Console.ReadLine());
        }
        public static int ErfrageZweiteZahl()
        {
            Console.WriteLine("Geben Sie die zweite Zahl ein!");
            return Convert.ToInt32(Console.ReadLine());
        }
        public static int ÜberprüfeZahl(int ersteZahl, int zweiteZahl)
        {
            if(ersteZahl > zweiteZahl)
                return ersteZahl;

            return zweiteZahl;
        }
    }
}
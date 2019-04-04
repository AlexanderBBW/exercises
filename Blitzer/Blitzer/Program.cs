using System;
namespace Blitzer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var maximal = ErfrageMaximalgeschwindigkeit();
            var aktuell = ErfrageAktuelleGeschwindigkeit();
            var punktzahl = ÜberprüfeEinhaltungTempolimit(maximal, aktuell);
            Ausgabe(punktzahl);
        }
        public static int ErfrageMaximalgeschwindigkeit()
        {
            Console.WriteLine("Geben Sie die Zugelassene ErfrageMaximalgeschwindigkeit an!");
            return Convert.ToInt32(Console.ReadLine());
        }
        public static int ErfrageAktuelleGeschwindigkeit()
        {
            Console.WriteLine("Mit welcher ErfrageAktuelleGeschwindigkeit ist das Fahrzeug gefahren?");
            return Convert.ToInt32(Console.ReadLine());
        }
        public static int ÜberprüfeEinhaltungTempolimit(int maximal, int aktuell)
        {
            if (maximal > aktuell)
                return 0;
            var differenz = aktuell - maximal;
            return differenz / 5;
        }
        private static void Ausgabe(int punktzahl)
        {
            if (punktzahl == 0)
                Console.WriteLine("Okay!");
            else if (punktzahl >= 12)
                Console.WriteLine("Führerschein wird eingezogen");
            else
                Console.WriteLine("Sie waren etwas zu schnell!");
            Console.WriteLine("Punktzahl: {0}", punktzahl);
        }
    }
}
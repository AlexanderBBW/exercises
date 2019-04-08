using System;
namespace ZahlenZwischen1und10
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var zahl = ErfrageZahl();
            var gültigkeit = GültigkeitsPrüfung(zahl);
            Ausgabe(gültigkeit);
        }
        private static int ErfrageZahl()
        {
            Console.WriteLine("Geben Sie bitte eine Zahl zwischen 1 und 10 ein");
            return Convert.ToInt32(Console.ReadLine());
        }
        internal static string GültigkeitsPrüfung(int zahl)
        {
            if (zahl >= 1 && zahl <= 10)
                return "gültig";
            return "ungültig";
        }
        private static void Ausgabe(string gültigkeit)
        {
            Console.WriteLine(gültigkeit);
        }
    }
}
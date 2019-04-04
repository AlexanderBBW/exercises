using System;
namespace BildHochformatQuerformat
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var breite = ErfrageBreite();
            var höhe = ErfrageHöhe();
            var hochformat = FormatAusgabe(höhe, breite);
            Ausgabe(hochformat);
        }
        private static int ErfrageHöhe()
        {
            Console.WriteLine("Geben Sie die Höhe an");
            return Convert.ToInt32(Console.ReadLine());
        }
        private static int ErfrageBreite()
        {
            Console.WriteLine("Geben Sie die Breite an");
            return Convert.ToInt32(Console.ReadLine());
        }
        public static bool FormatAusgabe(int höhe, int breite)
        {
            return höhe > breite;
        }
        private static void Ausgabe(bool hochformat)
        {
            Console.WriteLine(hochformat ? "Hochformat" : "Querformat");
        }
    }
}
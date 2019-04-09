using System;
namespace Okay_
{
    class Program
    {
        static void Main(string[] args)
        {
            var eingabe = HoleEingabe();
            var ergebnis = Berechne(eingabe);
            PrüfeObOk(eingabe, Convert.ToString(ergebnis));
        }
        private static ulong HoleEingabe()
        {
            Console.WriteLine("Geben Sie eine Zahl oder ok ein");
            return Convert.ToUInt64(Console.ReadLine());
        }
        private static string PrüfeObOk(ulong eingabe, string ergebnis)
        {
            if (Convert.ToString(eingabe) == "ok")
                return "Ihr Ergebnis ist {0} ";
            HoleEingabe();
            return ergebnis; 
        }
        private static int Berechne(ulong eingabe)
        {
            var ergebnis = eingabe + eingabe;
            return Convert.ToChar(ergebnis); 
        }
        private static string Ausgabe(char ergebnis)
        {
            switch (ergebnis)
            {
                case "ok":
                    Console.WriteLine("Das Ergebnis ist" , Convert.ToString(ergebnis));
                    break;
                case "HoleEingabe":
                      Console.WriteLine("Geben Sie eine weitere Zahl ein!");
                      break;
            }
            return Convert.ToString(ergebnis); 
        }
    }
}
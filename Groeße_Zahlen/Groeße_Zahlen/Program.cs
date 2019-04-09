using System;
using System.Collections.Generic;
using System.Linq;
namespace Groeße_Zahlen
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var eingabe = HoleEingabe();
            Ausgabe(eingabe);
        }
        internal static int HoleEingabe()
        {
            return Console.ReadLine().Split(',').ToList().ConvertAll(int.Parse).Max();
        }
        internal static void Ausgabe(int eingabe)
        {
            Console.WriteLine(eingabe);
        }
    }
}

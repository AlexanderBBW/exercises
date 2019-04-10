using System;
namespace _3dividieren
{
    class Program
    {
        public static void Main(string[] args)
        {
            const int min = 1;
            const int max = 100;
            var zähler = Berechne(min, max);
            Ausgabe(zähler);
        }
        public static int Berechne(int min, int max)
        {
            var zähler = 0;
            for (var iteration = min; iteration < max; iteration++)
            {
                if (iteration % 3 == 0)
                {
                    zähler++;
                    iteration++;
                }
                iteration++;
            }
            return zähler;
        }
        public static void Ausgabe(int zähler)
        {
            Console.WriteLine(zähler);
        }
    }
}
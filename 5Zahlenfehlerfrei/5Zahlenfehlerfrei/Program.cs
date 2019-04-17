using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace _5Zahlenfehlerfrei
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Input();
            var input2 = Sort(input);
            Output(input2);
        }

        private static List<int> Input()
        {
            var counter = 0;
            
            var zahlenListe = new List<int>();
            while (true)
            {
                if (counter == 5)
                    break;

                var input = Convert.ToInt32(Console.ReadLine());

                if (zahlenListe.Contains(input))
                {
                    Console.WriteLine("Die Zahl ist schon einmal Vorhanden , bitte geben Sie sich Mühe und geben eine neue Zahl ein!");
                }
                else
                {
                    zahlenListe.Add(input);
                    counter++;
                }
            }
            return zahlenListe;
        }
        private static int[] Sort(List<int> input)
        {
            return input.ToArray().OrderBy(p => p).ToArray();
        }
        private static void Output(int[] input)
        {
            Console.WriteLine(string.Join(",", input));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Übung_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie die erste Zahl ein");
            var erste_Zahl = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Geben Sie die zweite Zahl ein");
            var zweite_Zahl = Convert.ToInt16(Console.ReadLine());

            if (erste_Zahl >= zweite_Zahl)
                return "Die erste Zahl ist größer";
            else
                return "Die zweite Zahl ist größer";



        }
    }
}
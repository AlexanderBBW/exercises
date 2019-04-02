using System;

namespace ZahlenZwischen1und10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie bitte eine Zahl zwischen 1 und 10 ein");

            var eingabe = Convert.ToInt32(Console.ReadLine());

            if (eingabe >= 1 && eingabe <= 10)
                Console.WriteLine("gültig");
            else
                Console.WriteLine("ungültig");
            Console.ReadLine();
        }
    }
}
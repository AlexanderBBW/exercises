using System;

namespace NameRückwärts

{
        public class Program
    {
        public static void Main(string[] args)
        {
            Ausgabe(Convert(BenutzerEingabe()));
        }

        public static string BenutzerEingabe()
        {
            var eingabe = Console.ReadLine();
            return eingabe; 
        }

        public static char[] Convert(string eingabe)
        {
            char[] charArray = eingabe.ToCharArray();
            Array.Reverse(charArray);
            return charArray;
        }

        public static void Ausgabe(char[] convertedArray)
        {
            Console.WriteLine(string.Join("", convertedArray));
        }
    }
}
using System;
using System.Collections.Generic;
namespace Facebook
{
    class Program
    {
        static void Main(string[] args)                                 
        {
            var eingaben= HoleEingabe();
            Ausgabe(eingaben);
        }
        public static List<string> HoleEingabe()
        {
            var eingaben = new List<string>();
            while (true)
            {
                var eingabe = Console.ReadLine();
                if (eingabe == "")
                    break;
                eingaben.Add(eingabe);
            }
            return eingaben; 
        }
        public static void Ausgabe(List<string> eingaben )
        {
            switch (eingaben.Count)
            {
                case 1:
                    Console.WriteLine("{0} mag deinen Beitrag.", eingaben[0]);
                    break;
                case 2:
                    Console.WriteLine("{0} und {1} mögen deinen Beitrag.", eingaben[0], eingaben[1]);
                    break;
                default:
                    Console.WriteLine("{0} und {1} und {2} weitere mögen deinen Post", eingaben[0], eingaben[1], eingaben.Count-2);
                    break;
            }
        }
    }
}
using System;
namespace Fakultät_neuer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var zahl = HoleZahl();
            Fakultät(zahl); 
        }
        private static long HoleZahl()
        {
            Console.Write("Fakultät von n: ");
            var eingabe = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(Fakultät(eingabe));
            return eingabe; 
        }
        internal static long Fakultät(long zahl)
        {
            if (zahl <= 1)
            {
                return 1;
            }
            return zahl * Fakultät(zahl - 1);
        }
    }
}
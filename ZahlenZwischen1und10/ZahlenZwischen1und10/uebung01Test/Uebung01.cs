using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uebung01Test
{
    public class Uebung01
    {
        internal bool eingabe = PrüfeZahl(8);

        internal static bool PrüfeZahl(int zahl)
        {
            if (zahl >= 1 && zahl <= 10)
                return true;
            else
                return false;
        }
    }
}

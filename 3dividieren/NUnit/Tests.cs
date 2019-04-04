using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework; 
using _3dividieren;

namespace NUnit
{
    public class Tests
    {
        [TestFixture]
        public class Test1
        {
            [Test, Category("Akzeptanstest")]
            public static void DividierenÜberprüfung()
            {
                var Zahl = Program.Berechne(1, 100); 
                Assert.AreEqual(33, Zahl);
            }
        }
    }
}

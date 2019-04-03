using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using BildHochformatQuerformat;

namespace UNit
{
    public class Tests
    {
        [TestFixture]
        public class Test1
        {
            [Test, Category("Formattest")]
            public static void FormatAusgaben()
            {
                var format = Program.FormatAusgabe(1080, 1920);
                Assert.AreEqual(false, format);
            }
            [Test, Category("Formattest")]
            public static void FormatAusgaben2()
            {
                var format = Program.FormatAusgabe(1920, 1080);
                Assert.AreEqual(true, format);
            }
        }
    }
}

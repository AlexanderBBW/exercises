using System;
using System.IO;
using Gewinnspiel;
using NUnit.Framework;
using System.Text;

namespace NUnit
{
    [TestFixture]
    public class Tests
    {
        [Test, Category("TestGewinnen")]
        public static void TestGewinnen()
        {
            var pseudoEingabeString = new MemoryStream(Encoding.UTF8.GetBytes("1"));              //Nicht mein Code (SelbstÜberlegen nochmal notwendig )
            var eingabe = new StreamReader(pseudoEingabeString);                                    //Jonas genau befragen was genau das Problem war 
            Console.SetIn(eingabe);
            Assert.AreEqual("gewonnen", Program.PrüfeErgebnis( 1));
        }
        [Test, Category("TestVerlieren")]
        public static void TestVerlieren()
        {
            var pseudoEingabeString1 = new MemoryStream(Encoding.UTF8.GetBytes("2"));              //Nicht mein Code (SelbstÜberlegen nochmal notwendig )
            var eingabe = new StreamReader(pseudoEingabeString1);                                    //Jonas genau befragen was genau das Problem war 
            Console.SetIn(eingabe);
            Assert.AreEqual("verloren", Program.PrüfeErgebnis( 1));
        }
    }
}
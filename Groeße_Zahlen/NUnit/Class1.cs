using System;
using System.IO;
using System.Text;
using NUnit.Framework; 
using Groeße_Zahlen;

namespace NUnit
{
    public class Class1
    {
        [TestFixture]
        public class Test1
        {
            [Test, Category("NUnit Test")]
            public static void Testing()
            {
                var pseudoEingabeString = new MemoryStream(Encoding.UTF8.GetBytes("5,1,8,9,2"));
                var eingabe = new StreamReader(pseudoEingabeString);
                Console.SetIn(eingabe);
                Assert.AreEqual(9,Program.HoleEingabe());
            }
        }
    }
}
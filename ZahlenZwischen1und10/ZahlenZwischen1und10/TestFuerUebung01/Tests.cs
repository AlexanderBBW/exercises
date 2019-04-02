using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using uebung01Test;

namespace TestFuerUebung01
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TesteZahl()
        {
            var ergebnis = Uebung01.PrüfeZahl(11);
            Assert.IsFalse(ergebnis);
        }
        [Test]
        public void TesteZahl1()
        {
            var ergebnis = Uebung01.PrüfeZahl(3);
            Assert.IsTrue(ergebnis);
        }
    }
}

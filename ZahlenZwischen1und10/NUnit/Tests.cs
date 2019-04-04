using NUnit.Framework;
using ZahlenZwischen1und10;

namespace NUnit
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TesteZahl()
        {
            var ergebnis = Program.GültigkeitsPrüfung(11);
            Assert.AreEqual("ungültig", ergebnis);
        }
        [Test]
        public void TesteZahl1()
        {
            var ergebnis = Program.GültigkeitsPrüfung(3);
            Assert.AreEqual("gültig",ergebnis);
        }
    }
}

using NUnit.Framework;
using Zahlenvergleich;

namespace NUnit
{
    public class Tests
    {
        [TestFixture]
        public class Test1
        {
            [Test, Category("Akzeptanztest")]
            public static void VergleichZahlen()
            {
                var holeZahl = Program.ÜberprüfeZahl(5,6);
                Assert.AreEqual(6, holeZahl);
            }
        }
    }
}
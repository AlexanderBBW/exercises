using NUnit.Framework;
using Blitzer;

namespace NUnit
{
    public class Class1
    {
        [TestFixture]
        public class Test1
        {
            [Test, Category("Führerscheintest")]
            public static void Überprüfung()
            {
                var geschwindigkeit = Program.ÜberprüfeEinhaltungTempolimit(50, 30);
                Assert.AreEqual(0, geschwindigkeit);
            }
            [Test, Category("Führerscheintest")]
            public static void Überprüfung2()
            {
                var geschwindigkeit = Program.ÜberprüfeEinhaltungTempolimit(50, 60);
                Assert.AreEqual(2, geschwindigkeit);
            }
            [Test, Category("Führerscheintest")]
            public static void Überprüfung3()
            {
                var geschwindigkeit = Program.ÜberprüfeEinhaltungTempolimit(10, 100);
                Assert.AreEqual(18, geschwindigkeit);
            }
            [Test, Category("Führerscheintest")]
            public static void Überprüfung4()
            {
                var ges = Program.ÜberprüfeEinhaltungTempolimit(10, 10);
                Assert.AreEqual(0, ges);
            }
        }
    }
}

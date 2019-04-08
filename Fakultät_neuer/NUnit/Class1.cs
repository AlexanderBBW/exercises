using Fakultät_neuer;
using NUnit.Framework;

namespace NUnit
{
    public class Class1
    {
        [TestFixture]
        public class Test1
        {
            [Test, Category("Fakultät")]
            public static void Fakultät()
            {
                var fak = Program.Fakultät(5);
                Assert.AreEqual(120, fak);
            }

            [Test, Category("0 Überprüfung")]
            public static void Überprüfung()
            {
                var fak1 = Program.Fakultät(0);
                Assert.AreEqual(1, fak1);
            }
        }

    }
}

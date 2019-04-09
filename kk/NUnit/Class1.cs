using System.Collections.Generic;
using NUnit.Framework;
using kk;

namespace NUnit
{
    public class Class1
    {
        [TestFixture]
        public class Test1
        {
            [Test, Category("Testing")]
            public static void Testen()
            {
                var Test = Program.Berechne(new List<int> {5});
                Assert.AreEqual(5, Test);
            }
        }
    }
}
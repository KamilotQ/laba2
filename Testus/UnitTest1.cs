using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testus
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            const int n = 4;
            int[] a = new int[n] { 2, -1, -3, 4 };
            int result_1 = Laba2.Program.maxa(n, a);
            Assert.AreEqual(4, result_1);
            int result_2 = Laba2.Program.sum_of(n, a);
            Assert.AreEqual(-4, result_2);
        }
    }
}

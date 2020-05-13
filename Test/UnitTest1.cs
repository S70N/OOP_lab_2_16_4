using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(OOP_lab_2_16_4.Program.MinAbs(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 0 }), 0);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(OOP_lab_2_16_4.Program.MultiplicationBetweenFirstAndLastZeroes(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 0 }), 40320);
        }
    }
}

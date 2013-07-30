using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_UnitTestAppearanceOfNumberInArr
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] array = { 1, 7, 6, 1 };
            int input = AppearanceOfNumberInArr.CountAppearances(array, 1);
            Assert.AreEqual(2, input);

        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] array = { 7, 6, 6, 6 };
            int input = AppearanceOfNumberInArr.CountAppearances(array, 5);
            Assert.AreEqual(0, input);

        }
        [TestMethod]
        public void TestMethod3()
        {
            int[] array = { 1, 1, 6, 1 };
            int input = AppearanceOfNumberInArr.CountAppearances(array, 1);
            Assert.AreEqual(3, input);

        }
    }
}

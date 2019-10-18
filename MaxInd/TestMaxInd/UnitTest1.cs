using System;
using FindMaxInd;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestMaxInd
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            MaxInd el = new MaxInd();
            int[] array = { 1, 4, 7, 3, 6, 3 };
            Assert.AreEqual(el.FindMax(array), 3);
        }

        [TestMethod]
        public void Test2()
        {
            MaxInd el = new MaxInd();
            int[] array = { 0, 3, 5, 7, 2, 8, 6 };
            Assert.AreEqual(el.FindMax(array), 6);
        }

        [TestMethod]
        public void Test3()
        {
            MaxInd el = new MaxInd();
            int[] array = { 0, 2, 2, 7, 2, 2, 6 };
            Assert.AreEqual(el.FindMax(array), 4);
        }

        [TestMethod]
        public void Test4()
        {
            MaxInd el = new MaxInd();
            int[] array = { 4 };
            Assert.AreEqual(el.FindMax(array), 1);
        }

        [TestMethod]
        public void Test5()
        {
            MaxInd el = new MaxInd();
            int[] array = { 5, 2 };
            Assert.AreEqual(el.FindMax(array), 1);
        }

        [TestMethod]
        public void Test6()
        {
            MaxInd el = new MaxInd();
            int[] array = { 2, 2 };
            Assert.AreEqual(el.FindMax(array), 1);
        }

        [TestMethod]
        public void Test7()
        {
            MaxInd el = new MaxInd();
            int[] array = { 2, 6 };
            Assert.AreEqual(el.FindMax(array), 2);
        }

        [TestMethod]
        public void Test8()
        {
            MaxInd el = new MaxInd();
            int[] array = { 5, 2, 15 };
            Assert.AreEqual(el.FindMax(array), 3);
        }

        [TestMethod]
        public void Test9()
        {
            MaxInd el = new MaxInd();
            int[] array = { };
            Assert.AreEqual(el.FindMax(array), 0);
        }

        [TestMethod]
        public void Test10()
        {
            MaxInd el = new MaxInd();
            int[] array = { 3, 3, 3, 3, 3, 3 };
            Assert.AreEqual(el.FindMax(array), 1);
        }
    }
}

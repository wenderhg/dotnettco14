using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using tco14;

namespace tco14Test
{
    [TestClass]
    public class PackingBallsDiv2Test
    {
        PackingBallsDiv2 tester = new PackingBallsDiv2();

        [TestMethod]
        public void scenario_1()
        {
            int actual = tester.minPacks(4, 2, 4);
            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void scenario_2()
        {
            int actual = tester.minPacks(1, 7, 1);
            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void scenario_3()
        {
            int actual = tester.minPacks(2, 3, 5);
            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void scenario_4()
        {
            int actual = tester.minPacks(78, 53, 64);
            Assert.AreEqual(66, actual);
        }

        [TestMethod]
        public void scenario_5()
        {
            int actual = tester.minPacks(100, 100, 100);
            Assert.AreEqual(100, actual);
        }

        [TestMethod]
        public void scenario_6()
        {
            int actual = tester.minPacks(1, 2, 2);
            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void scenario_7()
        {
            int actual = tester.minPacks(1, 2, 5);
            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void scenario_8()
        {
            int actual = tester.minPacks(1, 5, 5);
            Assert.AreEqual(4, actual);
        }
        
        [TestMethod]
        public void scenario_9()
        {
            int actual = tester.minPacks(1, 4, 4);
            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void scenario_10()
        {
            int actual = tester.minPacks(2, 3, 3);
            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void scenario_11()
        {
            int actual = tester.minPacks(1, 3, 4);
            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void scenario_12()
        {
            int actual = tester.minPacks(3, 3, 5);
            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void scenario_13()
        {
            int actual = tester.minPacks(4, 5, 5);
            Assert.AreEqual(5, actual);
        }

    }
}

using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace goTravelDemo.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void VerifyBubbleSort()
        {
            int[] unsortedArray = new int[] { 6, 0, 3, 5, -5, 8, 3, 1 };
            int[] sortedArray = new int[] { -5, 0, 1, 3, 3, 5, 6, 8 };
            var res = BubbleSort.DoBubbleSort(unsortedArray).ToArray();
            CollectionAssert.AreEqual(sortedArray,res);
        }

        [TestMethod]
        public void VerifyPower()
        {
            int x = 10;
            int pow = 2;
            var res = Power.power(x, pow);
            Assert.AreEqual(100, res);
        }
    }
}

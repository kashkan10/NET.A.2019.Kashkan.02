using NUnit.Framework;
using FindNthRoot;
using System;

namespace Tests
{
    public class FindNthRootTests
    {
        [Test]
        public void FindNthRoot_Positive_Test()
        {
            Assert.AreEqual(FindRoot.FindNthRoot(1, 5, 0.0001), 1);
            Assert.AreEqual(FindRoot.FindNthRoot(0.04100625, 4, 0.0001), 0.45);
            Assert.AreEqual(FindRoot.FindNthRoot(0.0279936, 7, 0.0001), 0.6);
            Assert.AreEqual(FindRoot.FindNthRoot(-0.008, 3, 0.1), -0.24);
        }

        [Test]
        public void FindNthRoot_Negative_Test()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => FindRoot.FindNthRoot(15, 5, 12));
        }
    }
}

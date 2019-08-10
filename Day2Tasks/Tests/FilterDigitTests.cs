using NUnit.Framework;
using FilterDigit;
using System.Collections.Generic;

namespace Tests
{
    public class FilterDigitTests
    {
        List<int> list = new List<int> { 345, 234, 1, 34, 5, 8, 45, 6 };

        [Test]
        public void Test1()
        {
            list = FilterDg.FilterDigit(list,5);
            Assert.AreEqual(new List<int> {345, 5, 45}, list);
        }

        [Test]
        public void Test2()
        {
            list = FilterDg.FilterDigit(list, 6);
            Assert.AreNotEqual(new List<int> {345, 1, 6}, list);
        }
    }
}
﻿using NUnit.Framework;
using FindNextBiggerNumber;
using System;

namespace Tests
{
    public class FindNextBiggerTests
    {
        [Test]
        public void FindNextBiggerNumber_Positive_Test()
        {
            Assert.AreEqual(NextBigger.FindNextBiggerNumber(12), 21);
            Assert.AreEqual(NextBigger.FindNextBiggerNumber(513), 531);
            Assert.AreEqual(NextBigger.FindNextBiggerNumber(2017), 2071);
            Assert.AreEqual(NextBigger.FindNextBiggerNumber(414), 441);
            Assert.AreEqual(NextBigger.FindNextBiggerNumber(144), 414);
            Assert.AreEqual(NextBigger.FindNextBiggerNumber(1234321), 1241233);
            Assert.AreEqual(NextBigger.FindNextBiggerNumber(1234126), 1234162);
            Assert.AreEqual(NextBigger.FindNextBiggerNumber(3456432), 3462345);
        }

        [Test]
        public void FindNextBiggerNumber_Negative_Test()
        {
            Assert.AreEqual(NextBigger.FindNextBiggerNumber(10), -1);
            Assert.AreEqual(NextBigger.FindNextBiggerNumber(20), -1);
            Assert.Throws<ArgumentException>(() => NextBigger.FindNextBiggerNumber(-1));
        }

    }
}
using NUnit.Framework;
using InsertNumber;

namespace Tests
{
    class InsertNumberTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(NumInsert.InsertNumber(15, 15, 0, 0), 15);
            Assert.AreEqual(NumInsert.InsertNumber(8, 15, 0, 0), 9);
            Assert.AreEqual(NumInsert.InsertNumber(8, 15, 3, 8), 120);
        }
    }
}

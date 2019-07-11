using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MDCC_ScreenQ1;

namespace MakeChangeTests
{
    [TestClass]
    public class UnitTest1
    {
        // Tests of valid amounts as input. Cases where 0, 1 and more than 1 bills are returned.
        [TestMethod]
        public void MakeChange_ValidAmount()
        {
            Assert.AreEqual(Program.MakeChange(376), 7);
            Assert.AreEqual(Program.MakeChange(5), 1);
            Assert.AreEqual(Program.MakeChange(0), 0);
        }

        // Input amounts are assumed positive by definition. A negative input results in exception.
        [TestMethod]
        public void MakeChange_AmountLessThanZero_ShouldThrowArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => Program.MakeChange(-55));
        }
    }
}

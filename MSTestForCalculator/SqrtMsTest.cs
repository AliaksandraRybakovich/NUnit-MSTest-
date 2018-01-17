using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace MSTestForCalculator
{
    [TestClass]
    public class SqrtMsTest
    {
        Calculator cl;

        [TestInitialize]
        public void Precondition()
        {
            cl = new Calculator();
            Console.WriteLine("CheckSqrtMsTest: 4 tests");
        }

        [TestMethod]
        [TestCategory("MsTest"), TestCategory("Sqrt")]
        [DataRow(-2)]
        [DataRow(4)]
        [DataRow(2.5)]
        [DataRow("1")]
        public void CheckSqrtMsTest(object a)
        {
            //act
            var actual = cl.Sqrt(Convert.ToDouble(a));
            var expected = Math.Sqrt(Convert.ToDouble(a));

            //assert
            Assert.AreEqual(expected, actual, $"SQRT from {a} should be {expected} but was {actual}");
        }

        [TestCleanup]
        public void Postcondition()
        {
            Console.WriteLine("End");
        }
    }
}

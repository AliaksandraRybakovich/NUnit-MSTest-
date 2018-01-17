using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace MSTestForCalculator
{
    [TestClass]
    public class SubMsTest
    {
        Calculator cl;

        [TestInitialize]
        public void Precondition()
        {
            cl = new Calculator();
            Console.WriteLine("CheckSubMsTest: 5 tests");
        }

        [TestMethod()]
        [TestCategory("MsTest"), TestCategory("Sub")]
        [DataRow(2, 1)]
        [DataRow(2, 3)]
        [DataRow(-2, 3)]
        [DataRow(2.5, 0.5)]
        [DataRow("-2", "-2")]
        public void CheckSubMsTest(object a, object b)
        {
            //act
            var actual = cl.Sub(Convert.ToDouble(a), Convert.ToDouble(b));
            var expected = Convert.ToDouble(a) - Convert.ToDouble(b);

            //assert
            Assert.AreEqual(expected, actual, $"SUB from {a} should be {expected} but was {actual}");
        }

        [TestCleanup]
        public void Postcondition()
        {
            Console.WriteLine("End");
        }
    }
}

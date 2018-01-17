using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace MSTestForCalculator
{
    [TestClass]
    public class SinMsTest
    {
        Calculator cl;

        [TestInitialize]
        public void Precondition()
        {
            cl = new Calculator();
            Console.WriteLine("CheckSinMsTest: 5 tests");
        }

        [TestMethod]
        [TestCategory("MsTest"), TestCategory("Sin")]
        [DataRow(2 * Math.PI)]
        [DataRow(-3)]
        [DataRow(0)]
        [DataRow(5.25)]
        [DataRow("1.2")]
        public void CheckSinMsTest(object a)
        {
            //act
            var actual = cl.Sin(Convert.ToDouble(a));
            var expected = Math.Sin(Convert.ToDouble(a));

            //assert
            Assert.AreEqual(expected, actual, $"SIN from {a} should be {expected} but was {actual}");
        }

        [TestCleanup]
        public void Postcondition()
        {
            Console.WriteLine("End");
        }
    }
}

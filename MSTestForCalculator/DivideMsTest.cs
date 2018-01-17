using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace MSTestForCalculator
{
    [TestClass]
    public class DivideMsTest
    {
        Calculator cl;

        [TestInitialize]
        public void Precondition()
        {
            cl = new Calculator();
            Console.WriteLine("CheckDivideMsTest: 4 tests");
        }
        
        [TestCategory("MsTest"), TestCategory("Divide")]
        [DataRow(2, 0)]
        [DataRow(2.3, 2)]
        [DataRow(-2, 2)]
        [DataRow("2", "2.5")]
        [ExpectedException(typeof(DivideByZeroException))]
        public void CheckDivideMsTest(object a, object b)
        {
            //act                     
            var actual = cl.Divide(Convert.ToDouble(a), Convert.ToDouble(b));
            var expected = Convert.ToDouble(a) / Convert.ToDouble(b);

            if (Double.IsInfinity(actual))
            {
                Assert.ThrowsException<DivideByZeroException>(() => cl.Divide(Convert.ToDouble(a), Convert.ToDouble(b)));             
            }

            //assert
            Assert.AreEqual(expected, actual, $"DIVIDE from {a} should be {expected} but was {actual}");

        }

        [TestCleanup]
        public void Postcondition()
        {
            Console.WriteLine("End");
        }
    }
}

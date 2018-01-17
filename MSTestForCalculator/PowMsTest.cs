using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace MSTestForCalculator
{
    [TestClass]
    public class PowMsTest
    {
        Calculator cl;

        [TestInitialize]
        public void Precondition()
        {
            cl = new Calculator();
            Console.WriteLine("CheckPowMsTest: 6 tests");
        }

        [TestMethod]
        [TestCategory("MsTest"), TestCategory("Pow")]
        [DataRow(-2, 3)]
        [DataRow(2, 5)]
        [DataRow(2.5, 2)]
        [DataRow(2, 2.5)]
        [DataRow(2, -2)]
        [DataRow("1", "1.5")]
        [ExpectedException(typeof(NotFiniteNumberException))]
        public void CheckPowMsTest(object a, object b)
        {
            double actual;

            //act  
            try
            {
                actual = cl.Pow(a, b);

            }
            catch
            {
                Assert.ThrowsException<NotFiniteNumberException>(() => cl.Pow(a, b), "No Exception to be thrown");
                return;
            }

            var expected = Math.Pow(Convert.ToDouble(a), Convert.ToDouble(b));

            Assert.AreEqual(expected, actual, $"POW from {a} should be {expected} but was {actual}");
        }

        [TestCleanup]
        public void Postcondition()
        {
            Console.WriteLine("End");
        }
    }
}

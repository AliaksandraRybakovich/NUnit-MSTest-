using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace MSTestForCalculator
{
    [TestClass]
    public class MultiplyMsTest
    {
        Calculator cl;

        [TestInitialize]
        public void Precondition()
        {
            cl = new Calculator();
            Console.WriteLine("CheckMultiplyMsTest: 5 tests");
        }

        
        [TestCategory("MsTest"), TestCategory("Multiply")]
        [DataRow(2, 0)]
        [DataRow(-2, 2)]
        [DataRow(-2.3, 7)]
        [DataRow(2.3, 7.3)]
        [DataRow("2", "7.5")]
        public void CheckMultiplyMsTest(object a, object b)
        {
            //act
            var actual = cl.Multiply(Convert.ToDouble(a), Convert.ToDouble(b));
            var expected = Convert.ToDouble(a) * Convert.ToDouble(b);

            //assert
            Assert.AreEqual(expected, actual, $"MULTIPLY from {a} should be {expected} but was {actual}");
        }

        [TestCleanup]
        public void Postcondition()
        {
            Console.WriteLine("End");
        }
    }
}

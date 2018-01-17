using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace MSTestForCalculator
{ 
    [TestClass]
    public class AbsMsTest
    {
        Calculator cl;
        double actual;
        double expected;

        [TestInitialize]
        public void Precondition()
        {
            cl = new Calculator();
            Console.WriteLine("CheckAbsMsTest: 4 tests");
        }
        
        [TestCategory("MsTest"), TestCategory("Abs")]
        [DataTestMethod]
        [DataRow(1.35)]
        [DataRow(0)]
        [DataRow(-5)]
        [DataRow("2.5")]
        [DataRow("2")]
        public void CheckAbsMsTest(object a)
        {
            //act
            actual = cl.Abs(Convert.ToDouble(a));
            expected = Math.Abs(Convert.ToDouble(a));

            //assert 
            Assert.AreEqual(expected, actual, $"ABS from {a} should be {expected} but was {actual}");
        }

        [TestCleanup]
        public void Postcondition()
        {
            Console.WriteLine("End");
        }
    }
}
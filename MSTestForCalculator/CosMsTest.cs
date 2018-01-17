using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;


namespace MSTestForCalculator
{
    [TestClass]
    public class CosMsTest
    {
        Calculator cl;

        [TestInitialize]
        public void Precondition()
        {
            cl = new Calculator();
            Console.WriteLine("CheckCosMsTest: 4 tests");
        }

        [TestCategory("MsTest"), TestCategory("Cos")]
        [DataTestMethod]
        [DataRow(0)]
        [DataRow(6.25)]
        [DataRow(-4)]
        [DataRow("6.25")]
        public void CheckCosMsTest(object a)
        {
            //act
            var actual = cl.Cos(a);
            var expected = Math.Cos(Convert.ToDouble(a));

            //assert
            Assert.AreEqual(expected, actual, $"COS from {a} should be {expected} but was {actual}");
        }

        [TestCleanup]
        public void Postcondition()
        {
            Console.WriteLine("End");
        }
    }
}

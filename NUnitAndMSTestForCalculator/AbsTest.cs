using System;
using NUnit.Framework;
using CSharpCalculator;

namespace NUnitAndMSTestForCalculator
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class AbsTest
    {
        Calculator cl;
        double actual;
        double expected;

        [SetUp]
        public void Precondition()
        {
            cl = new Calculator();
            Console.WriteLine("CheckAbs: 4 tests");
        }

        [Test]
        [Category("NUnit"), Category("Abs")]
        [TestCase(1.35)]
        [TestCase(0)]
        [TestCase(-5)]
        [TestCase("2.5")]
        [TestCase("2")]
        public void CheckAbs(object a)
        {
            //act
            actual = cl.Abs(Convert.ToDouble(a));
            expected = Math.Abs(Convert.ToDouble(a)); 

            //assert 
            Assert.AreEqual(expected, actual, $"ABS from {a} should be {expected} but was {actual}");         
        }
              
        [TearDown]
        public void Postcondition()
        {
            Console.WriteLine("End");
        }
    }
}

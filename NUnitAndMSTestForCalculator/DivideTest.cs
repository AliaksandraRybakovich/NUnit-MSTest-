using System;
using NUnit.Framework;
using CSharpCalculator;

namespace NUnitAndMSTestForCalculator
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class DivideTest
    {
        Calculator cl;

        [SetUp]
        public void Precondition()
        {
            cl = new Calculator();
            Console.WriteLine("CheckDivide: 4 tests");
        }

        [Test]
        [Category("NUnit"), Category("Divide")]
        [TestCase(2, 0)]
        [TestCase(2.3, 2)]
        [TestCase(-2,2)]
        [TestCase("2","2.5")]
        public void CheckDivide(object a, object b)
        {
            //act                     
            var actual = cl.Divide(Convert.ToDouble(a), Convert.ToDouble(b));
            var expected = Convert.ToDouble(a) / Convert.ToDouble(b);

            if (Double.IsInfinity(actual))
            {
                Assert.Throws<DivideByZeroException>(() => cl.Divide(Convert.ToDouble(a), Convert.ToDouble(b)));
            }

            //assert
            Assert.AreEqual(expected, actual,  $"DIVIDE from {a} should be {expected} but was {actual}");
            
        }

        [TearDown]
        public void Postcondition()
        {
            Console.WriteLine("End");
        }
    }
}

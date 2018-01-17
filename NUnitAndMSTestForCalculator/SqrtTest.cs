using System;
using NUnit.Framework;
using CSharpCalculator;

namespace NUnitAndMSTestForCalculator
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class SqrtTest
    {
        Calculator cl;

        [SetUp]
        public void Precondition()
        {
            cl = new Calculator();
            Console.WriteLine("CheckSqrt: 4 tests");
        }

        [Test]
        [Category("NUnit"), Category("Sqrt")]
        [TestCase(-2)]
        [TestCase(4)]
        [TestCase(2.5)]
        [TestCase("1")]
        public void CheckSqrt(object a)
        {
            //act
            var actual = cl.Sqrt(Convert.ToDouble(a));
            var expected = Math.Sqrt(Convert.ToDouble(a));

            //assert
            Assert.AreEqual(expected, actual, $"SQRT from {a} should be {expected} but was {actual}");
        }

        [TearDown]
        public void Postcondition()
        {
            Console.WriteLine("End");
        }
    }
}

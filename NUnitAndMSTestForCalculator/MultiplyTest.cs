using System;
using NUnit.Framework;
using CSharpCalculator;

namespace NUnitAndMSTestForCalculator
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class MultiplyTest
    {
        Calculator cl;

        [SetUp]
        public void Precondition()
        {
            cl = new Calculator();
            Console.WriteLine("CheckMultiply: 5 tests");
        }

        [Test]
        [Category("NUnit"), Category("Multiply")]
        [TestCase(2,0)]
        [TestCase(-2,2)]
        [TestCase(-2.3, 7)]
        [TestCase(2.3, 7.3)]
        [TestCase("2", "7.5")]
        public void CheckMultiply(object a, object b)
        {
            //act
            var actual = cl.Multiply(Convert.ToDouble(a), Convert.ToDouble(b));
            var expected = Convert.ToDouble(a) * Convert.ToDouble(b);

            //assert
            Assert.AreEqual(expected, actual,  $"MULTIPLY from {a} should be {expected} but was {actual}");
        }

        [TearDown]
        public void Postcondition()
        {
            Console.WriteLine("End");
        }
    }
}

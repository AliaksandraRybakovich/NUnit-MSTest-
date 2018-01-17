using System;
using NUnit.Framework;
using CSharpCalculator;

namespace NUnitAndMSTestForCalculator
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class SinTest
    {
        Calculator cl;

        [SetUp]
        public void Precondition()
        {
            cl = new Calculator();
            Console.WriteLine("CheckSin: 5 tests");
        }

        [Test]
        [Category("NUnit"), Category("Sin")]
        [TestCase(2*Math.PI)]
        [TestCase(-3)]
        [TestCase(0)]
        [TestCase(5.25)]
        [TestCase("1.2")]
        public void CheckSin(object a)
        {
            //act
            var actual = cl.Sin(Convert.ToDouble(a));
            var expected = Math.Sin(Convert.ToDouble(a));

            //assert
            Assert.AreEqual(expected, actual,  $"SIN from {a} should be {expected} but was {actual}");
        }

        [TearDown]
        public void Postcondition()
        {
            Console.WriteLine("End");
        }
    }
}

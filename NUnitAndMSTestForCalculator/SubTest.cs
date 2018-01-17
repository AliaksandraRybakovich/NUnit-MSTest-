using System;
using NUnit.Framework;
using CSharpCalculator;

namespace NUnitAndMSTestForCalculator
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class SubTest
    {
        Calculator cl;

        [SetUp]
        public void Precondition()
        {
            cl = new Calculator();
            Console.WriteLine("CheckSub: 5 tests");
        }

        [Test]
        [Category("NUnit"), Category("Sub")]
        [TestCase(2,1)]
        [TestCase(2,3)]
        [TestCase(-2,3)]
        [TestCase(2.5, 0.5)]
        [TestCase("-2", "-2")]
        public void CheckSub(object a, object b)
        {
            //act
            var actual = cl.Sub(Convert.ToDouble(a), Convert.ToDouble(b));
            var expected = Convert.ToDouble(a) - Convert.ToDouble(b);

            //assert
            Assert.AreEqual(expected, actual, $"SUB from {a} should be {expected} but was {actual}");            
        }

        [TearDown]
        public void Postcondition()
        {
            Console.WriteLine("End");
        }
    }
}

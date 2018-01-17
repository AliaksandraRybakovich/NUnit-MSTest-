using System;
using NUnit.Framework;
using CSharpCalculator;

namespace NUnitAndMSTestForCalculator
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class PowTest
    {
        Calculator cl;        

        [SetUp]
        public void Precondition()
        {
            cl = new Calculator();
            Console.WriteLine("CheckPow: 6 tests");
        }

        [Test]        
        [Category("NUnit"), Category("Pow")]
        [TestCase(-2, 3)]
        [TestCase(2, 5)]
        [TestCase(2.5, 2)]
        [TestCase(2, 2.5)]
        [TestCase(2, -2)]        
        [TestCase("1", "1.5")]
        public void CheckPow(object a, object b)
        {
            double actual;

            //act  
            try
            {
                 actual = cl.Pow(a, b);           

            }
            catch
            {
                Assert.DoesNotThrow(() => cl.Pow(a, b),"No Exception to be thrown");
                return;
            }

            var expected = Math.Pow(Convert.ToDouble(a), Convert.ToDouble(b));

            Assert.AreEqual(expected, actual, $"POW from {a} should be {expected} but was {actual}");
        }

        [TearDown]
        public void Postcondition()
        {
            Console.WriteLine("End");
        }
    }
}

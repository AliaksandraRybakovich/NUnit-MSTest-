using System;
using NUnit.Framework;
using CSharpCalculator;

namespace NUnitAndMSTestForCalculator
{
   [TestFixture]
   [Parallelizable(ParallelScope.Fixtures)]
    public class CosTest
    {
        Calculator cl;

        [SetUp]
        public void Precondition()
        {
            cl = new Calculator();
            Console.WriteLine("CheckCos: 4 tests");
        }

        [Test, Category("NUnit"), Category("Cos")]        
        [TestCase(0)]
        [TestCase(6.25)]
        [TestCase(-4)]
        [TestCase("6.25")]
        public void CheckCos(object a)
        {
            //act
            var actual = cl.Cos(a);
            var expected = Math.Cos(Convert.ToDouble(a));

            //assert
            Assert.AreEqual(expected, actual,  $"COS from {a} should be {expected} but was {actual}");
        }
               
        [TearDown]
        public void Postcondition()
        {
            Console.WriteLine("End");
        }
    }
}

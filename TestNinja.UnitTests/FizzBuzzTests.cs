using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        //  All test has Method_Scenario_ExpectedResult

        [Test]
        public void GetOutput_ImputIsDevisibleBy3And5_ReturnFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(15);
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutput_ImputIsDevisibleBy3Only_ReturnFizz()
        {
            var result = FizzBuzz.GetOutput(3);
            Assert.That(result, Is.EqualTo("Fizz"));
        }
        [Test]
        public void GetOutput_ImputIsDevisibleBy5Only_ReturnBuzz()
        {
            var result = FizzBuzz.GetOutput(5);
            Assert.That(result, Is.EqualTo("Buzz"));
        }
        [Test]
        public void GetOutput_ImputIsNotDevisibleBy3And5_ReturnSameNumber()
        {
            var result = FizzBuzz.GetOutput(1);
            Assert.That(result, Is.EqualTo("1"));
        }
    }
}

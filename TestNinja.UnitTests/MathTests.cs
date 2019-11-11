using NUnit.Framework;
using System.Linq;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class MathTests
    {
        private Math _math;
        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test]  
      //  [Ignore("Because I wanted to!")]
        public void Add_WhenCalled_ReturnTheSunOfArguments()
        {
            var result = _math.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGraterArgument(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }


        [Test]
        public void GetOddNumbers_WhenCalled_LimitIsGraterYhenZero_ReturnOddNumbersUpYoLimit()
        {
            var result = _math.GetOddNumbers(5);

            // More generale
            // Assert.That(result, Is.Not.Empty);
            // Assert.That(result.Count(), Is.EqualTo(3));

            // More specific
            // Assert.That(result, Does.Contain(1));
            // Assert.That(result, Does.Contain(3));
            // Assert.That(result, Does.Contain(5));

            Assert.That(result, Is.EquivalentTo(new[] {1, 3, 5}));


            // Examples
            // Assert.That(result, Is.Ordered);
            // Assert.That(result, Is.Unique);
        }
    }
}

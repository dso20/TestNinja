using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinjaTests.Fundamentals
{    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        private DemeritPointsCalculator c = new DemeritPointsCalculator();
        
        [TestCase(-2)]
        [TestCase(400)]
        [Test]
        public void CalculateDemeritPoints_SpeedOutOfRange_ThrowException(int speed)
        {

            
            Assert.That(() => c.CalculateDemeritPoints(speed), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());

        }
    }
}
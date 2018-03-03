using System;
using NUnit.Framework;
using TestNinja;
using TestNinja.Fundamentals;

namespace NinjaTest
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        private DemeritPointsCalculator c = new DemeritPointsCalculator();
        
        [TestCase(-2)]
        [TestCase(400)]
        [Test]
        public void CalculateDemeritPoints_SpeedLess0orOverMax_ArgumentOutofRangeException(int speed)
        {
            Assert.That(() => c.CalculateDemeritPoints(speed), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }
        
        [Test]
        public void CalculateDemeritPoints_SpeedLessThanMax_return0()
        {
            var result = c.CalculateDemeritPoints(50);
            
            Assert.That(result,Is.EqualTo(0));
        }
        
        [Test]
        public void CalculateDemeritPoints_OverSpeedLimitUnderMax_returnpoints_()
        {
            var result = c.CalculateDemeritPoints(99);
            
            Assert.That(result,Is.EqualTo(6));
        }
    }
}
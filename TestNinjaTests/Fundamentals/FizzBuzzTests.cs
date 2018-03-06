using NUnit.Framework;
using NUnit.Framework.Internal;
using TestNinja.Fundamentals;

namespace TestNinjaTests.Fundamentals
{    [TestFixture]
    public class FizzBuzzTests
    {    
        [TestCase(15)]
        [Test]
        public void GetOutput_DivisibleBy3and5_ReturnsString(int num)
        {
            var result = FizzBuzz.GetOutput(num);
            
            Assert.That(result,Is.EqualTo("FizzBuzz").IgnoreCase);
        }   
    }
}
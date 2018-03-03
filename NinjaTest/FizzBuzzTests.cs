using System;
using NUnit.Framework;
using TestNinja;
using TestNinja.Fundamentals;

namespace NinjaTest
{
    [TestFixture]
    public class FizzBuzzTests
    {
        
        [TestCase(15)]
        [Test]
        public void GetOutput_DivideBy3and5_returnsFizzBuzz(int val)
        {
            var result = FizzBuzz.GetOutput(val); 
            
            Assert.That(result, Is.EqualTo("FizzBuzz"));
            
    
        }
        
        
        [TestCase(6)]
        [Test]
        public void GetOutput_DivideBy3_returnsFizz(int val)
        {
            var result = FizzBuzz.GetOutput(val); 
            
            Assert.That(result, Is.EqualTo("Fizz"));
            
    
        }
        
        [TestCase(10)]
        [Test]
        public void GetOutput_DivideBy3and5_returnsBuzz(int val)
        {
            var result = FizzBuzz.GetOutput(val); 
            
            Assert.That(result, Is.EqualTo("Buzz"));
            
    
        }
        
        [TestCase(7)]
        [Test]
        public void GetOutput_DivideBy3and5_returnVal(int val)
        {
            var result = FizzBuzz.GetOutput(val); 
            
            Assert.That(result, Is.EqualTo(val.ToString()));
            
    
        }
    }
}
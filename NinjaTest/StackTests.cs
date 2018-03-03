using NUnit.Framework;
using TestNinja.Fundamentals;

namespace NinjaTest
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void Push_ArgumentisNull_Throwexception()
        {
            var stack = new Stack<string>();
            
            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);
            
        }
        
        [Test]
        public void Psuh__ValidArgument_AddObject()
        {
            var stack = new Stack<string>();
            stack.Push("a");

            Assert.That(stack.Count, Is.EqualTo(1));

        }
        
        [Test]
        public void Count_EmptyStack_0()
        {
            var stack = new Stack<string>();

            Assert.That(stack.Count, Is.EqualTo(0));
        }
        
        [Test]
        public void Pop_EmptyStack_InvalidOperationException()
        {
            var stack = new Stack<string>();
            
            Assert.That(() => stack.Pop(), Throws.InvalidOperationException);
        }
        
        [Test]
        public void Pop_StackWithObjects_ReturnTop()
        {
            
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            var result = stack.Pop();
            
            Assert.That(result, Is.EqualTo("c"));
        }
        
        [Test]
        public void Pop_StackWithObjects_RemoveTop()
        {
            var stack = new Stack<string>();
            
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            var result = stack.Pop();
            
            Assert.That(stack.Count,Is.EqualTo(2));

        }
        
        [Test]
        public void Peek_StackIsEmpty_InvalidOpException()
        {
            var stack = new Stack<string>();
            
            Assert.That(() => stack.Peek(),Throws.InvalidOperationException);
        }
        
        [Test]
        public void Peek_StackWithObjects_ReturnTop()
        {
             var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("C");

            var result = stack.Peek();
            
            Assert.That(result,Is.EqualTo("c").IgnoreCase);
        }
        
        [Test]
        public void Peek_StackWithObjects_NotRemoveTop()
        {
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("C");

            var result = stack.Peek();
            
            Assert.That(stack.Count,Is.EqualTo(3));
        }
    }
}
using Moq;
using NUnit.Framework;
using TestNinja.Mocking;

namespace NinjaTest
{    [TestFixture]
    public class EmployeeControlerTests
    {
        [Test]
        public void DeleteEmployee_OnCall_Delete()
        {
            var repo = new Mock<IEmployeeRepo>();
            var controler = new EmployeeController(repo.Object);

            controler.DeleteEmployee(1);
            
            repo.Verify(d => d.DeleteEmployy(1));
        }
        
        [Test]
        public void DeleteEmploy_OnCall_ReturnsRedirectResult()
        {
            var repo = new Mock<IEmployeeRepo>();
            var controler = new EmployeeController(repo.Object);

            var result = controler.DeleteEmployee(1);
            
           // Assert.IsInstanceOf(result,typeof(ActionResult));
          

        }
    }
}
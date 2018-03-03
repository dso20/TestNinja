namespace TestNinja.Mocking
{
    public interface IEmployeeRepo
    {
        void DeleteEmployy(int id);
    }

    public class EmployeeRepo : IEmployeeRepo
    {
        private EmployeeContext _db;

        public EmployeeRepo()
        {
            _db = new EmployeeContext();
        }
        
        public void DeleteEmployy(int id)
        {
            var employee = _db.Employees.Find(id);
            if (employee != null)
            {
                _db.Employees.Remove(employee);
                _db.SaveChanges();
            }
        
        }
    }
}
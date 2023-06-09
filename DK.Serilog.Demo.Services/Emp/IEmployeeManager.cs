
namespace DK.Serilog.Demo.Services.Emp
{
    public interface IEmployeeManager
    {
        void AddEmployee(Employee employee);
        List<Employee> GetEmployeeNames();
    }
}

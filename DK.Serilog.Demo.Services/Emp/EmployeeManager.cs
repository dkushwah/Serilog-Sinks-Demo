using Microsoft.Extensions.Logging;

namespace DK.Serilog.Demo.Services.Emp;

public class EmployeeManager:IEmployeeManager
{
    private readonly ILogger<IEmployeeManager> _logger;

    public EmployeeManager(ILogger<IEmployeeManager> logger)
    {
        _logger = logger;
            
    }

    private static readonly IList<Employee> Employees = new List<Employee>();

    public void AddEmployee(Employee employee)
    {
        try
        {
            _logger.LogInformation("Trying to add Employee");
            _logger.LogDebug($"Adding Employee With Id{employee.Id} and Name{employee.Name}");
            ArgumentNullException.ThrowIfNull(employee.Name);
            Employees.Add(employee);
            _logger.LogInformation("Employee Added Successfully");
        }
        catch (Exception e)
        {
            _logger.LogWarning(e.Message);
        }
    }

    public List<Employee> GetEmployeeNames()
    {
        if (!Employees.Any())
        {
            Employees.Add(new Employee() { Id = 1, Name = "Owner" });
        }

        return Employees.ToList();
    }
}
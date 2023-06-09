using DK.Serilog.Demo.Services;
using DK.Serilog.Demo.Services.Emp;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DK.Serilog.Demo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<PageModel> _logger;
        private readonly IEmployeeManager _employeeManager;

        public IndexModel(ILogger<PageModel> logger,IEmployeeManager employeeManager)
        {
            _logger = logger;
            _employeeManager = employeeManager;
        }

        public void OnGet()
        {
            _logger.LogInformation("Trying to Fetch List Of Employees");
            _employeeManager.AddEmployee(new Employee()
            {
                Id = 2, Name = null
            });
            
            ViewData["Employees"] = _employeeManager.GetEmployeeNames();
            _logger.LogInformation("Fetched List Of Employees");
        }
    }
}
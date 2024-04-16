using Microsoft.AspNetCore.Mvc;
using TaskEmployeePage.Models;

namespace TaskEmployeePage.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            var employees = new List<Employee>
    {
        new Employee { EmployeeId = 1, FirstName = "Saleh", LastName = "Bin Essa", Email = "saleh.binessa@gmail.com", Department = "IT"},
        new Employee { EmployeeId = 2, FirstName = "Nawaf", LastName = "Almutairi", Email = "nawaf.almutairi@gmail.com", Department = "IT"},
    };

            return View(employees);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using SalesWebAplication.Models;

namespace SalesWebAplication.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { ID = 1, Name = "Eletronics" });
            list.Add(new Department { ID = 1, Name = "Fashion" });

            return View(list);
        }
    }
}

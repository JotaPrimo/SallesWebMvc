using Microsoft.AspNetCore.Mvc;
using SallesWebMvc.Models;
using System.Collections.Generic;

namespace SallesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> List = new List<Department>();
            List.Add(new Department { Id = 1, Name = "Moveis" });

            return View(List);
        }
    }
}

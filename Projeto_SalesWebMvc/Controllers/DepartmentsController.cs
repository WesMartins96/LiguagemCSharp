using Microsoft.AspNetCore.Mvc;
using Projeto_SalesWebMvc.Models;
using System.Collections.Generic;

namespace Projeto_SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Eletronicos" });
            list.Add(new Department { Id = 2, Name = "Roupas" });
            list.Add(new Department { Id = 3, Name = "Games" });

            return View(list);
        }
    }
}

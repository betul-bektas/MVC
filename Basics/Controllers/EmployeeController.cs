using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    public class EmployeeController:Controller
    {
        public IActionResult Index()
        {
            string message=$"current date time.{DateTime.Now.ToString()}";
            return View("hello",message);
        }

        public ViewResult Index2()
        {
            var names = new String[]
            {
                "isim1",
                "isim2",
                "isim3"
            };
            return View(names);
        }
        public IActionResult Index3()
        {
            var list = new List<Employee>()
            {
                new Employee(){Id=1,FirstName="Betül",LastName="Bektaş",Age=23},
                new Employee(){Id=2,FirstName="Emre",LastName="Şen",Age=25},
                new Employee(){Id=3,FirstName="Zeynep",LastName="Bektaş",Age=16}
            };
            return View("Index3",list);
        }
    }
}
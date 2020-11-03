using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore_MVCOverview.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVCOverview.Controllers
{
    public class CourseController : Controller
    {
        private ICar _car;
        public CourseController(ICar car)
        {
            _car = car;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

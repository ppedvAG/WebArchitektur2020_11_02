using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI_With_Scaffold.Controllers
{
    public class HomeController : Controller //<-Basisklasse: Controller = MVC
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

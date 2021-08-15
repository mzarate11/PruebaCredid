using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;

namespace MVC.Controllers
{
    public class CargarPostController : Controller
    {
        public IActionResult Index()
        {
            


            return View();
        }
        public ActionResult TraerData() 
        {   
                return Content("1");
        }

    }
}

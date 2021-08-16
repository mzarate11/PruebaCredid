using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC.Controllers;
using BLL;

namespace MVC.Controllers
{
    public class LeerPostController : Controller
    {
        public IActionResult Index()
        {
            Logica objLogica = new Logica();
            List<BLL.Users.clsUser> listU = new List<BLL.Users.clsUser>();
            listU = objLogica.DeserializarU(listU);
            var resultU = listU.Select(u => new Tuple<int, string>(u.id,u.username)).ToList();
            ViewData["username"] = resultU;
            return View();

        }

    }
}

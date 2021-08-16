using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;

namespace MVC.Controllers
{
    public class UsuariosController : Controller
    {
        [HttpGet]
        public IActionResult Index(int uid)
        {
            Logica objLogica = new Logica();
            List<BLL.Users.clsUser> listU = new List<BLL.Users.clsUser>();
            listU = objLogica.DeserializarU(listU);
            var result1 = listU.Where(u => u.id == uid).Select(u => new Tuple<int, string, string, string, string, string>(u.id, u.name,u.username,u.email,u.phone,u.website)).ToList();
            ViewData["dUsuarios"] = result1;
            var result2 = listU.Where(u => u.id == uid).Select(u => new Tuple<string, string, string, string, string, string>(u.address.city, u.address.street, u.address.suite, u.address.zipcode, u.address.geo.lat, u.address.geo.lng)).ToList();
            ViewData["adress"] = result2;
            var result3 = listU.Where(u => u.id == uid).Select(u => new Tuple<string, string, string>(u.company.name, u.company.catchPhrase, u.company.bs)).ToList();
            ViewData["company"] = result3;

            
            return View();
        }
    }
}

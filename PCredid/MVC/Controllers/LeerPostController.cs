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
            List<BLL.Posts.clsPost> listP = new List<BLL.Posts.clsPost>();
            List<BLL.Users.clsUser> listU = new List<BLL.Users.clsUser>();
            listP = objLogica.DeserializarP(listP);
            listU = objLogica.DeserializarU(listU);
            var resultU = listU.Select(u => u.username).ToList();
            ViewData["username"] = resultU;
            for (int i = 1; i<10;i++)
            {
                var resultP = listP.Where(id => id.userId == i).Select(id => id.title).ToList();
                ViewData["title"] = resultP;
            };
           
            
            return View();
        }
    }
}

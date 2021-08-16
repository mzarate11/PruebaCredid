using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;

namespace MVC.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index(int uid, string name)
        {
            Logica obL = new Logica();
            List<BLL.Posts.clsPost> listP = new List<BLL.Posts.clsPost>();
            listP = obL.DeserializarP(listP);

            var resultp = listP.Where(p => p.userId == uid).Select(p => new Tuple<int, string>(p.id, p.title)).ToList();
            ViewData["titulo"] = resultp;
            ViewData["username"] = name; 
            return View();
        }
    }
}

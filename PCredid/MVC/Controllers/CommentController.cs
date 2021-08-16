using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using System.Globalization;

namespace MVC.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Index(int pid, string user)
        {
            Logica obj = new Logica();
            List<BLL.Posts.clsPost> listP = new List<BLL.Posts.clsPost>();
            List<BLL.Comments.clsComment> listC = new List<BLL.Comments.clsComment>();
            listP = obj.DeserializarP(listP);
            listC = obj.DeserializarC(listC);

            var resultP = listP.Where(p => p.id == pid).Select(p => new { p.body, p.title }).ToList();
            var resultC = listC.Where(c => c.postId == pid).Select(c => new Tuple<string, string, string>(c.name, c.email, c.body)).ToList();


            ViewData["posteo"] = resultP[0].body;
            ViewData["titulo"] = resultP[0].title;
            ViewData["Comments"] = resultC;
            ViewData["user"] = user;
            return View();
        }
    }
}

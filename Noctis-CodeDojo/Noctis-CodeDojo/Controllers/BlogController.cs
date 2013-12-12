using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Noctis_CodeDojo.Models.Repositories;
using Noctis_CodeDojo.Models;
namespace Noctis_CodeDojo.Controllers
{
    public class BlogController : Controller
    {
        //
        // GET: /Blog/

        public ActionResult Article()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddReply(ArticleReply model)
        {
            ArticleReplyRepository repo = new ArticleReplyRepository();
            repo.Add(model);
            return View("Article");
        }
    }
}

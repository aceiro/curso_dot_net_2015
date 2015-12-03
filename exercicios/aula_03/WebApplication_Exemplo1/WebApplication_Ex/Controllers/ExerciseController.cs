using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication_Ex.Controllers
{
    public class ExerciseController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult ExercisePartial()
        {
            return PartialView();
        }

        public RedirectResult Redirect() 
        {
            return Redirect("/home");
        }
	}
}
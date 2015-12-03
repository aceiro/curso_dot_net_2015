using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication_Exemplo2.Models;

namespace WebApplication_Exemplo2.Controllers
{
    public class SomaController : Controller
    {

        public ActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public ActionResult CalcularValores(SomaViewModel somaViewModel)
        {
            somaViewModel.Resultado = somaViewModel.Num1 + somaViewModel.Num2;

            return View("Index", somaViewModel);
        }
	}
}
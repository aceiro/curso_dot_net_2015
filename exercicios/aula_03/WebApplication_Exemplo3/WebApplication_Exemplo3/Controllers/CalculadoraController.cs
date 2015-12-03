using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication_Exemplo3.Models;

namespace WebApplication_Exemplo3.Controllers
{
    public class CalculadoraController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public ActionResult Adicao() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adicao(CalculadoraViewModel calculadoraViewModel)
        {
            calculadoraViewModel.Resultado = calculadoraViewModel.Numero1 + calculadoraViewModel.Numero2;
            return View(calculadoraViewModel);
        }

        // TODO: CRIAR AS ACOES PARA SUBTRAIR, MULTIPLICAR E DIVIDIR
        // USE OS PARES DE MÉTODOS GET/SET
	}
}
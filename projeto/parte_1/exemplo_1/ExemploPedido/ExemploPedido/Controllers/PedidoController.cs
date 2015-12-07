using ExemploPedido.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ExemploPedido.Controllers
{
    [Authorize]
    public class PedidoController : Controller
    {
        private const string LISTA_PEDIDO_VIEW_MODEL = "LISTA_PEDIDO_VIEW_MODEL";

        public List<PedidoViewModel> ListaPedidoViewModel
        {
            get
            {
                if (Session[LISTA_PEDIDO_VIEW_MODEL] == null)
                {
                    Session[LISTA_PEDIDO_VIEW_MODEL] = new List<PedidoViewModel>();
                    return Session[LISTA_PEDIDO_VIEW_MODEL] as List<PedidoViewModel>;
                }
                else
                    return Session[LISTA_PEDIDO_VIEW_MODEL] as List<PedidoViewModel>;
            }
            set
            {
                Session[LISTA_PEDIDO_VIEW_MODEL] = value;
            }
        }

        public ActionResult Index()
        {
            return View(ListaPedidoViewModel);
        }

        public ActionResult Incluir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Incluir(PedidoViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.Id = ListaPedidoViewModel.Count() > 0 ? ListaPedidoViewModel.Max(p => p.Id) + 1 : 1;
                ListaPedidoViewModel.Add(model);
                return View("Index", ListaPedidoViewModel);
            }

            return View(model);
        }

        public ActionResult Alterar(int id)
        {
            //TODO: Verificar se existe pedido com o Id passado no parametro

            var model = ListaPedidoViewModel.FirstOrDefault(p => p.Id == id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Alterar(PedidoViewModel model)
        {
            if (ModelState.IsValid)
            {
                var pedido = ListaPedidoViewModel.FirstOrDefault(p => p.Id == model.Id);
                ListaPedidoViewModel.Remove(pedido);

                ListaPedidoViewModel.Add(model);
                return View("Index", ListaPedidoViewModel);
            }

            return View(model);
        }

        public ActionResult Excluir(int id)
        {
            //TODO: Verificar se existe pedido com o Id passado no parametro

            var model = ListaPedidoViewModel.FirstOrDefault(p => p.Id == id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Excluir(PedidoViewModel model)
        {   
            var pedido = ListaPedidoViewModel.FirstOrDefault(p => p.Id == model.Id);
            ListaPedidoViewModel.Remove(pedido);

            return View("Index", ListaPedidoViewModel);
        }

        public ActionResult Detalhes(int id)
        {
            //TODO: Verificar se existe pedido com o Id passado no parametro

            var model = ListaPedidoViewModel.FirstOrDefault(p => p.Id == id);
            return View(model);
        }
    }
}
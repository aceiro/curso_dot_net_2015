using ProjetoVendaPedido.DTO;
using ProjetoVendaPedido.Models;
using ProjetoVendaPedido.Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ProjetoVendaPedido.Controllers
{
    [Authorize]
    public class RetrieveController : BaseController
    {
        private IPedidoLogic pedidoLogic;
        public RetrieveController()
        {
            pedidoLogic = PedidoVendaFactory.createPedidoLogic();
        }

        
        public ActionResult Index()
        {
            List<PedidoDto> pedidos = pedidoLogic.RecuperaTodosPedidos();

            List<PedidoViewModel> pedidoViewModel = new List<PedidoViewModel>();
            foreach (var pedidoDto in pedidos)
	        {
                var umPedidoViewModel = new PedidoViewModel(){
                        Id = pedidoDto.Id,
                        Descricao = pedidoDto.Descricao,
                        Data = pedidoDto.Data
                };
		        pedidoViewModel.Add(umPedidoViewModel);
	        }


            return View(pedidoViewModel);
        }

        [HttpGet]
        public ActionResult Create() {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PedidoViewModel pedidoViewModel)
        {
            PedidoDto pedidoDto = new PedidoDto(){
                Data = pedidoViewModel.Data,
                Descricao = pedidoViewModel.Descricao
            };

            pedidoLogic.SalvarPedido(pedidoDto);
            return Redirect("/Retrieve");
        }

        [HttpGet]
        public ActionResult Edit(int Id) {

            PedidoDto pedidoDto = pedidoLogic.RecuperaPedidoPeloId(Id);

            var umPedidoViewModel = new PedidoViewModel()
            {
                Id = pedidoDto.Id,
                Descricao = pedidoDto.Descricao,
                Data = pedidoDto.Data
            };

            return View(umPedidoViewModel);
        }

        [HttpPost]
        public ActionResult Edit(PedidoViewModel pedidoViewModel) {
            PedidoDto pedidoDto = new PedidoDto()
            {
                Id = pedidoViewModel.Id,
                Data = pedidoViewModel.Data,
                Descricao = pedidoViewModel.Descricao

            };

            pedidoLogic.EditarPedido(pedidoDto);
            return Redirect("/Retrieve");

        }

        [HttpGet]
        public ActionResult Details(int Id) { 
            PedidoDto pedidoDto = pedidoLogic.RecuperaPedidoPeloId(Id);
            var umPedidoViewModel = new PedidoViewModel()
            {
                Id = pedidoDto.Id,
                Descricao = pedidoDto.Descricao,
                Data = pedidoDto.Data
            };
            
            return View(umPedidoViewModel);
        }

        [HttpGet]
        public ActionResult Delete(int Id)
        {
            pedidoLogic.RemoverPedidoPeloId(Id);
            return Redirect("/Retrieve");
        }

    }
}
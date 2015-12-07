using ProjetoVendaPedido.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoVendaPedido.Negocios;
using ProjetoVendaPedido.DTO;
using System.Web.Security;

namespace ProjetoVendaPedido.Controllers
{
    public class LoginController : BaseController
    {
        private IUsuarioLogic usuarioLogic;

        public LoginController()
        {
            usuarioLogic = PedidoVendaFactory.createUsuarioLogic();       
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(UsuarioPedidoViewModel loginViewModel)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("Usuario", "Os dados devem ser preenchidos");
                return View();

            }

            var usuario = new UsuarioDto()
            {
                Usuario = loginViewModel.Usuario,
                Senha   = loginViewModel.Senha
            };
            

            bool IsValidUser = usuarioLogic.verificaUsuario(usuario);
            if ( !IsValidUser )
            {
                ModelState.Clear();
                ModelState.AddModelError("Usuario", "Usuário inválido");
                ModelState.AddModelError("Senha", "Senha inválida");
                return View();
            }

            criaCookie(loginViewModel);
            return Redirect("/Retrieve");
        }

        [NonAction]
        private void criaCookie(UsuarioPedidoViewModel model)
        {
            var cookie = FormsAuthentication.GetAuthCookie(model.Usuario, true);
            var ticket = FormsAuthentication.Decrypt(cookie.Value);
            var newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, ticket.IssueDate,
            ticket.Expiration, ticket.IsPersistent, model.Usuario, ticket.CookiePath);
            var encTicket = FormsAuthentication.Encrypt(newTicket);
            cookie.Value = encTicket;

            System.Web.HttpContext.Current.Response.Cookies.Add(cookie);

        }
	}
}
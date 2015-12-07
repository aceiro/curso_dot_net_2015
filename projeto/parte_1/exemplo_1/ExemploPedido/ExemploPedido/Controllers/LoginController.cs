using ExemploPedido.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;

namespace ExemploPedido.Controllers
{
    public class LoginController : Controller
    {
        List<LoginViewModel> listaUsuarios;

        public LoginController()
        {
            listaUsuarios = new List<LoginViewModel>() {
                new LoginViewModel() { Usuario = "admin", Senha = "admin"},
                new LoginViewModel() { Usuario = "usuario", Senha = "usuario"}
            };
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var usuario = listaUsuarios.Where(l =>
                    l.Usuario == model.Usuario && l.Senha == model.Senha
                );

                if (usuario.Count() > 0)
                {
                    CriaCookieAutenticacao(model);
                    return RedirectToAction("Index", "Pedido");
                }
                else
                    ModelState.AddModelError("Senha", "Nome de usuário ou senha inválida!");
            }

            return View(model);
        }

        [NonAction]
        private void CriaCookieAutenticacao(LoginViewModel model)
        {
            var cookie = FormsAuthentication.GetAuthCookie(model.Usuario, false);

            var ticket = FormsAuthentication.Decrypt(cookie.Value);
            var newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name,
                ticket.IssueDate, ticket.Expiration, ticket.IsPersistent, model.Usuario,
                ticket.CookiePath);
            var encTicket = FormsAuthentication.Encrypt(newTicket);

            cookie.Value = encTicket;
            Response.Cookies.Add(cookie);
        }
    }
}
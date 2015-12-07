using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoVendaPedido.Controllers
{
    public class PedidoLogTracking: ActionFilterAttribute
    {
        public PedidoLogTracking()
        {

        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            System.Diagnostics.Debug.WriteLine("***** Entrando no log do sistema de pedidos ***** ");
        }
       
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {

            System.Diagnostics.Debug.WriteLine("**** Saindo no log do sistema de pedidos *****");
        }
    }
}
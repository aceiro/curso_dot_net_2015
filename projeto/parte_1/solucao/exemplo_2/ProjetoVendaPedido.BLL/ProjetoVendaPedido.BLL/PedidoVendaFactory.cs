using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVendaPedido.Negocios
{
    public class PedidoVendaFactory
    {
        public static IUsuarioLogic createUsuarioLogic() {
            return new UsuarioLogic();
        }

        public static IPedidoLogic createPedidoLogic() {
            return new PedidoLogic();
        }

    }
}

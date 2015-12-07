using ProjetoVendaPedido.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVendaPedido.Negocios
{
    public interface IPedidoLogic
    {
        List<PedidoDto> RecuperaTodosPedidos();

        void SalvarPedido(PedidoDto pedidoDto);

        PedidoDto RecuperaPedidoPeloId(int Id);

        void EditarPedido(PedidoDto pedidoDto);

        void RemoverPedidoPeloId(int Id);
    }
}

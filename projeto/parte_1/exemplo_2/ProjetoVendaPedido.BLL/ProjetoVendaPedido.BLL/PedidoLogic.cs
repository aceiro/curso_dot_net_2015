using ProjetoVendaPedido.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVendaPedido.Negocios
{

    public class PedidoLogic:IPedidoLogic
    {

        private List<PedidoDto> RecuperaPedidosDaSessao() {
            //
            // mock
            // para habilitar o uso ao HttpContext é 
            // preciso habilitar a session com o System.Web em references
            var session = System.Web.HttpContext.Current.Session;
            if ( session["pedidos"] != null ) {
                return session["pedidos"] as List<PedidoDto>;
            }

            // 
            // mock manualmente dos pedidos da lista
            // 
            List<PedidoDto> pedidos = new List<PedidoDto>();
            PedidoDto pedidoDto1 = new PedidoDto()
            {
                Id = 1,
                Data = DateTime.Now,
                Descricao = "Exemplo de pedido"
            };
            PedidoDto pedidoDto2 = new PedidoDto()
            {
                Id = 2,
                Data = DateTime.Now,
                Descricao = "Exemplo de pedido"
            };
            PedidoDto pedidoDto3 = new PedidoDto()
            {
                Id = 3,
                Data = DateTime.Now,
                Descricao = "Exemplo de pedido"
            };
            pedidos.Add(pedidoDto1);
            pedidos.Add(pedidoDto2);
            pedidos.Add(pedidoDto3);

            session["pedidos"] = pedidos;
            return session["pedidos"] as List<PedidoDto>;
        
        }


        public List<PedidoDto> RecuperaTodosPedidos()
        {

            List<PedidoDto> pedidos = RecuperaPedidosDaSessao();
            return pedidos;
        }


        public void SalvarPedido(PedidoDto pedidoDto)
        {
            List<PedidoDto> pedidosDaSessao = RecuperaPedidosDaSessao();
            PedidoDto ultimoPedido          = pedidosDaSessao.ElementAtOrDefault(pedidosDaSessao.Count()-1);
            if (ultimoPedido != null)
            {
                pedidoDto.Id = ultimoPedido.Id + 1;
            }
            else {
                // reinicializa o contador
                // usado quando for removido todos os itens
                pedidoDto.Id = 1;
            }
            

            pedidosDaSessao.Add(pedidoDto);

        }


        public PedidoDto RecuperaPedidoPeloId(int Id)
        {
            List<PedidoDto> pedidos = RecuperaPedidosDaSessao();
            PedidoDto pedido = pedidos.Where(p => p.Id == Id).ToList().FirstOrDefault();
            return pedido;
        }

        
        public void EditarPedido(PedidoDto pedidoDto)
        {
            int Id = pedidoDto.Id;
            PedidoDto pedidoDtoExistente = RecuperaPedidoPeloId(Id);
            List<PedidoDto>      pedidos = RecuperaPedidosDaSessao();


            int beforeUpdateCount = pedidos.Count();
            if (!pedidos.Remove(pedidoDtoExistente)) {
                throw new InvalidOperationException("Não foi possível remover o pedido pelo id :"+ Id);
            }

            int afterUpdateCount = pedidos.Count();
            if (afterUpdateCount >= beforeUpdateCount)
            {
                throw new InvalidOperationException("Não foi possível alterar o tamanho da lista de pedidos pelo id :" + Id);
            }


            SalvarPedido(pedidoDto);

        }




        public void RemoverPedidoPeloId(int Id)
        {

            PedidoDto pedidoDtoExistente = RecuperaPedidoPeloId(Id);
            List<PedidoDto> pedidos = RecuperaPedidosDaSessao();


            int beforeUpdateCount = pedidos.Count();
            if (!pedidos.Remove(pedidoDtoExistente))
            {
                throw new InvalidOperationException("Não foi possível remover o pedido pelo id :" + Id);
            }

            int afterUpdateCount = pedidos.Count();
            if (afterUpdateCount >= beforeUpdateCount)
            {
                throw new InvalidOperationException("Não foi possível alterar o tamanho da lista de pedidos pelo id :" + Id);
            }
            
        }
    }
}

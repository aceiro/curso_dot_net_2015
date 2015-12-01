using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            var pedido = new Pedido();

            pedido.Data = DateTime.Now;
            pedido.FluxoId = Fluxo.PreVenda;
            pedido.DataMudancaFluxo = null;
            pedido.ImprimirPedido();
            Console.WriteLine(pedido.FluxoId);

            pedido.Data = DateTime.Now;
            pedido.FluxoId = Fluxo.AguardandoPagamento;
            pedido.DataMudancaFluxo = null;
            pedido.ImprimirPedido();
            Console.WriteLine(pedido.FluxoId);

            pedido.Data = DateTime.Now;
            pedido.FluxoId = Fluxo.Aprovado;
            pedido.DataMudancaFluxo = null;
            pedido.ImprimirPedido();
            Console.WriteLine(pedido.FluxoId);


            pedido.Data = DateTime.Now;
            pedido.FluxoId = Fluxo.Entregue;
            pedido.DataMudancaFluxo = null;
            pedido.ImprimirPedido();
            Console.WriteLine(pedido.FluxoId);


            Console.ReadLine();

        }
    }
}

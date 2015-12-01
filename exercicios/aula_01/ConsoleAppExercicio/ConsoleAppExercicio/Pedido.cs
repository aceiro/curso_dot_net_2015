using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExercicio
{
    class Pedido: PedidoAbstrato
    {
        public int Id { get; set; }
        public Fluxo FluxoId { get; set; }

        public DateTime Data { get; set; }

        public DateTime? DataMudancaFluxo { get; set; }

        public string NomeCliente { get; set; }

        public override void ImprimirPedido()
        {

            var fmt = String.Format("{0}, {1}, {2}", Id, FluxoId, Data);
            Console.WriteLine( fmt );
        }


    }
}

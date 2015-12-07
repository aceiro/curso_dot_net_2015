using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoVendaPedido.Models
{
    public class PedidoViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }

        public Status TipoStatus { get; set; }
    }
}
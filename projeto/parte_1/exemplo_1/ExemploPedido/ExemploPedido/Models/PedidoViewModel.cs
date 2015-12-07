using ExemploPedido.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace ExemploPedido.Models
{
    public class PedidoViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Data { get; set; }

        [Required]
        public FluxoPedido FluxoPedido { get; set; }
    }
}

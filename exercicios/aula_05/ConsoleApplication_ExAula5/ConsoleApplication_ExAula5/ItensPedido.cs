using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_ExAula5
{
    [Table("itenspedidos")]
    public class ItensPedido
    {

        public ItensPedido()
        {

        }
        [Key]
        public int Id { get; set; }

        public int IdPedido { get; set; }

        public int IdProduto { get; set; }

        public int Quantidade { get; set; }

        public double Valor { get; set; }

        [ForeignKey("IdPedido")]
        public virtual Pedido Pedido { get; set;}

        [ForeignKey("IdProduto")]
        public virtual Produto Produto { get; set; }



    }
}

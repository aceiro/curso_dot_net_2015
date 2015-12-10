using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_ExAula5
{
    [Table("pedidos")]
    public class Pedido
    {

        public Pedido()
        {

        }


        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Descricao { get; set; }

        [Required]
        public DateTime Data { get; set; }

        public virtual ICollection<ItensPedido> ItensPedido {get;set;}
    }
}

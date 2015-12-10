using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApplicationEx_Aula4.Model
{
    [Table("tbl_pedido")]
    public class Pedido
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(255)]
        public String Descricao { get; set; }
        
        [Required]
        public DateTime Data { get; set; }
    }
}

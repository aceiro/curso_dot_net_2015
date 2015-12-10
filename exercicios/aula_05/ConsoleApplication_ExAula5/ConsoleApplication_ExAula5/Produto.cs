using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_ExAula5
{
    [Table("produtos")]
    public class Produto
    {
        public Produto()
        {
                
        }

        [Key]
        public int Id { get; set; }

        [MaxLength(255)]
        [Required]
        public string Descricao { get; set; }

        [Required]
        public int Quantidade { get; set; }


        public override string ToString()
        {
            return String.Format("Id = {0} \n Descricao {1} \n Quantidade = {2}", Id, Descricao, Quantidade);
        }      
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication_Exemplo2.Models
{
    public class SomaViewModel
    {
        [Required]
        public int Num1 { get; set; }
        [Required]
        public int Num2 { get; set; }
        public int Resultado { get; set; }

        public SomaViewModel ()
	    {

	    }
    }
}
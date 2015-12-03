using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication_Exemplo3.Models
{
    public class CalculadoraViewModel
    {
        [Required(ErrorMessage="O número é requerido")]
        [Display(Name="Digite o número 1")]
        [DataType(DataType.Currency)]
        public double Numero1 { get; set; }

        [Required(ErrorMessage = "O número é requerido")]
        [Display(Name = "Digite o número 2")]
        [DataType(DataType.Currency)]
        public double Numero2 { get; set; }

        public double Resultado { get; set; }
        public CalculadoraViewModel()
        {
                
        }

    }
}
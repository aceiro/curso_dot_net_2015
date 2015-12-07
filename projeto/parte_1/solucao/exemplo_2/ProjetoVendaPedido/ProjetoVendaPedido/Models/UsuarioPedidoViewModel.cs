using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoVendaPedido.Models
{
    public class UsuarioPedidoViewModel
    {

        [Required]
        [Display(Name="Login")]
        public string Usuario { get; set; }

        [Required]
        [Display(Name="Senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        public UsuarioPedidoViewModel()
        {

        }

        public UsuarioPedidoViewModel(string Usuario, string Senha)
        {
            this.Usuario = Usuario;
            this.Senha   = Senha;
        }
    }
}
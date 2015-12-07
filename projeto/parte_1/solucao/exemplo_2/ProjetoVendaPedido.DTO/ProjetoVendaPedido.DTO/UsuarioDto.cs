using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVendaPedido.DTO
{
    public class UsuarioDto
    {

        public UsuarioDto()
        {

        }
        public UsuarioDto(string Usuario, string Senha)
        {
            this.Usuario = Usuario;
            this.Senha = Senha;
        }
        public string Nome { get; set; }
        public string Usuario { get; set;  }

        public string Senha { get; set; }
    }
}

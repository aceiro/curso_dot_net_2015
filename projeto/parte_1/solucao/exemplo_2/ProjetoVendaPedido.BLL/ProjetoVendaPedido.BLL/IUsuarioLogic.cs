using ProjetoVendaPedido.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoVendaPedido.Negocios
{
    public interface IUsuarioLogic
    {

        bool verificaUsuario(UsuarioDto usuarioDto);
    }
}

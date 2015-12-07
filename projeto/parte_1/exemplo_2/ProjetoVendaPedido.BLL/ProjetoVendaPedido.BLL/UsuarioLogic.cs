using ProjetoVendaPedido.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVendaPedido.Negocios
{

    public class UsuarioLogic: IUsuarioLogic
    {
        public static List<UsuarioDto> usuariosOnTheFly;

        public UsuarioLogic()
        {
            usuariosOnTheFly = new List<UsuarioDto>(){
                new UsuarioDto("admin","1234"),
                new UsuarioDto("erik","4321"),
                new UsuarioDto("eva","67374kjdo"),
                new UsuarioDto("pat","6789moi0")
            };
        }



        public bool verificaUsuario(UsuarioDto usuarioDto)
        {
            if (usuariosOnTheFly.Count() == 0) {
                return false;
            }

            if (usuarioDto.Usuario == null || usuarioDto.Senha == null)
            {
                return false;
            }

            UsuarioDto login = usuariosOnTheFly.Where(u => (u.Usuario.Equals(usuarioDto.Usuario) &&
                                                            u.Senha.Equals(usuarioDto.Senha)))
                                                .FirstOrDefault();
            if (login == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

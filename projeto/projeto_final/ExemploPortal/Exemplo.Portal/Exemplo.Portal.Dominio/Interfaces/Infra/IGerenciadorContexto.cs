using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo.Portal.Dominio.Interfaces.Infra
{
    public interface IGerenciadorContexto
    {
        IContexto Recuperar{ get; }

        void Finalizar();
    }
}

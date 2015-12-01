using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public interface PessoaAbstrata
    {
        int Id { get; set; }
        string Nome { get; set; }

        void ImprimirPessoa();
    }
}

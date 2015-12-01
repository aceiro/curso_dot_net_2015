using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class PessoaJuridica: PessoaAbstrata
    {
        public string cnpj { get; set; }

        public void ImprimirPessoa()
        { 
            Console.WriteLine("Exibindo pessoa jurídica");
        }

        public int Id
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Nome
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}

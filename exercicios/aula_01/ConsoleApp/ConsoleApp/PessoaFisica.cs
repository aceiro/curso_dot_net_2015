using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
   public class PessoaFisica: PessoaAbstrata
    {
       public string cpf { get; set; }

       public void ImprimirPessoa()
       {
           Console.WriteLine("Exibindo pessoa física");
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

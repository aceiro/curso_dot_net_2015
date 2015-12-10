using ConsoleApplicationEx_Aula4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationEx_Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            ExemploAula4Contexto c = new ExemploAula4Contexto();
            Pedido p = new Pedido();
            
            p.Descricao = "Teste";
            p.Data = DateTime.Now;
            c.Pedido.Add(p);


            Console.WriteLine(c.Pedido.Where( x=> x.Descricao!=null).ToList() );
        }
    }
}

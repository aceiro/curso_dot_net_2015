using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_ExAula5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using(var contexto = new AppContexto())
            {
                



                //1. criacao de um produto
                //
                var produtos  = contexto.Produtos;
                var umProduto = new Produto();
                umProduto.Descricao  = "Cebola roxa";
                umProduto.Quantidade = 2;

                //2. adiciona um produto
                produtos.Add(umProduto);


                //3. salva o estado
                contexto.SaveChanges();

                //4. alguns exemplos
                Console.WriteLine("===========================");
                produtos
                    .SqlQuery("select * from produtos")
                    .ToList()
                    .ForEach(p => Console.WriteLine(p));

                Console.WriteLine("===========================");
                produtos
                   .ToList()
                   .ForEach(p => Console.WriteLine(p));


                Console.ReadLine();
                Console.WriteLine("===========================");
                produtos.RemoveRange(produtos);
                contexto.SaveChanges();


            }



        }
    }
}

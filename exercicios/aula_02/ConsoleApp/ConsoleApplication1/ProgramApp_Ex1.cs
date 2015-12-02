using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApplication1
{


    class ProgramApp_Ex1
    {
        private Produto umProduto;
        private Pedido umPedido;

        public void Consumer()
        {
            foreach (int i in Integers())
            {
                Console.WriteLine(i.ToString());
            }
        }

        public IEnumerable<int> Integers()
        {
            yield return 1;
            yield return 2;
            yield return 4;
            yield return 8;
            yield return 16;
            yield return 16777216;
        }


        public void criarProduto() {

            // 2. Criacao de um Pedido com uma Lista de Produtos
            umProduto      = new Produto();
            umProduto.Nome = "Teste";
            umPedido = new Pedido();
        
        }


        public void criarListaProdutos() {
            var rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                Produto p = (Produto)umProduto.Clone();
                p.Id = rnd.Next(10);
                p.Serial = Guid.NewGuid();
                umPedido.produtos.Add(p);
            }
        
        }

        public void listarTodosProdutos() {
            foreach (var item in umPedido.produtos)
            {
                Console.WriteLine(item);
            }
        
        }

        private void buscarProdutosPeloFiltro()
        {
            List<Produto> produtoFiltro = umPedido.produtos.Where(c => c.Id == 3).ToList();
            foreach (var item in produtoFiltro)
            {
                Console.WriteLine(item);
            }
        }

        private void buscarProdutosPeloFiltroComFirst()
        {
            Produto produtoFiltro = umPedido.produtos.First(c => c.Nome.Equals("Teste"));
            Console.WriteLine(produtoFiltro);
            
        }

        private Produto buscarProdutoPorCond(Func<Produto,bool> func) {

            return umPedido.produtos.First(func);
        }

        private void salvar()
        {


            umPedido.produtos.Add(new Produto());
            umPedido.produtos.Add(new Produto());
            umPedido.produtos.Add(new Produto());
            umPedido.produtos.Add(new Produto());
            umPedido.produtos.Add(new Produto());
            try
            {

                if (umPedido.produtos.Count >= 10)
                {
                    throw new MinhaException("Exemplo de erro...");
                }
            }
            catch (MinhaException e) {
                Console.WriteLine(e.Message);
            
            }




        }



        public static void Main(string[] args)
        {

            // 1. Primeiro exemplo apresentado 
            // uso do operador yield do C#
            // não tem equivalente em Java
            // new ProgramApp_Ex1().Consumer();

            ProgramApp_Ex1 app = new ProgramApp_Ex1();
            Console.WriteLine("---------------- 1. Criacao da lista ---------------");
            app.criarProduto();
            app.criarListaProdutos();
            app.listarTodosProdutos();

            Console.WriteLine("---------------- 2. Utilizando lambda ---------------");
            app.buscarProdutosPeloFiltro();

            Console.WriteLine("---------------- 3. Salva ---------------");
            app.salvar();

            Console.WriteLine("---------------- 4. Busca com filtro first ---------------");
            app.buscarProdutosPeloFiltroComFirst();

            Console.WriteLine("---------------- 5. Busca com filtro generico ---------------");
            Produto p = app.buscarProdutoPorCond(p=>p.Id == -1);
            if(p!=null)
                Console.WriteLine(p);

            Console.ReadLine();
        }

      
        
    }
}

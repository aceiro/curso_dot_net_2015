using System;


namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Id   = 1;
            pessoa.Nome = "Erik";

            Console.WriteLine(pessoa);

            Console.WriteLine(pessoa.MeuNome);

            PessoaAbstrata p1 = new PessoaFisica();


            PessoaAbstrata p2 = new PessoaJuridica();

            p1.ImprimirPessoa();

            Nullable<int> numero = null;

            int? n2 = null;

            Console.WriteLine(numero);
            Console.WriteLine(numero.HasValue);

            numero = numero ?? 100;
            Console.WriteLine(numero);

            Console.ReadLine();
           
        }
    }
}

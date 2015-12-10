using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConsoleApplication_ExAula5
{
    public class AppContexto : DbContext
    {

        public AppContexto(): base("MeuExemploConexao")
        {

        }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ItensPedido> ItensPedidos { get; set; }
    }
}

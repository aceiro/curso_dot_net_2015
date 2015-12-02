using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Pedido
    {
        public List<Produto> produtos { get; set; }

        public Pedido()
        {
            produtos = new List<Produto>();
        }
       

    }
}

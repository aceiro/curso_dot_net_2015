using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Produto: ICloneable
    {
        public Guid Serial { get; set; }

        public int Id { get; set; }
        public string Nome { get; set; }



        public Produto()
        {
            Serial = Guid.NewGuid();
            Id = -1;
            Nome = "NONE";
        }

        public Produto(int Id, string Nome)
        {
            this.Id = Id;
            this.Nome = Nome;
        }



        public object Clone()
        {
            return new Produto(Id,Nome);
        }

        public override string ToString()
        {
            return String.Format("{0} -- {1}  -- {2}", Id, Nome, Serial);
        }
    }
}

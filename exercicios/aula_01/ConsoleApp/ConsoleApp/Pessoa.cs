using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Pessoa
    {
        /* 
         private int Id;
            private string Nome;

            public void setId(int Id) {
            this.Id = Id;
            }

            public int getId() {
                return Id;
            }
         
         */

        // usando o facilitador com prop + tab tab
        public int Id { get; set; }
        public string Nome { get; set; }

        public string MeuNome {
            get {
                return string.Format("id: {0} Nome: {0}", Id, Nome);
            }
        
        }

        public Pessoa()
        {
                
        }



    }
}

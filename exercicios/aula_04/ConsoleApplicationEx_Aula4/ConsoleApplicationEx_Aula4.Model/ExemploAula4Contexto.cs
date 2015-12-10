using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationEx_Aula4.Model
{
    //1. comandos usados
    //   Install-Package EntityFramework 
    
    //2. habilita o migrations
    //   Install-Package EntityFramework

    //3. adiciona o migrations
    //   add-migration InicioProjeto

    //4. update-database -verbose
    //
    public class ExemploAula4Contexto: DbContext
    {
        public ExemploAula4Contexto():base("ExemploAula4Entity")
        {

        }
        public DbSet<Pedido> Pedido { get; set; }


    }
}

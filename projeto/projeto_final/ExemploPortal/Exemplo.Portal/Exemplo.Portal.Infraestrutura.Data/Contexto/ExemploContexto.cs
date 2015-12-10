using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Exemplo.Portal.Dominio.Entidades;
using Exemplo.Portal.Infraestrutura.Data.Configuracao.Entidade;
using Exemplo.Portal.Dominio.Interfaces.Infra;

namespace Exemplo.Portal.Infraestrutura.Data.Contexto
{
    public class ExemploContexto : DbContext, IContexto
    {
        public ExemploContexto()
            : base("ExemploPortal")
        {   
             
        }

        public DbSet<Categoria> Categoria { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => {
                    p.HasColumnType("varchar");
                    p.HasMaxLength(100);
                });

            modelBuilder.Configurations.Add(CategoriaConfiguracao.Create());
        }

        public static ExemploContexto Create() 
        {
            return new ExemploContexto();
        }
    }
}

using Exemplo.Portal.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Exemplo.Portal.Infraestrutura.Data.Configuracao.Entidade
{
    public class CategoriaConfiguracao : EntityTypeConfiguration<Categoria>
    {
        public CategoriaConfiguracao()
        {
            HasKey(k => k.Id);

            Property(p => p.Nome)
                .HasColumnName("Nome")
                .IsRequired();

            Property(p => p.Versao)
                .HasColumnName("Versao")
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken(false);
        }

        public static CategoriaConfiguracao Create() 
        {
            return new CategoriaConfiguracao();
        }
    }
}

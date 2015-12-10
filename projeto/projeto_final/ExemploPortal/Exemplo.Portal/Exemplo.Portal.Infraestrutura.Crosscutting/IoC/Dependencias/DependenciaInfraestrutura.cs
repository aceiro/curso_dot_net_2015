using Exemplo.Portal.Dominio.Interfaces.Infra;
using Exemplo.Portal.Infraestrutura.Data.Configuracao;
using Microsoft.Practices.Unity;

namespace Exemplo.Portal.Infraestrutura.Crosscutting.IoC.Dependencias
{
    public class DependenciaInfraestrutura
    {
        public static void Registrar(IUnityContainer container)
        {
            container.RegisterType<IUnidadeTrabalho, UnidadeTrabalho>();
            container.RegisterType<IGerenciadorContexto, GerenciadorContexto>();
        }
    }
}

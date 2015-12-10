using Exemplo.Portal.Dominio.Interfaces.Servicos;
using Exemplo.Portal.Dominio.Servicos;
using Microsoft.Practices.Unity;

namespace Exemplo.Portal.Infraestrutura.Crosscutting.IoC.Dependencias
{
    public class DependenciaServico
    {
        public static void Registrar(IUnityContainer container)
        {
            container.RegisterType<ICategoriaServico, CategoriaServico>();
        }
    }
}

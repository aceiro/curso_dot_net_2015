using Microsoft.Practices.Unity;
using Exemplo.Portal.Infraestrutura.Crosscutting.IoC.Dependencias;

namespace Exemplo.Portal.Infraestrutura.Crosscutting.IoC
{
    public class RegisterConfig
    {
        public static void Register(IUnityContainer container)
        {
            DependenciaInfraestrutura.Registrar(container);
            DependenciaAplicacao.Registrar(container);
            DependenciaRepositorio.Registrar(container);
            DependenciaServico.Registrar(container);
        }
    }
}

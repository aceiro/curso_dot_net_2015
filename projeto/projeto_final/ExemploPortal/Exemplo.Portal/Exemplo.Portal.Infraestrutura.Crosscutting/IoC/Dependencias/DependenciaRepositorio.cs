using Exemplo.Portal.Dominio.Interfaces.Repositorios;
using Exemplo.Portal.Infraestrutura.Data.Repositorios;
using Microsoft.Practices.Unity;

namespace Exemplo.Portal.Infraestrutura.Crosscutting.IoC.Dependencias
{
    public class DependenciaRepositorio
    {
        public static void Registrar(IUnityContainer container)
        {
            container.RegisterType<ICategoriaRepositorio, CategoriaRepositorio>();
        }
    }
}

using Exemplo.Portal.Dominio.Interfaces.Servicos;
using Exemplo.Portal.Dominio.Interfaces.Repositorios;
using Exemplo.Portal.Dominio.Entidades;

namespace Exemplo.Portal.Dominio.Servicos
{
    public class CategoriaServico : BaseServico<Categoria>, ICategoriaServico
    {
        private readonly ICategoriaRepositorio _categoriaRepositorio;

        public CategoriaServico(ICategoriaRepositorio categoriaRepositorio)
            : base(categoriaRepositorio)
        {
            _categoriaRepositorio = categoriaRepositorio;
        }
    }
}

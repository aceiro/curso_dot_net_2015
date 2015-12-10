using System;
using System.Linq;
using System.Linq.Expressions;
using Exemplo.Portal.Dominio.Interfaces.Servicos;
using Exemplo.Portal.Dominio.Interfaces.Repositorios;

namespace Exemplo.Portal.Dominio.Servicos
{
    public class BaseServico<TEntidade> : IBaseServico<TEntidade> where TEntidade : class 
    {
        private readonly IBaseRepositorio<TEntidade> _baseRepositorio;

        public BaseServico(IBaseRepositorio<TEntidade> baseRepositorio)
        {
            _baseRepositorio = baseRepositorio;
        }

        public IQueryable<TEntidade> Recuperar(Expression<Func<TEntidade, bool>> expression)
        {
            return _baseRepositorio.Recuperar(expression);
        }

        public IQueryable<TEntidade> Recuperar()
        {
            return _baseRepositorio.Recuperar();
        }

        public TEntidade Recuperar(int id)
        {
            return _baseRepositorio.Recuperar(id);
        }

        public void Inserir(TEntidade entidade)
        {
            _baseRepositorio.Inserir(entidade);
        }

        public void Alterar(TEntidade entidade)
        {
            _baseRepositorio.Alterar(entidade);
        }

        public void Remover(int id)
        {
            _baseRepositorio.Remover(id);
        }

        public void Remover(TEntidade entidade)
        {
            _baseRepositorio.Remover(entidade);
        }

        public void Dispose()
        {
            _baseRepositorio.Dispose();
        }
    }
}

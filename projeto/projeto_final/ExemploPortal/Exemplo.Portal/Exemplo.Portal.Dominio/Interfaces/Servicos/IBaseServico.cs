using System;
using System.Linq;
using System.Linq.Expressions;

namespace Exemplo.Portal.Dominio.Interfaces.Servicos
{
    public interface IBaseServico<TEntidade> : IDisposable where TEntidade : class 
    {
        IQueryable<TEntidade> Recuperar(Expression<Func<TEntidade, bool>> expression);

        IQueryable<TEntidade> Recuperar();

        TEntidade Recuperar(int id);

        void Inserir(TEntidade entidade);

        void Alterar(TEntidade entidade);

        void Remover(int id);

        void Remover(TEntidade entidade);
    }
}

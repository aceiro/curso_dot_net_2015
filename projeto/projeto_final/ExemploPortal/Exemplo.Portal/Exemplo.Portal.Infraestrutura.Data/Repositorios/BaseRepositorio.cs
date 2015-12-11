using System;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;
using Microsoft.Practices.ServiceLocation;
using Exemplo.Portal.Dominio.Interfaces.Repositorios;
using Exemplo.Portal.Dominio.Entidades.Interfaces;
using Exemplo.Portal.Dominio.Interfaces.Infra;

namespace Exemplo.Portal.Infraestrutura.Data.Repositorios
{
    public class BaseRepositorio<TEntidade> : IBaseRepositorio<TEntidade>, IDisposable where TEntidade : class, IIdentificador
    {
        protected DbContext contexto;
        protected DbSet<TEntidade> dbSet;

        public BaseRepositorio()
        {
            var gerenciador = ServiceLocator.Current.GetInstance<IGerenciadorContexto>();
            contexto = gerenciador.Recuperar as DbContext;
            dbSet = contexto.Set<TEntidade>();
        }

        public IQueryable<TEntidade> Recuperar(Expression<Func<TEntidade, bool>> expression)
        {
            return dbSet.Include(expression);
        }

        public IQueryable<TEntidade> Recuperar()
        {
            return dbSet;
        }

        public TEntidade Recuperar(int id)
        {
            return dbSet.Find(id);
        }

        public void Inserir(TEntidade entidade)
        {
            dbSet.Add(entidade);
        }

        public void Alterar(TEntidade entidade)
        {   
            contexto.Entry(entidade).State = EntityState.Modified;
        }

        public void Remover(int id)
        {
            dbSet.Remove(this.Recuperar(id));
        }

        public void Remover(TEntidade entidade)
        {
            contexto.Entry(entidade).State = EntityState.Deleted;
        }

        public void Dispose()
        {
            if (contexto != null)
            {
                contexto.Dispose();
            }
        }
    }
}

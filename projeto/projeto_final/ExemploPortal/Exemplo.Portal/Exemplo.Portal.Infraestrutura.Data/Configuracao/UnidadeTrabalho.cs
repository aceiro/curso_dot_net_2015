using System;
using System.Data.Entity;
using Exemplo.Portal.Dominio.Interfaces.Infra;
using Microsoft.Practices.ServiceLocation;

namespace Exemplo.Portal.Infraestrutura.Data.Configuracao
{
    public class UnidadeTrabalho : IUnidadeTrabalho
    {
        private DbContext contexto;

        public void Iniciar()
        {
            var gerenciador = ServiceLocator.Current.GetInstance<IGerenciadorContexto>();
            contexto = gerenciador.Recuperar as DbContext;
        }

        public void Salvar()
        {
            contexto.SaveChanges();
        }
    }
}

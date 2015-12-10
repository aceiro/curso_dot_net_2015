using System.Web;
using Exemplo.Portal.Dominio.Interfaces.Infra;
using Exemplo.Portal.Infraestrutura.Data.Contexto;

namespace Exemplo.Portal.Infraestrutura.Data.Configuracao
{
    public class GerenciadorContexto : IGerenciadorContexto
    {
        public const string CONTEXTO_HTTP = "CONTEXTO_HTTP";

        public IContexto Recuperar
        {
            get
            {
                if (HttpContext.Current.Items[CONTEXTO_HTTP] == null)
                {
                    HttpContext.Current.Items[CONTEXTO_HTTP] = ExemploContexto.Create();
                }

                return HttpContext.Current.Items[CONTEXTO_HTTP] as ExemploContexto;
            }
        }

        public void Finalizar()
        {
            if (HttpContext.Current.Items[CONTEXTO_HTTP] != null)
            {
                (HttpContext.Current.Items[CONTEXTO_HTTP] as ExemploContexto).Dispose();
            }
        }
    }
}

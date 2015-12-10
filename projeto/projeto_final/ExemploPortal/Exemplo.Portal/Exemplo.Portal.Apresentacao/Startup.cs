using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Exemplo.Portal.Apresentacao.Startup))]
namespace Exemplo.Portal.Apresentacao
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

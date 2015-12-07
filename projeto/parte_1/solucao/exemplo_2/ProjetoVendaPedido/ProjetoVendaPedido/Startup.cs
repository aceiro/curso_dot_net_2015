using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetoVendaPedido.Startup))]
namespace ProjetoVendaPedido
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

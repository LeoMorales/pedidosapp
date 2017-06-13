using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PedidosApp.Startup))]
namespace PedidosApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

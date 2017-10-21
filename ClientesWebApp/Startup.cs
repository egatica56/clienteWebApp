using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClientesWebApp.Startup))]
namespace ClientesWebApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Clientes2.Startup))]
namespace Clientes2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

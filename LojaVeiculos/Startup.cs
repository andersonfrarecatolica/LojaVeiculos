using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LojaVeiculos.Startup))]
namespace LojaVeiculos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

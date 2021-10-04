using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bolsa_de_Empleos.Startup))]
namespace Bolsa_de_Empleos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

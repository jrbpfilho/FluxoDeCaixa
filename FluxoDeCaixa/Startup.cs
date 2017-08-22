using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FluxoDeCaixa.Startup))]
namespace FluxoDeCaixa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

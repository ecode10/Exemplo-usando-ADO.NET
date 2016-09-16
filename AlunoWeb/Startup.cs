using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AlunoWeb.Startup))]
namespace AlunoWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

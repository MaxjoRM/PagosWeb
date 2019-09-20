using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PagosWeb.Startup))]
namespace PagosWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

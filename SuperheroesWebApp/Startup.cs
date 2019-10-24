using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SuperheroesWebApp.Startup))]
namespace SuperheroesWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

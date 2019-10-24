using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CesiumDemo.Startup))]
namespace CesiumDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(portaljuridicokike.Startup))]
namespace portaljuridicokike
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ICE.Startup))]
namespace ICE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IPSSER_PORTAL.Startup))]
namespace IPSSER_PORTAL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

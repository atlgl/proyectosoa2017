using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebNorthWindV1.Startup))]
namespace WebNorthWindV1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

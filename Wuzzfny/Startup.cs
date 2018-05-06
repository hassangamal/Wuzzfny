using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Wuzzfny.Startup))]
namespace Wuzzfny
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

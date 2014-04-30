using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Testble.Startup))]
namespace Testble
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

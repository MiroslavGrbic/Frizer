using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Frizer.Startup))]
namespace Frizer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

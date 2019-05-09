using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidley2015.Startup))]
namespace Vidley2015
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

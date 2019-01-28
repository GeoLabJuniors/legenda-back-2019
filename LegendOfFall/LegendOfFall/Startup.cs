using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LegendOfFall.Startup))]
namespace LegendOfFall
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

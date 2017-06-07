using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TechDay.Proto.Website.Startup))]
namespace TechDay.Proto.Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

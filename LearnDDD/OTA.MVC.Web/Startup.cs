using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OTA.MVC.Web.Startup))]
namespace OTA.MVC.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

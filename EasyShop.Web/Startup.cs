using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EasyShop.Web.Startup))]
namespace EasyShop.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

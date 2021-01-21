using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KN2021_SHARING.MVC.Startup))]
namespace KN2021_SHARING.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

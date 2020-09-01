using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApiHelpPage.Startup))]
namespace WebApiHelpPage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

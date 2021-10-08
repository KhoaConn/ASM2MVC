using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASM2MVC.Startup))]
namespace ASM2MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

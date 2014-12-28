using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_VIP_Trianing.Startup))]
namespace MVC_VIP_Trianing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

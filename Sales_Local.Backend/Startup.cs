using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sales_Local.Backend.Startup))]
namespace Sales_Local.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

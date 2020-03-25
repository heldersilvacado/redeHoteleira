using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootStrapHotelMVCMySql.Startup))]
namespace BootStrapHotelMVCMySql
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

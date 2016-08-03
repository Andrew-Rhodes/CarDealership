using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarDealershipProject.Startup))]
namespace CarDealershipProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

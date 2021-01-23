using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2021_it_mvc_auth.Startup))]
namespace _2021_it_mvc_auth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

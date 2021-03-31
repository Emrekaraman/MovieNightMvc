using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieNightMvc.Startup))]
namespace MovieNightMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

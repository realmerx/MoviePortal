using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCmovie.Startup))]
namespace MVCmovie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

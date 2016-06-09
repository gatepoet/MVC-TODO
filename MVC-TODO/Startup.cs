using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_TODO.Startup))]
namespace MVC_TODO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

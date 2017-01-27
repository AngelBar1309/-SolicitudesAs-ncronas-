using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ejemplo.Startup))]
namespace ejemplo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

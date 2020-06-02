using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Auditoriska5.Startup))]
namespace Auditoriska5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

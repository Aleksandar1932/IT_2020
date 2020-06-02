using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IT_lab5.Startup))]
namespace IT_lab5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

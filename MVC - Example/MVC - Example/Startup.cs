using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC___Example.Startup))]
namespace MVC___Example
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

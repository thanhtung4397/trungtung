using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aaa.Startup))]
namespace aaa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(publish_git2.Startup))]
namespace publish_git2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

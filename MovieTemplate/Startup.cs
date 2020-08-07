using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieTemplate.Startup))]
namespace MovieTemplate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

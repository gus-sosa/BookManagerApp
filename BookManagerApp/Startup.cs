using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookManagerApp.Startup))]
namespace BookManagerApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(masterpiece.Startup))]
namespace masterpiece
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

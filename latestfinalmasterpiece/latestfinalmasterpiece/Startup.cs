using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(latestfinalmasterpiece.Startup))]
namespace latestfinalmasterpiece
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

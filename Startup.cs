using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(emppro.Startup))]
namespace emppro
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

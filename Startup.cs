using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SanfordMIS4200.Startup))]
namespace SanfordMIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

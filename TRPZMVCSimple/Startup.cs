using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TRPZMVCSimple.Startup))]
namespace TRPZMVCSimple
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

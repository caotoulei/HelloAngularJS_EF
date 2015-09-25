using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloAngularJS_EF.Startup))]
namespace HelloAngularJS_EF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

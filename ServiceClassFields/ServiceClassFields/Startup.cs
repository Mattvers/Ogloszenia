using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ServiceClassFields.Startup))]
namespace ServiceClassFields
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRUDWebAPI_Client.Startup))]
namespace CRUDWebAPI_Client
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

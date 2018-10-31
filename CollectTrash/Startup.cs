using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CollectTrash.Startup))]
namespace CollectTrash
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

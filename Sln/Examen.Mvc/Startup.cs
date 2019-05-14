using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Examen.Mvc.Startup))]
namespace Examen.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

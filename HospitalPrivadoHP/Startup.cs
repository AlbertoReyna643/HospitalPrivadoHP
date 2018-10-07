using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HospitalPrivadoHP.Startup))]
namespace HospitalPrivadoHP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NawazEyeWebProject.Startup))]
namespace NawazEyeWebProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}

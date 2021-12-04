using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCCodeFirst_TrainingAcademySln.Startup))]
namespace MVCCodeFirst_TrainingAcademySln
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

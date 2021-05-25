using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(assignment_2_task_6.Startup))]
namespace assignment_2_task_6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BleToDo0._2.Startup))]
namespace BleToDo0._2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

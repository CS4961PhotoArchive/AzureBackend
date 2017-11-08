using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(boephotoarchiveService.Startup))]

namespace boephotoarchiveService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}
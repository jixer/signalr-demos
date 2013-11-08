using Microsoft.Owin;
using Owin;

namespace BBC.TornadoAlertSystem.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
} 
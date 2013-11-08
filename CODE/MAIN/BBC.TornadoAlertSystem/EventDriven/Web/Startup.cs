using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;

namespace BBC.TornadoAlertSystem.Web
{
    public class Startup
    {        
        public void Configuration(IAppBuilder app)
        {
            string sbConnectionString = "Endpoint=sb://sigr-demo.servicebus.windows.net;SharedSecretIssuer=owner;SharedSecretValue=cFp+1HEc7OyhqcbrmVME3J/NdWY5tyUNIDtkft6KRUY=";
            string sbTopicPrefix = "backplane";
            GlobalHost.DependencyResolver.UseServiceBus(sbConnectionString, sbTopicPrefix);

            app.MapSignalR();
        }
    }
} 
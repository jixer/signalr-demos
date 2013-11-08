using BBC.TornadoAlertSystem.Web.Models;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BBC.TornadoAlertSystem.Web.Hubs
{
    public class TornadoAlertsHub : Hub
    {
        public void SendTornadoAlert(TornadoAlert alert)
        {
            Clients.All.addTornadoAlertMessage(alert);
        }
    }
}
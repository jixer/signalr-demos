using BBC.TornadoAlertSystem.Service.Contract;
using BBC.TornadoAlertSystem.Web.Hubs;
using BBC.TornadoAlertSystem.Web.Models;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BBC.TornadoAlertSystem.Web.Service
{
    public class TornadoAlertService : ITornadoAlert
    {
        public void ReceiveAlert(TornadoAlertMessage alert)
        {
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<TornadoAlertsHub>();
            TornadoAlert tornadoAlert = new TornadoAlert() { Name = alert.Name, Location = alert.Location };
            hubContext.Clients.All.addTornadoAlertMessage(tornadoAlert);
        }
    }
}
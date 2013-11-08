using BBC.TornadoAlertSystem.Service.Contract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBC.TornadoAlertSystem.DisasterCenter.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            using (var cf = new ChannelFactory<ITornadoAlert>(""))
            {
                var channel = cf.CreateChannel();

                var alert = new TornadoAlertMessage() { Name = txtName.Text, Location = txtLocation.Text };
                channel.ReceiveAlert(alert);
            }
        }
    }
}

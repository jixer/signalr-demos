using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BBC.TornadoAlertSystem.Service.Contract
{
    [DataContract]
    public class TornadoAlertMessage
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Location { get; set; }
    }
}

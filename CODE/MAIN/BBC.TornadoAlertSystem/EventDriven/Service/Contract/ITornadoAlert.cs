using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BBC.TornadoAlertSystem.Service.Contract
{
    [ServiceContract]
    public interface ITornadoAlert
    {
        [OperationContract(IsOneWay=true)]
        void ReceiveAlert(TornadoAlertMessage alert);
    }
}

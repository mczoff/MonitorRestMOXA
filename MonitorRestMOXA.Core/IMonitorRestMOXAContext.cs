using MonitorRestMOXA.Core.Abstractions;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorRestMOXA.Core
{
    public interface IMonitorRestMOXAContext
    {
        IRestClient Client { get; set; }
        Dictionary<string, string> MandatoryHeaders { get; }

        ISystemInfoCategory SystemInfoCategory { get; set; }
        IDigitalInputCategory DigitalInputCategory { get; set; }
        IRelayCategory RelayCategory { get; set; }
    }
}


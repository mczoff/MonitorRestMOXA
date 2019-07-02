using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorRestMOXA.Core.Abstractions
{
    public interface ILan
    {
        string LanMac { get; set; }
        string LanIp { get; set; }
    }
}

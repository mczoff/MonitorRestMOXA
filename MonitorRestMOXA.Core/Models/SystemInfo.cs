using Newtonsoft.Json;
using MonitorRestMOXA.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorRestMOXA.Core.Models
{
    public class SystemInfo
        : ISystemInfo
    {
        public Device[] Device { get; set; }
        public Network Network { get; set; }
    }
}

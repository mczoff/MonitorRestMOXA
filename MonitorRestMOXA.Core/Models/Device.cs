using MonitorRestMOXA.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorRestMOXA.Core.Models
{
    public class Device
        : IDevice
    {
        public string ModelName { get; set; }
        public string DeviceName { get; set; }
        public DateTime DeviceUpTime { get; set; }
        public string FirmwareVersion { get; set; }
    }
}

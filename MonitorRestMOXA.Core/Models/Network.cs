using MonitorRestMOXA.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorRestMOXA.Core.Models
{
    public class Network
        : INetwork
    {
        public Lan Lan { get; set; }
    }
}

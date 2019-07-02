using MonitorRestMOXA.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorRestMOXA.Models
{
    public class RelayModel
    {
        public Relay Relay { get; set; }
        public string Label
            => $"Rl: {Relay.Index}";
    }
}

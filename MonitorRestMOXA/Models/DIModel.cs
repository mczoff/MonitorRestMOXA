using MonitorRestMOXA.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorRestMOXA.Models
{
    public class DIModel
    {
        public DigitalInput DigitalInput { get; set; }
        public string Label
            => $"DI: {DigitalInput.Index}";
    }
}

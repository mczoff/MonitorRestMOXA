using MonitorRestMOXA.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorRestMOXA.Core
{
    public class MonitorRestMOXAContextStartupParams
    {
        public string Host { get; set; }
        public ModuleMXIOType ModuleType { get; set; }
    }
}

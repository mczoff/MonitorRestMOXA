using Newtonsoft.Json;
using MonitorRestMOXA.Core.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorRestMOXA.Core.Collection
{
    public class RelayCollection
        : Collection<Relay>
    {
        public RelayCollection(IList<Relay> list) 
            : base(list)
        {
        }
    }
}

using MonitorRestMOXA.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorRestMOXA.Core.Abstractions
{
    public interface ISystemInfoCategory
        : IGetCategory<ISystemInfo>, IAsyncGetCategory<ISystemInfo>
    {
    }
}

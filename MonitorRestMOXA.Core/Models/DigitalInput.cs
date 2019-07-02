﻿using Newtonsoft.Json;
using MonitorRestMOXA.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorRestMOXA.Core.Models
{
    public class DigitalInput
        : IDigitalInput
    {
        [JsonProperty("diIndex")]
        public int Index { get; set; }

        [JsonProperty("diMode")]
        public int Mode { get; set; }

        [JsonProperty("diStatus")]
        public int Status { get; set; }
    }
}

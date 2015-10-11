using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle.NET
{
    public class FunctionResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("last_app")]
        public string LastApp { get; set; }

        [JsonProperty("connected")]
        public string Connected { get; set; }

        [JsonProperty("return_value")]
        public int ReturnValue { get; set; }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle.NET
{
    public class ParticleDevice
    {
        internal ParticleClient Client { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("last_app")]
        public string LastApp { get; set; }

        [JsonProperty("last_ip_address")]
        public string LastIpAddress { get; set; }

        [JsonProperty("last_heard")]
        public string LastHeard { get; set; }

        [JsonProperty("product_id")]
        public int ProductId { get; set; }

        [JsonProperty("connected")]
        public string Connected { get; set; }

        public ParticleDeviceInfo GetInfo()
        {
            return Client.GetDeviceInfo(this.Id); 
        }

        public FunctionResponse CallFunction(string functionName, string args)
        {
            return Client.CallFunction(this.Id, functionName, args);
        }
    }
}

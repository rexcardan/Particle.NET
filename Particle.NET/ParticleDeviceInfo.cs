using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Particle.NET
{
    public class ParticleDeviceInfo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("last_app")]
        public string LastApp { get; set; }

        [JsonProperty("variables")]
        public Dictionary<string,string> Variables { get; set; }

        [JsonProperty("functions")]
        public List<string> Functions { get; set; }

        [JsonProperty("product_id")]
        public int ProductId { get; set; }

        [JsonProperty("connected")]
        public string Connected { get; set; }

        [JsonProperty("last_heard")]
        public string LastHeard { get; set; }

        [JsonProperty("cc3000_patch_version")]
        public string PatchVersion { get; set; }

        [JsonProperty("imei")]
        public string Imei { get; set; }
    }
}

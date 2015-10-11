using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Particle.NET
{
    internal class ParticleClient : WebClient
    {
        private string _endpoint = "https://api.particle.io/v1/{0}";
        private string _token;

        internal ParticleClient(string token)
        {
            _token = token;
           // var authInfo = Convert.ToBase64String(Encoding.Default.GetBytes("Bearer " + _token));
            this.Headers[HttpRequestHeader.Authorization] = string.Format("Bearer {0}",_token);
        }

        internal List<ParticleDevice> GetDevices()
        {
            var address = string.Format(_endpoint, "devices");
            var data = this.DownloadString(address);
            var devices = JsonConvert.DeserializeObject<List<ParticleDevice>>(data);
            devices.ForEach(d => d.Client = this);
            return devices;
        }

        internal ParticleDeviceInfo GetDeviceInfo(string id)
        {
            var address = string.Format(_endpoint, "devices/"+id);
            var data = this.DownloadString(address);
            var info = JsonConvert.DeserializeObject<ParticleDeviceInfo>(data);
            return info;
        }

        internal FunctionResponse CallFunction(string pId, string functionName, string args)
        { 
            var address = string.Format(_endpoint, "devices/"+pId+"/"+functionName);
            var response = this.UploadValues(address, new System.Collections.Specialized.NameValueCollection()
            {
                {"arg",args}
            });
            var resp =  System.Text.Encoding.UTF8.GetString(response);
            return JsonConvert.DeserializeObject<FunctionResponse>(resp);
        }
    }
}

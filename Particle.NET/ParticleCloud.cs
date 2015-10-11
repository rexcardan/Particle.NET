using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle.NET
{        /// <summary>
         /// The facade of the particle client for easy to use methods
         /// </summary>
    public class ParticleCloud
    {
        ParticleClient _client;

        /// <summary>
        /// The constructor to access the cloud. Need access token.
        /// </summary>
        /// <param name="token"></param>
        public ParticleCloud(string token)
        {
            _client = new ParticleClient(token);
        }

        /// <summary>
        /// Gets a list of all devices on this account
        /// </summary>
        /// <returns>a list of particle devices</returns>
        public List<ParticleDevice> GetDevices()
        {
            return _client.GetDevices();
        }

        /// <summary>
        /// Gets additional details from the device including functions and variables avaiable
        /// </summary>
        /// <param name="id">the id of the particle device you are calling</param>
        /// <returns>the info from the device</returns>
        public ParticleDeviceInfo GetDeviceInfo(string id)
        {
            return _client.GetDeviceInfo(id);
        }

        /// <summary>
        /// Calls a function for a given device and returns the response
        /// </summary>
        /// <param name="pId">the id of the particle device you are calling</param>
        /// <param name="functionName">the function name to call</param>
        /// <param name="args">the string argument to the function</param>
        /// <returns>a response containing an integer returned from the function</returns>
        public FunctionResponse CallFunction(string pId, string functionName, string args)
        {
            return _client.CallFunction(pId, functionName, args);
        }
    }
}

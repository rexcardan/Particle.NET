# Particle.NET
A Particle IO library for .NET
This library is designed to give you a simple interaction into the little Photon microcontrollers from particle.io. Below is an example of how to get started.
Find out more at https://docs.particle.io/guide/getting-started/intro/photon/
```C#
        static void Main(string[] args)
        {
           //Get your access token at particle.io
            var token = @"12345679abcdefg";
            
            //The connection abstraction
            var pc = new ParticleCloud(token);
            
            //Cool methods to make it easy
            var devices = pc.GetDevices();

            foreach (var d in devices)
            {
                var info = d.GetInfo();
                foreach(var fun in info.Functions)
                {
                    var fArgs = "functionArgs";
                    //ex. d.CallFunction("turnOn","light1");
                    var resp = d.CallFunction(fun, fArgs);
                    Console.WriteLine(resp.ReturnValue);        
                }
            }
            Console.Read();
        }
```

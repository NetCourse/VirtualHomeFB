using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualHome.Devices
{
    class Light : Device
    {
        private string _color = "yellow";
        public Light(string deviceName) : base(deviceName)
        {
        }

        public void setColor(string color)
        {
            _color = color;
            Console.WriteLine("{0} light on {1}", Name, color);
        }
    }
}

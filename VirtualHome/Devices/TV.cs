using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualHome.Devices
{
    class TV : Device
    {
        private int _currentChannel;

        private static List<string> _channelList = new List<string> { "TVN", "Polsat", "MTV", "RTL7" };
        public TV(string deviceName) : base(deviceName)
        {
        }

        public void ChangeChannel()
        {
            Random newChannelIndex = new Random();
            _currentChannel= newChannelIndex.Next(_channelList.Count);
            Console.WriteLine("In {1} tv is {0}", _currentChannel, Name);
        }
    }
}

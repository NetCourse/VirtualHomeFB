using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualHome.Devices
{
    class DoorLock : Device
    {
        private bool _doorLocked = false;
        public DoorLock(string deviceName) : base(deviceName)
        {
        }

        public void Lock()
        {
            _doorLocked = true;
            Console.WriteLine("{0} door is locked", Name);

        }

        public void UnLock()
        {
            _doorLocked = false;
            Console.WriteLine("{0} door is unlocked", Name);
        }

        public void IsLocked()
        {
            Console.WriteLine("{0} door is {1}", Name, _doorLocked ? "locked" : "unlocked");
        }
    }



}

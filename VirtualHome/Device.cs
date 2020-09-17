using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualHome
{
    abstract class Device : IDevice
     {
        public string Name { get; private set; }

        public bool Status { get; private set; }

        public Room Location { get; private set; }

        public Guid DeviceId { get; }


        public Device(string deviceName)
        {
            Name = deviceName;
        }

        //Assign(Room room) ==> Location = room;
        public void Assign(Room room)
        {
            Location = room;
        }

        public void TurnOffDevice()
        {
            Status = false;
            Console.WriteLine("{0} {1} is turned off", Name, this.GetType().ToString().ToLower());
        }

        public void TurnOnDevice()
        {
            Status = true;
            Console.WriteLine("{0} {1} is turned on", Name, this.GetType().ToString().ToLower());
        }
    }
}

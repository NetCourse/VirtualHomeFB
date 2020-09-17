using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualHome
{
    interface IDevice
    {
        Guid DeviceId { get; }

        public void Assign(Room room);

        public void TurnOnDevice();

        public void TurnOffDevice();


    }
}

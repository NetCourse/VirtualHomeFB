using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualHome
{
    class Room
    {
        public string Name { get; set; }

        public RoomList Type { get; set; }

        public Room(string name, RoomList type)
        {
            Type = type;
            Name = name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace NeuronsAdventure.WorldParts
{
    class Room
    {
        public int RoomID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int NorhtRoomID { get; set; }
        public int SouthRoomID { get; set; }
        public int WestRoomID { get; set; }
        public int EastRoomID { get; set; }

        public Room(int roomID, string name, string description, int norht, int south, int west, int east)
        {
            this.RoomID = roomID;
            this.Name = name;
            this.Description = description;
            this.NorhtRoomID = norht;
            this.WestRoomID = west;
            this.SouthRoomID = south;
            this.EastRoomID = east;
        }
    }
}

using NeuronsAdventure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeuronsAdventure.WorldParts
{
    class World
    {
        Player player = new Player(100, 0, 100, "Test player", "you do in fact have a description");

        Dictionary<int, Room> roomsByRoomID = new Dictionary<int, Room>();
        public Room CurrentRoom { get; set; }

        public World()
        {
            roomsByRoomID.Add(0, new Room(0, "první", "První místnost.", 1, 2, 3, -1));
            roomsByRoomID.Add(1, new Room(1, "severní", "severní místnost.", -1, 0, -1, -1));
            roomsByRoomID.Add(2, new Room(2, "jižní", "jižní místnost.", 0, -1, -1, -1));
            roomsByRoomID.Add(3, new Room(3, "západní", "západní místnost.", -1, -1, -1, 0));

            CurrentRoom = roomsByRoomID[0];
        }

        public void MoveRoom(DirectionTypes direction)
        {
            Room newRoom = null;
            switch (direction)
            {                
                case DirectionTypes.North:
                    newRoom = roomsByRoomID[CurrentRoom.NorhtRoomID];
                    break;
                case DirectionTypes.South:
                    newRoom = roomsByRoomID[CurrentRoom.SouthRoomID];
                    break;
                case DirectionTypes.West:
                    newRoom = roomsByRoomID[CurrentRoom.WestRoomID];
                    break;
                case DirectionTypes.East:
                    newRoom = roomsByRoomID[CurrentRoom.EastRoomID];
                    break;
            }

            CurrentRoom = newRoom;

        }


    }
}

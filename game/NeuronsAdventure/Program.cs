using NeuronsAdventure.WorldParts;
using System;

namespace NeuronsAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            World world = new World();

            while(true)
            {
                Console.WriteLine(world.CurrentRoom.Name);
                Console.WriteLine(world.CurrentRoom.Description);

                Console.Write("A co chceš dělat?");
                var input = Console.ReadLine().ToLower();
                if (input.StartsWith("go"))
                {
                    switch (input)
                    {
                        case string a when a.EndsWith("north"):
                            world.MoveRoom(DirectionTypes.North);
                            break;
                        case string a when a.EndsWith("south"):
                            world.MoveRoom(DirectionTypes.South);
                            break;
                        case string a when a.EndsWith("west"):
                            world.MoveRoom(DirectionTypes.West);
                            break;
                        case string a when a.EndsWith("east"):
                            world.MoveRoom(DirectionTypes.East);
                            break;
                    }
                }

                Console.Clear();
            }
        }
    }
}

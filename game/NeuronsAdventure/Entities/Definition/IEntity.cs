using System;
using System.Collections.Generic;
using System.Text;

namespace NeuronsAdventure.Entities.Definition
{
    interface IEntity
    {
        public int Health { get; set; }
        public int Armor { get; set; }
        public int Mana { get; set; }
        public int Stamina { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public EntityTypes EntityType { get; set; }
    }
}

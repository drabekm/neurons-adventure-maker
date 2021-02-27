using NeuronsAdventure.Entities.Definition;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeuronsAdventure.Entities
{
    class Player : IEntity
    {
        public int Health { get; set; }
        public int Armor { get; set; }
        public int Mana { get; set; }
        public int Stamina { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public EntityTypes EntityType { get ; set; }

        public Player(int health, int mana, int stamina, string name, string description)
        {
            this.Health = health;
            this.Mana = mana;
            this.Stamina = stamina;
            this.Name = name;
            this.Description = description;
            EntityType = EntityTypes.Player;
        }
    }
}

using System;

namespace BattleSimEntities
{
    abstract public class GameEntity
    {
        public int Health { get; set; }
        public int Damage { get; set; }
        public int Agility { get; set; }
        abstract public string Name { get; }
        public bool Dead => Health <= 0;

        abstract public bool WeakAgainst(GameEntity entity);
        abstract public bool StrongAgainst(GameEntity entity);

        public GameEntity(int health, int damage, int agility)
        {
            Health = health;
            Damage = damage;
            Agility = agility;
        }
    }
    
}


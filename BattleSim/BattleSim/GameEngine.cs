using BattleSimEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BattleSim
{
    class GameEngine
    {
        private static Random random = new Random();  

        public int Attack(GameEntity attacker, GameEntity defender)
        {
            var damage = (double)random.Next(attacker.Damage / 10, attacker.Damage);

            if (attacker.StrongAgainst(defender))
                damage *= 1.2;

            if (defender.WeakAgainst(attacker))
                damage *= 1.2;

            defender.Health -= (int)damage;

            return (int)damage;
        }
        public (GameEntity First, GameEntity Second) RollForInitiative(GameEntity a, GameEntity b)
        {          
            while (true)
            {
                int rollForA = random.Next(0, a.Agility);               
                int rollForB = random.Next(0, b.Agility);                
                if (rollForA > rollForB)
                {
                    return (a, b);
                }              
                if (rollForB > rollForA)
                {
                    return (b, a);
                }            
            }            
        }
        public void Battle(GameEntity a, GameEntity b)
        {
            var initiative = RollForInitiative(a, b);
            int firstAttack = Attack(initiative.First, initiative.Second);         
            int secondAttack = Attack(initiative.Second, initiative.First);
        }     
    }
}

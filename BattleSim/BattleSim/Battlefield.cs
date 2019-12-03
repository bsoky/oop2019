using BattleSimEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleSim
{
    class Battlefield
    {
        private static Random random = new Random();
        List<GameEntity> listOfPlayers = new List<GameEntity>();
        public string Winner { get; set; }
        

        public Battlefield()
        { }

        public void AddPlayer(GameEntity entity)
        {
            listOfPlayers.Add(entity);
        }

        public void Battle()
        {
            GameEngine game = new GameEngine();
            List<GameEntity> playersHasAttacked = new List<GameEntity>();
            bool invalidEnemy = true;

            // Loops through so that every player attacks once. 
            // How to account for dead players and figure out who wins?
            for (int i = 0; i<listOfPlayers.Count; i++)
            {        
                var player = listOfPlayers[random.Next(listOfPlayers.Count)];
                var secondPlayer = listOfPlayers[random.Next(listOfPlayers.Count)];
                if (player.Dead is true || playersHasAttacked.Contains(player))
                {
                    continue;
                }               
                while (invalidEnemy.Equals(true))
                {
                    if (secondPlayer.Dead) // If secondplayer is dead get a new target to attack
                    {
                        secondPlayer = listOfPlayers[random.Next(listOfPlayers.Count)];
                        continue;
                    }
                    if (player.Name.Equals(secondPlayer.Name)) // Checks if enemy is of same type as attacker
                    {
                        secondPlayer = listOfPlayers[random.Next(listOfPlayers.Count)]; // gets a new target if defender is same as attacker and continues loop
                        continue; 
                    }
                    break;
                }               
                game.Attack(player, secondPlayer);
                playersHasAttacked.Add(player);
            }
            playersHasAttacked.Clear();              
            var listOfDead = listOfPlayers.Where(p => p.Dead == true).ToList();

          
        }
    }
}

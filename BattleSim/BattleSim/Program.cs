using System;
using BattleSimEntities;

namespace BattleSim
{
   
    class Program
    {
        static void Main(string[] args)
        {
            var game = new GameEngine();
            var human = new Human();
            var monster = new Monster();
            var dragon = new Dragon();
            var slime = new Slime();


            // EXERCISE 1 ------------------------------------------------------------           
            //------------------------------------------------------------------------

            //EXERCISE 2 ----------------------------------------------------------------
            //if(monster.WeakAgainst(human))
            //    Console.WriteLine("Monster has weak defense against Human");

            //if (human.StrongAgainst(monster))
            //    Console.WriteLine("Human has strong attack against Monster");

            //if (dragon.StrongAgainst(human) && dragon.StrongAgainst(monster))
            //    Console.WriteLine("Dragon is pretty bad ass...");
            //Console.ReadKey();
            //----------------------------------------------------------------------------

            //EXERCISE 3 -----------------------------------------------------------------
            //Console.WriteLine("Human attacks Monster!");

            //var damage = game.Attack(human, monster);

            //Console.WriteLine($"{damage} points of damage, Monster has {monster.Health} health left!");
            //Console.ReadKey();
            //----------------------------------------------------------------------------

            // EXERCISE 4 ----------------------------------------------------------------
            //while (true)
            //{
            //    var initative = game.RollForInitiative(dragon, slime);

            //    Console.WriteLine($"{initative.First.Name} would attack {initative.Second.Name} first");
            //    Console.ReadKey();
            //}
            //----------------------------------------------------------------------------

            // EXERCISE 5 ----------------------------------------------------------------
            //var counter = 0;

            //while (!dragon.Dead)
            //{
            //    if (slime.Dead)
            //    {
            //        counter++;
            //        slime = new Slime();
            //    }

            //    game.Battle(slime, dragon);
            //}
            //Console.WriteLine($"Slime death counter: {counter}");
            //Console.ReadKey();
            //------------------------------------------------------------------------------

            // EXERCISE 6 ------------------------------------------------------------------
            //Not fully functioning yet..
            var battlefield = new Battlefield();

            // 4 slimes vs 1 monster vs 2 humans 
            battlefield.AddPlayer(new Slime());
            battlefield.AddPlayer(new Slime());
            battlefield.AddPlayer(new Slime());
            battlefield.AddPlayer(new Slime());
            battlefield.AddPlayer(new Monster());
            battlefield.AddPlayer(new Human());
            battlefield.AddPlayer(new Human());

            while (battlefield.Winner == null)
            {
                battlefield.Battle();
            }

            Console.WriteLine($"{battlefield.Winner} is the winner!");
            Console.ReadKey();
            //------------------------------------------------------------------------------------
        }
    }
    
}

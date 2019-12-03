using System;
using System.Collections.Generic;
using System.Text;

namespace BattleSimEntities
{
    public class Monster : GameEntity
    {
        public override string Name => "Monster";

        public Monster() : base(150, 100, 10)
        { }
        

        public override bool StrongAgainst(GameEntity entity)
        {
            if (entity is Slime || entity is Human)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool WeakAgainst(GameEntity entity)
        {
            if (entity is Human || entity is Dragon)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

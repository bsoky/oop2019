using System;
using System.Collections.Generic;
using System.Text;

namespace BattleSimEntities
{
    public class Slime : GameEntity
    {
        public override string Name => "Slime";

        public Slime() : base (50, 20, 5)
        { }

        public override bool StrongAgainst(GameEntity entity)
        {
            return false;
        }

        public override bool WeakAgainst(GameEntity entity)
        {
            return true;
        }
    }
}

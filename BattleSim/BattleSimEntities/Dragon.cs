using System;
using System.Collections.Generic;
using System.Text;

namespace BattleSimEntities
{
    public class Dragon : GameEntity
    {
        public override string Name => "Dragon";

        public Dragon() : base(2000, 200, 30)
        { }

        public override bool StrongAgainst(GameEntity entity)
        {
            return true;
        }

        public override bool WeakAgainst(GameEntity entity)
        {
            return false;
        }
    }
}

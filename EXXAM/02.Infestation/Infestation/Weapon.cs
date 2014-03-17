using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class Weapon : Supplement
    {
        public Weapon(UnitInfo targetUnitId)
             :base(targetUnitId)
        {
            PowerEffect = 10;
            AggressionEffect = 3;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class InfestationSpores : Supplement
    {
        public InfestationSpores(UnitInfo targetUnitId)
             :base(targetUnitId)
        {
            AggressionEffect = 20;
            PowerEffect = -1;
        }
    }
}

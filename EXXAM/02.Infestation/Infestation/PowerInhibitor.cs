using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class PowerInhibitor : Supplement
    {
        public PowerInhibitor(UnitInfo targetUnitId)
             :base(targetUnitId)
        {
            this.PowerEffect = 3;
        }
    }
}

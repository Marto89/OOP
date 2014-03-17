using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class AggressionInhibitor : Supplement
    {
        public AggressionInhibitor(UnitInfo targetUnitId)
             :base(targetUnitId)
        {
            this.AggressionEffect = 3;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class HealthInhibitor : Supplement
    {
         public HealthInhibitor(UnitInfo targetUnitId)
             :base(targetUnitId)
        {
            this.HealthEffect = 3;
        }
    
    }
}

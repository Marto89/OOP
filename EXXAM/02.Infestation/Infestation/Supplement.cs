using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public abstract class Supplement :  ISupplement
    {
        public Supplement(UnitInfo targetUnitId)
        {
            this.TargetUnitId = targetUnitId;
        }

        public UnitInfo TargetUnitId { get; set; }
        public int PowerEffect { get; protected set; }
        public int HealthEffect { get; protected set; }

        public int AggressionEffect { get; protected set; }
        public virtual void ReactTo(ISupplement otherSupplement)
        {
        }
    }
}

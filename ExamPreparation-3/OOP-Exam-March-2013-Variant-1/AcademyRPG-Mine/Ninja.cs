namespace AcademyRPG
{
    using System;
    using System.Collections.Generic;

    public class Ninja : Character, IGatherer, IFighter
    {
        private int increaseAttackPoints = 0;

        public Ninja(string name, Point position, int owner)
            : base(name, position, owner)
        {
            this.HitPoints = 1;

        }

        public int AttackPoints
        {
            get { return increaseAttackPoints; }
        }

        public int DefensePoints
        {
            get { return int.MaxValue; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            int currentHitPoints = 0;
            int seekingIndex = -1;
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != this.Owner && availableTargets[i].Owner != 0 && availableTargets[i].HitPoints > currentHitPoints)
                {
                    seekingIndex = i;
                    currentHitPoints = availableTargets[i].HitPoints;
                }
            }

            return seekingIndex;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone || resource.Type == ResourceType.Lumber)
            {
                this.increaseAttackPoints += resource.Type == ResourceType.Stone ? resource.Quantity * 2 : resource.Quantity;
                return true;
            }
            return false;
        }
    }
}

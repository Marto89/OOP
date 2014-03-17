using System;
using System.Text;
using System.Collections.Generic;

using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public abstract class Machine : IMachine
    {
        private string name;
        private IPilot pilot;
        private double attackPoints;
        private double defensePoints;
        private IList<string> targets;

        public Machine(string initialName, double initialAttackPoint, double initialDefensePoint)
        {
            this.Name = initialName;
            this.AttackPoints = initialAttackPoint;
            this.DefensePoints = initialDefensePoint;
            this.targets = new List<string>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Machine must be create with particular name!");
                }
                this.name = value;
            }
        }

        public IPilot Pilot 
        {
            get 
            { 
                return this.pilot; 
            }
            set
            {
                if(value==null)
                {
                    throw new ArgumentException("Engaged pilot cannot be null!");
                }
                this.pilot = value;

            } 
        }
        public double HealthPoints { get; set; }

        public double AttackPoints
        {
            get
            {
                return this.attackPoints;
            }
            protected set
            {
                if (value == 0)
                {
                    throw new ArgumentNullException("AttackPoints cannot be null!");
                }
                this.attackPoints = value;
            }
        }

        public double DefensePoints
        {
            get
            {
                return this.defensePoints;
            }
            protected set
            {
                if (value == 0)
                {
                    throw new ArgumentNullException("DefensePoints cannot be null!");
                }
                this.defensePoints = value;
            }

        }

        public IList<string> Targets
        {
            get
            {
                return new List<string>(this.targets);
            }
        }

        public void Attack(string target)
        {
            if (string.IsNullOrEmpty(target))
            {
                throw new ArgumentNullException("You must attack particular target!");
            }
            this.targets.Add(target);
        }
        public override string ToString()
        {
           var sb = new StringBuilder();
            sb.AppendLine(string.Format("- {0}", this.Name));
            sb.AppendLine(string.Format(" *Type: {0}", this.GetType().Name));
            sb.AppendLine(string.Format(" *Health: {0}", this.HealthPoints));
            sb.AppendLine(string.Format(" *Attack: {0}", this.AttackPoints));
            sb.AppendLine(string.Format(" *Defense: {0}", this.DefensePoints));

            if (this.Targets.Count < 2)
            {
                var currentTargets = this.Targets.Count == 0 ? "None" : this.Targets[0];
                sb.AppendLine(string.Format(" *Targets: {0}", currentTargets));
            }
            else
            {
                var currentTargets = string.Join(", ", this.Targets);
                sb.AppendLine(string.Format(" *Targets: {0}", currentTargets));
            }


            return sb.ToString();
        }
    }
}

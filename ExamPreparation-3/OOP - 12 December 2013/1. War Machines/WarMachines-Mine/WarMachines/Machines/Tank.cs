using System;
using System.Text;

using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public class Tank : Machine, ITank, IMachine
    {
        private const double InitialHealthPoints = 100;
        private bool defenseMode;

        public Tank(string initialName, double initialAttackPoint, double initialDefensePoint)
            : base(initialName, initialAttackPoint, initialDefensePoint)
        {
            this.HealthPoints = InitialHealthPoints;
            this.DefenseMode = true;
        }

        public bool DefenseMode
        {
            get
            {
                return this.defenseMode;
            }
            private set
            {
                this.defenseMode = value;

                if (this.defenseMode)
                {
                    this.AttackPoints -= 40;
                    this.DefensePoints += 30;
                }
                else
                {
                    this.AttackPoints += 40;
                    this.DefensePoints -= 30;
                }
            }
        }

        public void ToggleDefenseMode()
        {
            this.DefenseMode = !this.DefenseMode;
        }
        public override string ToString()
        {
            var sb = new StringBuilder(base.ToString());
            var currentMode = this.DefenseMode ? "ON" : "OFF";
            sb.AppendLine(string.Format(" *Defense: {0}", currentMode));
            return sb.ToString();
        }
    }
}

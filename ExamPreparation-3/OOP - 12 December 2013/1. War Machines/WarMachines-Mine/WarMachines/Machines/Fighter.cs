using System;
using System.Text;

using WarMachines.Interfaces;


namespace WarMachines.Machines
{
    public class Fighter : Machine, IFighter, IMachine
    {
        private const double InitialHealthPoints = 200;
        private bool stealthMode;

        public Fighter(string initialName, double initialAttackPoint, double initialDefensePoint,bool initialStealthMode)
            :base(initialName,initialAttackPoint,initialDefensePoint)
        {
            this.HealthPoints = InitialHealthPoints;
            this.stealthMode = initialStealthMode;
        }

        public bool StealthMode
        {
            get
            {
                return this.stealthMode;
            }
            private set
            {
                this.stealthMode = value;
            }
        }

        public void ToggleStealthMode()
        {
            this.StealthMode = !this.StealthMode;
        }
        public override string ToString()
        {
            var sb = new StringBuilder(base.ToString());
            var currentMode = this.StealthMode ? "ON" : "OFF";
            sb.AppendLine(string.Format(" *Stealth: {0}", currentMode));
            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public class Pilot : IPilot
    {
        private string name;
        private IList<IMachine> machines;

        public Pilot(string initialName)
        {
            this.Name = initialName;
            this.machines = new List<IMachine>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Pilot name cannot be empty!");
                }
                this.name = value;
            }
        }

        public void AddMachine(IMachine machine)
        {
            if (machine == null)
            {
                throw new ArgumentNullException("You must add a machine!");
            }
            this.machines.Add(machine);
        }

        public string Report()
        {
            var sb = new StringBuilder();
            if (this.machines.Count == 0)
            {
                sb.Append(string.Format("{0} - no machines", this.Name));
            }
            else
            {
                if (this.machines.Count == 1)
                {
                    sb.AppendLine(string.Format("{0} - 1 machine", this.Name));
                }
                else
                {
                    var currentMachines = this.machines
                                       .OrderBy((h) => h.HealthPoints)
                                       .ThenBy((n) => n.Name);
                    sb.AppendLine(string.Format("{0} - {1} machines", this.Name, this.machines.Count));
                }
                foreach (var machine in this.machines)
                {
                    sb.Append(machine.ToString());
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}

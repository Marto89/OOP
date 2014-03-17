//Implement a ParticleRepeller class. A ParticleRepeller is a Particle, which pushes other particles away from it (i.e. accelerates them in a direction, opposite of the direction in which the repeller is). The repeller has an effect only on particles within a certain radius (see Euclidean distance)

using System;

namespace ParticleSystem
{
    public class ParticleRepeller : Particle
    {
        public int RepellerPower { get; protected set; }
        public int RepellerPowerRadius { get; protected set; }
        public ParticleRepeller(MatrixCoords position, MatrixCoords speed, int repellerPower, int repellerPowerRadius)
            : base(position, speed)
        {
            this.RepellerPower = repellerPower;
            this.RepellerPowerRadius = repellerPowerRadius;
        }
    }
}

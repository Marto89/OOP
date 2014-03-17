//Create a ChickenParticle class. The ChickenParticle class moves like a ChaoticParticle, but randomly stops at different positions for several simulation ticks and, for each of those stops, creates (lays) a new ChickenParticle. You are not allowed to edit any existing class.

using System;
using System.Collections.Generic;

namespace ParticleSystem
{
    public class ChickenParticle : ChaoticParticle
    {
        private int delayTicks;
        private int currentDelayTicks;
        public ChickenParticle(MatrixCoords position, MatrixCoords speed, int maxSpeedPerCoordinate, Random randomGenerator,int delayTicks)
            : base(position, speed, maxSpeedPerCoordinate, randomGenerator)
        {
            this.delayTicks = delayTicks;
            this.currentDelayTicks = delayTicks;
        }
        public override IEnumerable<Particle> Update()
        {
            List<ChickenParticle> chickens = new List<ChickenParticle>();

            if (this.Speed.Equals(new MatrixCoords(0, 0)))
            {
                currentDelayTicks--;
                if(currentDelayTicks==0)
                {
                    chickens.Add(new ChickenParticle(this.Position, this.Speed, this.MaxSpeedPerCoordinate, this.RandomGenerator, this.delayTicks));
                    chickens[0].Move();
                    base.Move();
                    currentDelayTicks = delayTicks;
                }
            }
            else
            {
                base.Move();
            }
            return chickens;
        }


    }
}
